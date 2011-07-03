using System;

namespace SimpleHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name?");
            var username = Console.ReadLine();
            Console.WriteLine("Hello, {0}",username);
            Console.ReadKey();
        }
    }
}
