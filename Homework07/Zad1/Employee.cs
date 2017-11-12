using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    public class Employee
    {
        private string _name;
        public Task currentTask;
        private int _hoursLeft;

        public string Name
        {
            get { return _name; }
            set
            {
                if (value == "")
                {
                    this._name = "Default Name";
                } else
                {
                    this._name = value;
                }
            }
        }

        public int HoursLeft
        {
            get { return this._hoursLeft; }
            set
            {
                if (value < 0)
                {
                    this._hoursLeft = 0;
                } else
                {
                    this._hoursLeft = value;
                }
            }
        }

        public void Work()
        {


            if (this.currentTask != null)
            {
                this.currentTask.WorkingHours -= this.HoursLeft;
                t
            }
        }
    }
}
