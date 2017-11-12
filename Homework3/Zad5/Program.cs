using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size: ");
            int[] arr1 = new int[int.Parse(Console.ReadLine())];

            int[] arr2 = new int[arr1.Length];

            Console.WriteLine("Enter array elements: ");
            for (int i = 0; i < arr1.Length; i++)
            {

                arr1[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < arr2.Length - 1; i++)
            {

                arr2[i] = arr1[i + 1];
                
            }

            for (int i = arr2.Length - 1; i > 0; i--)
            {

                arr2[i] += arr1[i - 1];

            }

            Console.Write("Array is: {");

            foreach (int value in arr2)
            {
                Console.Write(" " + value);
            }

            Console.Write(" }");

            Console.WriteLine();
            Console.ReadKey();


        }
    }
}
