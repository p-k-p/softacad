using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection = 0;


            do
            {
                Console.WriteLine("Select choice: ");
                Console.WriteLine("1 = Sort array.");
                Console.WriteLine("2 = Clear screen.");
                Console.WriteLine("3 = Exit.");
                selection = int.Parse(Console.ReadLine());

                if (selection == 1)
                {
                    Console.WriteLine("Enter array size: ");
                    int[] array = new int[int.Parse(Console.ReadLine())];

                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.WriteLine("Enter array element " + (i+1) + ": ");
                        array[i] = int.Parse(Console.ReadLine());
                    }

                    Console.Write("Array entered is:");
                    foreach (int value in array)
                    {
                        Console.Write(" " + value);
                    }
                    Console.WriteLine();

                    int tmp;

                    for (int i = 0; i < array.Length; i++)
                    {
                        for (int g = i + 1; g < array.Length; g++)
                        {
                            if (array[g] < array[i])
                            {
                                tmp = array[i];
                                array[i] = array[g];
                                array[g] = tmp;
                            }
                        }

                    }

                    Console.Write("Sorted array is:");
                    foreach (int value in array)
                    {
                        Console.Write(" " + value);
                    }
                    Console.WriteLine();


                }
                else if (selection == 2)
                {
                    Console.Clear();
                }
                else
                {
                    continue;
                }


            } while (selection != 3);


        }
    }
}
