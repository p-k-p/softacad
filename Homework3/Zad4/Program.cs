using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size: ");
            int[] arr = new int[int.Parse(Console.ReadLine())];

            Console.WriteLine("Enter array elements: ");
            for (int i = 0; i < arr.Length; i++)
            {

                arr[i] = int.Parse(Console.ReadLine());

            }

            Console.Write("Array is:");

            foreach (int value in arr)
            {
                Console.Write(" " + value);
            }

            Console.WriteLine();

            bool mirror = true;
                        
            for (int i = 0; i < arr.Length / 2; i++)
            {
                mirror = arr[i] == arr[arr.Length - (i+1)];             
            }

            if (mirror == true)
            {
                Console.WriteLine("Array is mirrored.");
            } else
            {
                Console.WriteLine("Array is not mirrored.");
            }

            Console.ReadKey();
        }
    }
}
