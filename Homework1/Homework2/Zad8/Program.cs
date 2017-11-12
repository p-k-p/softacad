using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int n2 = int.Parse(Console.ReadLine());

            if (n1 < n2)
            {
                for (int i = n1; i <= n2; i++)
                {
                    Console.WriteLine(i);
                }
            } else
            {
                for (int i = n2; i <= n1; i++)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
