using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    public class Computer
    {

        public int year;
        public decimal price;
        public bool isNotebook;
        public double hardDiskMemory;
        public double freeMemory;
        public string operatingSystem;

        public Computer()
        {
            this.isNotebook = false;
            this.operatingSystem = "Win 8.1";
        }

        public Computer(int year, decimal price, double hddMem, double freeMem) : this()
        {
            this.year = year;
            this.price = price;
            this.hardDiskMemory = hddMem;
            this.freeMemory = freeMem;
        }

        public Computer(int year, 
                        decimal price,
                        bool isNotebook,
                        double hddMem,
                        double freeMem,
                        string opSystem)
        {
            this.year = year;
            this.price = price;
            this.isNotebook = isNotebook;
            this.hardDiskMemory = hddMem;
            this.freeMemory = freeMem;
            this.operatingSystem = opSystem;
        }

        public int ComparePrice(Computer c)
        {
            if (this.price > c.price)
            {
                return -1;
            } else if (this.price < c.price)
            {
                return 2;
            } else
            {
                return 0;
            }

        }

        public void ChangeOperatingSystem(string newOperatingSystem)
        {
            operatingSystem = newOperatingSystem;
        }

        public void UseMemory(double memory)
        {
            if (memory > freeMemory)
            {
                Console.WriteLine("Not enough free memory!");
            }
            else
            {
                freeMemory = freeMemory - memory;
            }
        }

    }
}
