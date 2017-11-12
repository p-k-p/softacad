using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            int n3 = int.Parse(Console.ReadLine());

            Console.Write("Numbers are :");

            if (n1 > n2 && n1 > n3)
            {
                Console.Write(" " + n1);
                if (n2 > n3)
                {
                    Console.Write(" " + n2 + " " + n3 +".");
                } else
                {
                    Console.Write(" " + n3 + " " + n2 + ".");
                }
            }
            else if (n2 > n1 && n2 > n3)
            {
                Console.Write(" " + n2);
                if (n1 > n3)
                {
                    Console.Write(" " + n1 + " " + n3 + ".");
                }
                else
                {
                    Console.Write(" " + n3 + " " + n1 + ".");
                }
            }
            else 
            {
                Console.Write(" " + n3);
                if (n2 > n1)
                {
                    Console.Write(" " + n2 + " " + n1 + ".");
                }
                else
                {
                    Console.Write(" " + n1 + " " + n2 + ".");
                }
            }
            
            Console.ReadKey();
        }
    }
}
