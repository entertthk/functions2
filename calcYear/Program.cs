using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calcYear
{
    class Program
    {
        static void Main(string[] args)
        {

            int year;
            Console.WriteLine("What year did you born: ");
            year = int.Parse(Console.ReadLine());

            calculateAge(year);

            Console.ReadLine();
        }

        public static void calculateAge(int year)
        {
            Console.WriteLine($"You are {2019 - year} years old");
        }

    }
}
