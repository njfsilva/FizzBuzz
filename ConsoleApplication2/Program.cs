using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isDiv5 = false;
            bool isDiv3 = false;
            bool isBoth = false;

            for (int i = 0; i < 99; i++)
            {
                isDiv5 = i % 5 == 0;
                isDiv3 = i % 3 == 0;
                isBoth = isDiv5 && isDiv3;

                if (isBoth)
                    Console.WriteLine("FizzBuzz");
                else if (isDiv3)
                    Console.WriteLine("Fizz");
                else if (isDiv5)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
            //For Pausing the console
            Console.ReadLine();
        }
    }
}