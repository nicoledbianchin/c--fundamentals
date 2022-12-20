using System;

namespace Moedas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Tipo para moedas");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            TipoParaMoeda();
        }

        static void TipoParaMoeda()
        {
            decimal valor = 10.15m; // mais comumente usado para moedas por conta da precisão
            Console.WriteLine(valor);
        }
    }
}
