using System;

namespace TesteAulaBalta
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
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Qual calculo deseja efetuar?");
            Console.ResetColor();
            Console.WriteLine("");

            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");
            Console.ResetColor();
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Digite a opção escolhida: ");
            short resp = short.Parse(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine();

            switch (resp)
            {
                case 1: Soma();
                    break;
                case 2: Subtracao();
                    break;
                case 3: Multiplicacao();
                    break;
                case 4: Divisao();
                    break;
                case 5: System.Environment.Exit(0);
                    break;
                default: Menu();
                    break;
            }

            Console.ReadKey();
        }
        
       static void Soma()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Calculo de Soma");
            Console.Write("Digite o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float result = valor1 + valor2;
            Console.WriteLine($"Resultado da Soma é: {result}");

            Console.ReadKey();
            Menu();
        }

       static void Subtracao()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Calculo de Subtração");
            Console.Write("Escreva o primeiro valor: ");
            float valor1 = float.Parse((string)Console.ReadLine());

            Console.Write("Escreva o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float result = valor1 - valor2;
            Console.WriteLine($"O resultado da Subtração é: {result}");

            Console.ReadKey();
            Menu();
        }

       static void Multiplicacao()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Calculo de Multiplicação");

            Console.Write("Digite o primeiro valor: ");
            float valor1 = float.Parse((string)Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            float valor2 = float.Parse(((string)Console.ReadLine()).Trim());

            float result = valor1 * valor2;
            Console.WriteLine($"Resulta da Multiplicação é: {result}");

            Console.ReadKey();
            Menu();
        }

        
       static void Divisao()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Calculo de Divisão");

            Console.Write("Digite o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float result = valor1 / valor2;
            Console.WriteLine($"O resultado da Divisão é: {result}");
            Console.ResetColor();

            Console.ReadKey();
            Menu();
        } 
    }

}


