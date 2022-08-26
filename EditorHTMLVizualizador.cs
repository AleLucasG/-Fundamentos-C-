using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Editor_HTML
{
    public class Vizualizador
    {
        public static void Show(string texto)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO VIZUALIZAÇÃO");
            Console.WriteLine("-----------------");
            Substituir(texto);
            Console.WriteLine("-----------------");
            Console.ReadKey();
            Menu.Show();
        }
        public static void Substituir(string texto)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*\/s*strong>"); // String que subtituiu outra string
            var palavras = texto.Split(' ');

            for (var i = 0;
                i < palavras.Length;
                i++)
            {
                if (strong.IsMatch(palavras[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(
                        palavras[i].Substring(
                            palavras[i].IndexOf('>') +1,
                            (
                            palavras[i].LastIndexOf('<') -1) - 
                            palavras[i].IndexOf('>')));

                    Console.Write(" ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(palavras[i]);
                    Console.Write(' ');
                }
            }
        }
    }
}
