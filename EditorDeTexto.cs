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
            Console.Write("O que vocÊ quer fazer? ");
            Console.WriteLine("1 - Abrir um aruqivo de texto");
            Console.WriteLine("2 - Criar novo arquivo.");
            Console.WriteLine("0 - Sair");
            short opções = short.Parse(Console.ReadLine());

            switch (opções)
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
        }

        static void Abrir()
        {

        }

        static void Editar()
        {

        }
    }

}
