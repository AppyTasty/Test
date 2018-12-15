using System;

namespace Sumof2numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Please enter a second number: ");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine("The sum of two nos is: {0}", sum);
            Console.ReadLine();
        }
    }
}
