using System.Globalization;
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

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Formatando moedas");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            FormatandoMoedas();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Math");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            FuncaoMath();
        }

        static void TipoParaMoeda()
        {
            decimal valor = 10.15m; // mais comumente usado para moedas por conta da precisão
            Console.WriteLine(valor);
        }

        static void FormatandoMoedas()
        {
            decimal valor = 10.15m;

            Console.WriteLine(valor.ToString(
                "G",
                CultureInfo.CreateSpecificCulture("en-US")
            ));

            Console.WriteLine(valor.ToString(
                "G",
                CultureInfo.CreateSpecificCulture("pt-BR")
            ));

            Console.WriteLine(valor.ToString(
                "C",
                CultureInfo.CreateSpecificCulture("pt-BR")
            ));

            Console.WriteLine(valor.ToString(
                "C",
                CultureInfo.CreateSpecificCulture("en-US")
            ));

            Console.WriteLine(valor.ToString(
                "E04",
                CultureInfo.CreateSpecificCulture("pt-BR")
            ));

            Console.WriteLine(valor.ToString(
                "F",
                CultureInfo.CreateSpecificCulture("en-US")
            ));

            Console.WriteLine(valor.ToString(
                "N",
                CultureInfo.CreateSpecificCulture("pt-BR")
            ));

            Console.WriteLine(valor.ToString(
                "P",
                CultureInfo.CreateSpecificCulture("pt-BR")
            ));
        }

        static void FuncaoMath()
        {
            decimal valor = 10.15m;
            Console.WriteLine(Math.Round(valor));

            decimal outroValor = 10.87m;
            Console.WriteLine(Math.Round(outroValor));

            Console.WriteLine(Math.Ceiling(valor));
            Console.WriteLine(Math.Floor(valor));
        }
    }
}
