using Library;
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your two double or interger number:");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            double result = Calculation.Addition(firstNumber, secondNumber);
            Console.WriteLine($"Your Addition is {result}");
            Console.ReadKey();
        }
    }
}
