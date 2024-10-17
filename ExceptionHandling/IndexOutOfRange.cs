using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class IndexOutOfRange
    {
        static void Main(string[] args)
        {
            string[] elements = { "Apple", "Banana", "Cherry", "BlueBerry", "Mango" };
            try
            {
                Console.WriteLine("Enter an index");
                int index = int.Parse(Console.ReadLine());
                Console.WriteLine($"Elements at the {index} is : {elements[index]}");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
