using System;

namespace ConsoleApplication1
{
    class Program
    { 
        static void Main(string[] args)
        {
            Cyclist cyclist = null;
            cyclist?.ring();

            cyclist = new Cyclist();
            cyclist.ring();
            Console.Read();
           
        }
    }
}
