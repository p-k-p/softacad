using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    public static class Arrays
    {

        public static int[] DivideArrays(int[] mas1 , int[] mas2)
        {
            int[] resultArray;

            if (mas1.Length > mas2.Length)
            {

                resultArray = new int[mas1.Length];

            } else
            {

                resultArray = new int[mas2.Length];

            }

            for (int i = 0; i < resultArray.Length; i++)
            {
                try
                {
                    resultArray[i] = mas1[i] / mas2[i];
                }  
                catch (DivideByZeroException)
                {
                    resultArray[i] = 0;
                }
                catch (IndexOutOfRangeException)
                {
                    resultArray[i] = -1;
                }
            }

            return resultArray;


        }

        public static void PrintArray (int[] array)
        {
            Console.Write("[ ");
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                Console.Write(" ");
            }
            Console.Write("]\n");
        }

    }
}
