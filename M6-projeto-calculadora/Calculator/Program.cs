﻿using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair\n");

            short opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Soma();
                    break;
                case 2:
                    Subtracao();
                    break;
                case 3:
                    Divisao();
                    break;
                case 4:
                    Multiplicacao();
                    break;
                case 5:
                    Console.WriteLine("Fechando sistema\n");
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida\n");
                    Menu();
                    break;
            }
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
            Menu();
        }

        static void Subtracao()
        {
            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float resultado = valor1 - valor2;

            Console.WriteLine($"\nResultado da subtração: {resultado}\n");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float resultado = valor1 / valor2;

            Console.WriteLine($"\nResultado da divisão: {resultado}\n");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float resultado = valor1 * valor2;

            Console.WriteLine($"\nResultado da multiplicação: {resultado}\n");
            Console.ReadKey();
            Menu();
        }
    }
}
