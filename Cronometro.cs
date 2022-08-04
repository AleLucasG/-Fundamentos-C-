using System;
using System.Threading;

namespace Cronometro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        static void Start(int time)
        {
            int time = 10;
            int currentTime = 0; // Incremento

            while (currentTime != time) //sempre executa aldo dada uma condição e ela tem que ser True.
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);

                Console.ReadKey();
            }
        }
    }
}
