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
            int n;
            int m;
            Console.WriteLine("Enter matrix dimensions NxM : ");
            Console.WriteLine("Enter N: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter M: ");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Matrix is : " + n + "x" + m);

            int[,] matrix = new int[n, m];

            int count = 1;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[j,i] = count;
                    count++;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i,j] + " ");
                                       
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
