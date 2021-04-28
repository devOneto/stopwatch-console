using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stopwatch.");
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = segundos");
            Console.WriteLine("M = minutos");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Oque desejafazer?");
            
            string data = Console.ReadLine().ToLower();
            char type = Convert.ToChar(data.Substring(data.Length - 1,1));
            Console.WriteLine(type);
            int time = Convert.ToInt32(data.Substring(0,data.Length - 1));
            Console.WriteLine(time);
            int multiplier = 60;

            switch(type){
                case 's': Start(time); break;
                case 'm': Start(time*multiplier); break;
                default: Menu(); break;
            }

        }

        static void Start(int time)
        {
            int currentTime = 0;
            while ( currentTime != time )
            {
                Console.Clear();
                currentTime ++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stop!");

            Thread.Sleep(500);
        }
    }
}
