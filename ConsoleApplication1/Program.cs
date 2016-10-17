using System;

namespace ConsoleApplication1
{
    class Program
    { 
        static void Main(string[] args)
        {
            Cyclist cyclist = null;
            //geht nur mit VisualStudio 2015
            cyclist?.ring();

            cyclist = new Cyclist();
            cyclist.ring();
            Console.Read();
           
        }
    }
}
