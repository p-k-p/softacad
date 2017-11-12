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
            int[] a = { 7, 8, 9, 0, 88, 18 };

            int[] b = { 3, 4, 5, 6, 0, 8, 9, 10, 15 };

            int[] c = Arrays.DivideArrays(a, b);

            Console.WriteLine("First Array is :");
            Arrays.PrintArray(a);
            Console.WriteLine("Second Array is :");
            Arrays.PrintArray(b);
            Console.WriteLine("Result Array is :");
            Arrays.PrintArray(c);

            Console.ReadKey();
        }
    }
}
