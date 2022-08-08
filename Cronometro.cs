using System;
using System.Threading;

namespace Cronometro
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

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" ====== Cronômetro ====== ");
            Console.WriteLine("");
            Console.WriteLine("S = Segundo => 10seg = 10 segundos");
            Console.WriteLine("M = Minuto => 1min = 60 segundos");
            Console.WriteLine("0s = Sair");

            Console.Write("Quanto tempo deseja contar: ");
            string valorDig = Console.ReadLine().ToLower();
            Console.ResetColor();

            int tempo = int.Parse(valorDig.Substring(0, valorDig.Length - 1));
            char tipo = char.Parse(valorDig.Substring(valorDig.Length - 1, 1));

            int multiplicador = 1;


            if (tipo == 'm')
                multiplicador = 60;

            if (tempo == 0)
                Environment.Exit(0);

            PresStar(tempo * multiplicador);

            Console.ReadKey();
        }

        static void PresStar(int tempo)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);
            Console.ResetColor();

            Start(tempo);
        }

        static void Start(int tempo)
        {
            // int time = 10; - foi declado na função Start //
            int currentTime = 0;

            while (currentTime != tempo)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Cronômetro finalizado");
            Thread.Sleep(1000);
            Console.ResetColor();
            Menu();
        }
    }
}
