﻿using System;
using System.IO;

namespace EditorDeTexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que você quer fazer?");
            Console.WriteLine("1 - Abrir um arquivo de texto.");
            Console.WriteLine("2 - Criar novo arquivo.");
            Console.WriteLine("0 - Sair.");
            Console.Write($"Opção: ");
            short opções = short.Parse(Console.ReadLine());
            

            switch (opções) // enquanto for verdade, execute
            {
                case 0: System.Environment.Exit(0);
                    break;
                case 1: Abrir();
                    break;
                case 2: Editar();
                    break;
                default: Menu();
                    break;
            }
            Console.ReadKey();
        }

        static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo? ");
            string path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                string texto = file.ReadToEnd();
                Console.WriteLine(texto);
            }
            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }

        static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
            Console.WriteLine(" ==================================== ");
            string texto = " ";

            do
            {
                texto += Console.ReadLine();     // tudo que tem um texto, + o que for digitado
                texto += Environment.NewLine;
            }

            // enquanto o usuario não precionar ESC, execute...
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Salvar(texto);

        }

        static void Salvar(string texto)
        {
            Console.Clear();
            Console.WriteLine("Qual caminho para salvar o arquivo?");
            var path = Console.ReadLine();

            using (var arquivo = new StreamWriter(path))    //fluxo de escrita
            {
               arquivo.Write(texto);
            }

            Console.WriteLine($"Arquivo {path} salvo com sucesso!");
            Console.ReadLine();
            Menu();
        }
    }

}
