using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class FormatException
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            try
            {
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine($"You entered the number as: {num}");
            }
            catch(System.FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
