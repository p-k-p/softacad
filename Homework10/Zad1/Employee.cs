using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    public class Employee:Person
    {
        private decimal _dailySalary;
        public decimal DailySalary
        {
            get
            {
                return _dailySalary;
            }
            set
            {
                if (value > 0)
                {
                    this._dailySalary = value;
                }
            }
        }

        public Employee(string name, int age, bool isMale, decimal salary):base(name,age,isMale)
        {

            this.DailySalary = salary;

        }

        public decimal CalculateOvertime(double hours)
        {
            if (this.Age < 18)
            {
                return 0;
            }
            else
            {
                return Convert.ToDecimal(hours) * ((this.DailySalary / 8) * 1.5M);
            }
        }

        public void ShowEmployeeInfo()
        {
            base.ShowPersonInfo();
            Console.WriteLine("Daily salary: " + this.DailySalary);
            Console.WriteLine();
        }

    }
}
