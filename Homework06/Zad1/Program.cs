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

            Computer Comp1 = new Computer();
            Computer Comp2 = new Computer();


            Comp1.year = 2013;
            Comp1.price = 1000;
            Comp1.isNotebook = false;
            Comp1.hardDiskMemory = 5000000;
            Comp1.freeMemory = 200000;
            Comp1.operatingSystem = "Windows 7";


            Comp2.year = 2015;
            Comp2.price = 2000;
            Comp2.isNotebook = true;
            Comp2.hardDiskMemory = 7500000;
            Comp2.freeMemory = 300000;
            Comp2.operatingSystem = "Linux";

            Comp1.UseMemory(100);
            Comp2.ChangeOperatingSystem("Ubuntu Linux");

            Computer Comp3 = new Computer(2000, 1500.50M, 5000, 3000);
            Computer FastComp = new Computer(2017, 3000M, true, 500000, 20000, "macOS");

            int compare = Comp3.ComparePrice(FastComp);

            if (compare == 2)
            {
                Console.WriteLine("FastComp is more expensive than Comp3.");
            } else if (compare == -1)
            {
                Console.WriteLine("FastComp is cheaper than Comp3.");
            } else
            {
                Console.WriteLine("FastComp is the same price as Comp3.");
            }

            //Console.WriteLine("Computer 1:");
            //Console.WriteLine("Year: " + Comp1.year);
            //Console.WriteLine("Price: " + Comp1.price);
            //Console.WriteLine("Computer is notebook: " + Comp1.isNotebook);
            //Console.WriteLine("Hard disk memory: " + Comp1.hardDiskMemory);
            //Console.WriteLine("Free memory: " + Comp1.freeMemory);
            //Console.WriteLine("Operating system: " + Comp1.operatingSystem);
            //Console.WriteLine();
            //Console.WriteLine("Computer 2:");
            //Console.WriteLine("Year: " + Comp2.year);
            //Console.WriteLine("Price: " + Comp2.price);
            //Console.WriteLine("Computer is notebook: " + Comp2.isNotebook);
            //Console.WriteLine("Hard disk memory: " + Comp2.hardDiskMemory);
            //Console.WriteLine("Free memory: " + Comp2.freeMemory);
            //Console.WriteLine("Operating system: " + Comp2.operatingSystem);

            Console.ReadKey();

        }
    }
}
