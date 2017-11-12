using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = -10; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                } else
                {
                    Console.WriteLine(i);
                }
                
            }
            Console.ReadKey();
        }
    
    }
}
