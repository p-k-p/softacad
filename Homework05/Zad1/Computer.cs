using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    public class Computer
    {

        public ushort year;
        public decimal price;
        public bool isNotebook;
        public double hardDiskMemory;
        public double freeMemory;
        public string operatingSystem;

        public void ChangeOperatingSystem(string newOperatingSystem)
        {
            operatingSystem = newOperatingSystem;
        }

        public void UseMemory(double memory)
        {
            if (memory > freeMemory)
            {
                Console.WriteLine("Not enough free memory!");
            } else
            {
                freeMemory = freeMemory - memory;
            }
        }

    }
}
