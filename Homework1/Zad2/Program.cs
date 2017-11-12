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
            int i1, i2;
            Console.WriteLine("Enter positive integer number: ");
            i1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter negative integer number: ");
            i2 = int.Parse(Console.ReadLine());

            int add = i1 + i2;
            Console.WriteLine("Add = " + add);
            int sub = i1 - i2;
            Console.WriteLine("Sub = " + sub);
            int mul = i1 * i2;
            Console.WriteLine("Mul = " + mul);
            Console.ReadKey();
        }
    }
}
