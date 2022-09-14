using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Soma();
            Subtracao();
        }

        static void Soma()
        {
            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float resultado = valor1 + valor2;

            Console.WriteLine($"\nResultado da soma: {resultado}\n");
            Console.ReadKey();
        }

        static void Subtracao()
        {
            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float resultado = valor1 - valor2;

            Console.WriteLine($"\nResultado da subtração: {resultado}");
            Console.ReadKey();
        }
    }
}
