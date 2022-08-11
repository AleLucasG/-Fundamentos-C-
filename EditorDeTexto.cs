using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("O que vocÊ quer fazer?");
            Console.WriteLine("1 - Abrir um aruqivo de texto");
            Console.WriteLine("2 - Criar novo arquivo.");
            Console.WriteLine("0 - Sair");
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

            Console.Write(texto);

        }
    }

}
