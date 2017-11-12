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
            Console.WriteLine("Enter random string: ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter another random string: ");
            string str2 = Console.ReadLine();
            Console.WriteLine("You entered: " + str1 + str2);
            Console.ReadKey();

        }
    }
}
