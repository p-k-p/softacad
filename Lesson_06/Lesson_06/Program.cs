using PersonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Person manager = new Person(5);
            Console.WriteLine(manager.Coef);
            Person boss = new Person(50);
            //manager.FirstName = "Ivan";
            //manager.LastName = "Petrov";
            Console.WriteLine(boss.Coef);
            Console.WriteLine(manager.Coef);
            //manager.GetFullName();
            //Console.WriteLine(manager.Walk(15, "Sofia", "Plovdiv"));
            Console.ReadKey();
            
        }
    }
}
