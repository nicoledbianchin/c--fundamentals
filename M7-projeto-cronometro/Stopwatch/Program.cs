using System;
using System.Threading;

namespace Stopwath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Start();
        }

        static void Start() {
            int time = 10;
            int currentTime = 0;

            while(time != currentTime) {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
        }
    }
}
