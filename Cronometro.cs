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
            Console.WriteLine("S = Segundos");
            Console.WriteLine("M = Minutos");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar: ");
            Console.ResetColor();

            Console.ReadKey();
        }

        static void Start(int time) // inclui um paramentro
        {
            int currentTime = 0; 

            while (currentTime != time) //sempre executa aldo dada uma condição e ela tem que ser True.
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(2000);
            }

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Cronômetro finalizado");
            Thread.Sleep(2500);
        }
    }
}
