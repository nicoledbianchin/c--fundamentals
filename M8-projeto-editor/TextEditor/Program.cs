using System;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu() {
            Console.Clear();
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar novo arquivo");
            Console.WriteLine("0 - Sair");
            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    AbrirArquivo();
                    break;
                case 2:
                    CriarArquivo();
                    break;
                case 0:
                    Console.WriteLine("Saindo do sistema.");
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    Menu();
                    break;
            }

        }

        static void AbrirArquivo(){

        }
        
        static void CriarArquivo(){

        }   
    }
}
