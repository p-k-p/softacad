using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            double n2 = double.Parse(Console.ReadLine());
            
            if (n2 < n1)
            {
                Console.WriteLine("Numbers are " + n2 + " and " + n1);
            }
            else
            {
                Console.WriteLine("Numbers are " + n1 + " and " + n2);
            }

            Console.ReadKey();
        }
    }
}
