using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int n1 = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n1; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("Sum of all numbers from 1 to " + n1 + " is : " + sum);
            Console.ReadKey();
        }
    }
}
