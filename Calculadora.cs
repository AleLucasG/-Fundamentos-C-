using System;

namespace Calculadora
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
            Console.WriteLine("Qual calculo deseja efetuar?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");
            Console.WriteLine();

            Console.Write("Selecione uma opção: ");
            short resp = short.Parse(Console.ReadLine());

            switch (resp)
            {
                case 1: Soma();
                    break;
                case 2: Subtracao();
                    break;
                case 3: Divisao();
                    break;
                case 4: Multiplicacao();
                    break;
                case 5: Environment.Exit(0); //System.Environment.Exit(0)
                    break;
                default: Menu(); // caso a opção seja digitado errado, permance no Menu.
                    break;
            }

            Console.ReadKey();
        }
        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Calculo de Soma");
            Console.Write("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;
            // Console.WriteLine("Resultado da soma é: " + resultado);
            Console.WriteLine($"Resultado da soma é: {resultado}."); //interpolação de string

            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Calculo de Subtração");
            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 - v2;
            Console.WriteLine($"Resultado da subtração é: {resultado}.");

            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Calculo de Divisão");
            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 / v2;
            Console.WriteLine($"Resultdo da divisão é: {resultado}.");

            Console.ReadKey();
            Menu();

        }
        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Calculo de Multiplicação");
            Console.Write("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 * v2;
            Console.WriteLine($"Resultado da multiplicação é: {resultado}");

            Console.ReadKey();
            Menu();
        }
    }

}
