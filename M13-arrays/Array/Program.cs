using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Arrays");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Arrays();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Percorrendo um array");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            PercorrendoArray();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("ForEach");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            ForEach();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Alterando os valores");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            AlterandoValores();
        }

        static void Arrays()
        {
            var array = new int[6] {0, 1, 2, 3, 4, 5};
            int[] array2;
            Console.WriteLine(array[0]);
            array[0] = 8;
            Console.WriteLine(array[0]);
        }

        static void PercorrendoArray()
        {
            var array = new int[4] {2, 4, 8, 16};
            Console.WriteLine("Comprimento do array: " + array.Length);

            for(var i = 0; i < array.Length; i++) 
            {
                Console.WriteLine("Item na posição " + i + ": " + array[i]);
            }
        }

        static void ForEach()
        {
            var array = new int[4] {2, 4, 8, 16};
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        static void AlterandoValores()
        {
            var array = new int[4];
            var arrayCopia = array; // arrayCopia não é um array novo, se eu alterar o array, altera o arrayCopia

            array[0] = 8;
            Console.WriteLine(array[0]);
            Console.WriteLine(arrayCopia[0]);

            var novoArray = new int[4]; 
            novoArray[0] = array[0];
            array[0] = 4;
            Console.WriteLine(novoArray[0]);
        }
    }
}
