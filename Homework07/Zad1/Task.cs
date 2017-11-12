using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    public class Task
    {
        private string _name;
        private int _workingHours;

        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        public int WorkingHours
        {
            get { return this._workingHours; }
            set {
                if (value < 0)
                {
                    this._workingHours = 0;
                }
                else
                {
                    _workingHours = value;
                }
            }
        }

        public Task():this("Default Task", 1)
        {
           
        }

        public Task(string name, int workHours)
        {
            this.Name = name;
            this.WorkingHours = workHours;
        }
    }
}
