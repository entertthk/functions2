using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            string id;
            Console.WriteLine("Enter your ID code: ");
            id = Console.ReadLine();
            bool idValid;
            idValid = CheckIdLength(id);

            if(idValid)
            {
                GetGender(id);
                GetYear(id);
            }
            else
            {
                Console.WriteLine("Not OK");
            }

            Console.ReadLine();

        }

        public static void GetGender(string idCode)
        {
            int firstNumber = int.Parse(idCode[0].ToString());
            if(firstNumber == 4 || firstNumber == 6 || firstNumber == 2)
            {
                Console.WriteLine("Hello, Madam!");
            }
           
            else
            {
                Console.WriteLine("Hello, Sir!");
            }


        }

        public static bool CheckIdLength(string idCode)
        {
            bool isValid;
            if(idCode.Length == 11)
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }
            return isValid;
        }

        public static void GetYear(string idCode)
        {
            string year = idCode.Substring(1, 2);
            string fullYear = $"19{year}";
            Console.WriteLine($"Your year of birth is: {fullYear}");

        }

    }
}
