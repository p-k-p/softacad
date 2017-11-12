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
            Console.WriteLine("Enter an hour :");
            int hour = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter amount of money :");
            double cash = double.Parse(Console.ReadLine());
            Console.WriteLine("Are you sick? :");
            bool sick = bool.Parse(Console.ReadLine());

            if (sick == true)
            {
                Console.WriteLine("I wont go out!");
            } else
            {
                Console.WriteLine("I am going for a walk!");
            }
            if (cash > 20)
            {
                Console.WriteLine("Cash is more than 20. Will buy meds !");
            } else
            {
                Console.WriteLine("Cash is less than 20. Will stay at home and have a tea!");
            }
            if (cash > 10)
            {
                if (hour < 10)
                {
                    Console.WriteLine("Going to a cinema!");
                } else
                {
                    Console.WriteLine("Going to a bar!");
                }
            }
        }
    }
}
