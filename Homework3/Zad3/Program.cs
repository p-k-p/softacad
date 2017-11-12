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
            int[] arr = new int[10];

            Console.WriteLine("Enter a number: ");
            arr[0] = arr[1] = int.Parse(Console.ReadLine());

            for (int i = 2; i < arr.Length; i++)
            {
                arr[i] = arr[i - 2] + arr[i - 1];
            }

            Console.Write("Array is:");

            foreach (int value in arr)
            {
                Console.Write(" " + value);
            }

            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
