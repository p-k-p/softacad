using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int n2 = int.Parse(Console.ReadLine());
            int power;
            int sum = 0;
            Console.Write("Result: ");

            for (int i = n1; i <= n2; i++)
            {
                power = i * i;
                if (power % 3 == 0)
                {
                    Console.Write("Skip " + power);
                }
                else
                {
                    Console.Write(power);
                    sum += power;
                }

                if (sum > 200)
                {
                    break;
                }
                else
                {
                    Console.Write(",");
                }

            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
