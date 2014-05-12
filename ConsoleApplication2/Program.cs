using System;
using System.Text;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
           for (var i = 0; i < 99; i++)
            {
                var isDiv5 = i % 5 == 0;
                var isDiv3 = i % 3 == 0;
                var isBoth = isDiv5 && isDiv3;

                if (isBoth)
                    Console.WriteLine("FizzBuzz");
                else if (isDiv3)
                    Console.WriteLine("Fizz");
                else if (isDiv5)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
            //Pausing the console
            Console.ReadLine();
        }
    }
}
