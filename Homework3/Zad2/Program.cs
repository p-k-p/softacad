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
            int[] arr;
            int size = 0;

            do
            {
                Console.WriteLine("Enter an array size which is multiple of 2: ");
                size = int.Parse(Console.ReadLine());

            } while (size % 2 != 0);

            arr = new int[size];

            Console.WriteLine("Enter the first " + (size / 2) + " elements of the array: ");

            for (int i = 0; i < (arr.Length / 2); i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                arr[i + (arr.Length / 2)] = arr[i];
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
