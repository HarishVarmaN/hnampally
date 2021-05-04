using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalSkills
{
    class Program
    {
        static void Main(string[] args)
        {
            program1();
            program2();
        }

        public static void program1()
        {
            string divBy3 = "fizz";
            string divBy5 = "buzz";
            bool isExists = false;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    isExists = true;
                    Console.Write(divBy3);
                }
                if (i % 5 == 0)
                {
                    isExists = true;
                    Console.Write(divBy5);
                }
                if (isExists)
                {
                    Console.WriteLine();
                    isExists = false;
                }
                if (i == 100)
                {
                    Console.ReadKey();
                }
            }
        }

        public static void program2()
        {
            string input = Console.ReadLine();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
            Console.ReadKey();
        }
    }
}
