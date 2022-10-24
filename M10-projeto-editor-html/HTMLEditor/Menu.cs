using System;

namespace HTMLEditor 
{
    public static class Menu 
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;
            DrawScreen(30, 10);
        }

        private static void DrawScreen(int columns, int lines)
        {
            DrawDashes(columns);
            for(int l = 0; l <= lines; l++) 
            {
                Console.Write("|");
                for(int i = 0; i <= columns; i++) Console.Write(" ");
                Console.Write("|");
                Console.Write("\n");
            }
            DrawDashes(columns);
        }

        private static void DrawDashes(int columns)
        {
            Console.Write("+");
            for(int i = 0; i <= columns; i++) Console.Write("-");
            Console.Write("+");
            Console.Write("\n");
        }
    }
}