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
            int[] arr = new int[5];
            int smallest = 0;

            for (int arrIndex = 0; arrIndex < arr.Length; arrIndex++)
            {
                Console.WriteLine("Enter a number: ");
                arr[arrIndex] = int.Parse(Console.ReadLine());

                if (arr[arrIndex] % 3 == 0)
                {
                    if (arr[arrIndex] < smallest || smallest == 0)
                    {
                        smallest = arr[arrIndex];
                    }
                }
            }

            if (smallest == 0)
            {
                Console.WriteLine("No multiple of 3 entered in the array!");
            }
            else
            {
                Console.WriteLine("Smallest multiple of 3 in array is: " + smallest);
            }
            Console.ReadKey();
        }
    }
}
