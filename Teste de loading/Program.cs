using System;
using System.Threading;

namespace ala
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (var i = 0; i < 20; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Thread.Sleep(50);
                Console.Write("|||");
                
            }
            
            Console.WriteLine("");
            Console.WriteLine("Loading concluido");
        }
    }
}
