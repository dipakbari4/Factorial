using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            int factorial = 1;

            for(int i=1; i<=num; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine("Factorial of " + num + " is " + factorial);
        }
    }
}
