using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLibrary
{
    public class Task
    {
        public string Name { get; set; }
        private int _hours;
        public int Hours {
            get
            {
                return this._hours;
            }
            set
            {
                if (value < 0) { this.Hours = 0; }
            }
        }

        public Task(string name, int hours)
        {
            this.Hours = hours;
            this.Name = name;
        }
    }
}
