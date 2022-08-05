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

            Console.WriteLine(" ====== Cronômetro ====== ");
            Console.WriteLine("");
            Console.WriteLine("S = Segundo => 10seg = 10 segundos");
            Console.WriteLine("M = Minuto => 1min = 60 segundos");
            Console.WriteLine("0 = Sair");

            Console.Write("Quanto tempo deseja contar: ");
            string data = Console.ReadLine().ToLower();

            char type = char.Parse(data.Substring(data.Length -1, 1));
            int time = int.Parse(data.Substring(0, data.Length -1));
            int multiplicador = 1;

            if (type == 'm')
                multiplicador = 60;

            if (time == 0)
                Environment.Exit(0);

            PresStar(time * multiplicador);

            Console.ReadKey();
        }

        static void PresStar(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            Start(time);
        }

        static void Start(int time)
        {
            // int time = 10; - foi declado na função Start //
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Cronômetro finalizado");
            Thread.Sleep(1000);
            Menu();
        }
    }
}
