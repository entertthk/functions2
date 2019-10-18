using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;

            Console.WriteLine($"Are you coming or leaving?");

            answer = Console.ReadLine();

            if (answer == "coming")
            {
                Hello();
            }

            else (answer == "leaving")
            {
                Bye();
            }

            Console.ReadLine();
        }

        public static void Hello()
        {
            Console.WriteLine("Hello");
        }

        public static void Bye()
        {
            Console.WriteLine("Bye");
        }

        
    }
}
