using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class OverflowException
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a very large integer");
            try
            {
                int integer = int.Parse(Console.ReadLine());
                Console.WriteLine($"You entered the number as:{integer}");
            }
            catch (System.OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
