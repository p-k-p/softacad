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
            int i1, i2;
            Console.WriteLine("Enter integer number: ");
            i1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter integer number: ");
            i2 = int.Parse(Console.ReadLine());
            int add = i1 + i2;
            Console.WriteLine("Add = " + add);
            int sub = i1 - i2;
            Console.WriteLine("Sub = " + sub);
            int div = i1 / i2;
            Console.WriteLine("Div = " + div);
            int mul = i1 * i2;
            Console.WriteLine("Mul = " + mul);
            int mod = i1 % i2;
            Console.WriteLine("Mod = " + mod);

            Console.ReadKey();

            Console.WriteLine("Enter floating point number: ");
            float f1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter floating point number: ");
            float f2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Add = " + (f1 + f2));
            Console.WriteLine("Sub = " + (f1 - f2));
            Console.WriteLine("Div = " + (f1 / f2));
            Console.WriteLine("Mul = " + (f1 * f2));
            Console.WriteLine("Mod = " + (f1 % f2));

            Console.ReadLine();

        }
    }
}
