using System;

namespace ExceptionHandling
{
    public class DivideByZero
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the first number: ");
                int number1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int number2 = int.Parse(Console.ReadLine());

                int result = number1 / number2;
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("You are trying to divide the number by zero");
            }
        }
    }
}
