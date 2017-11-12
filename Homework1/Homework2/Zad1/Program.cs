using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            double n3 = double.Parse(Console.ReadLine());

            if (n3>n1 && n3<n2)
            {
                Console.WriteLine("Number " + n3 + " is between " + n1 + " and " + n2);
            } else
            {
                Console.WriteLine("Number " + n3 + " is not between " + n1 + " and " + n2);
            }

            Console.ReadKey();

        }
    }
}
