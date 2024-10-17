using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class NullReference
    {
        static void Main(string[] args)
        {
            try
            {
                string text = null;
                int length = text.Length;
                Console.WriteLine($"Length of the string: {length}");
            }
            catch (System.NullReferenceException ex)
            {
                Console.WriteLine("Error: Attempted to access a method or property of a null object.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}