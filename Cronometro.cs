using System;
using System.Threading;

namespace Cronometro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Start(10);
        }

        static void Start(int time) // inclui um paramentro
        {
            int currentTime = 0; // Incremento

            while (currentTime != time) //sempre executa aldo dada uma condição e ela tem que ser True.
            {

                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(300);
            }
            Console.ReadKey();

        }
    }
}
