using System;
using System.IO;
using System.Threading;

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
                    OpenFile();
                    break;
                case 2:
                    EditFile();
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

        static void OpenFile(){
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo?");
            string path = Console.ReadLine();
            using(var file = new StreamReader(path)){
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }
            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }
        
        static void EditFile(){
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para sair):");
            Console.WriteLine("--------------------");
            string text = "";

            do{
                text += Console.ReadLine();
                text += Environment.NewLine;
            } while(Console.ReadKey().Key != ConsoleKey.Escape);
            
            SaveTextToFile(text);
        }  

        static void SaveTextToFile(string text){
            Console.Clear();
            Console.WriteLine("Qual caminho para salvar o arquivo?");
            var path = Console.ReadLine();

            // os objetos passado no using
            // vai ser aberto e fechado
            // útil para manipular arquivos, conexão de banco de dados, etc
            // pois não precisamos nos preocupar em fechar a conexão ou o arquivo
            using(var file = new StreamWriter(path)){
                file.Write(text);
            }

            Console.WriteLine($"Arquivo salvo com sucesso no caminho {path}.");
            Thread.Sleep(2500);
            Menu();
        } 
    }
}
