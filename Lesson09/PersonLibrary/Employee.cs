using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLibrary
{
    public class Employee
    {
        public Person Worker { get; private set; }
        public int Hours { get; private set; }

        public Employee(Person person, int workhours)
        {
            this.Worker = person;
            this.Hours = workhours;
        }

        public Task CurrentTask { get; set; }

        public void Work()
        {
            if (CurrentTask != null && CurrentTask.Hours != 0)
            {
                CurrentTask.Hours = CurrentTask.Hours - this.Hours;
            }
        }
    }
}
