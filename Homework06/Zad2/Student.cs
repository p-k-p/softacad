using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    public class Student
    {
        public string name;
        public string subject;
        private double grade;
        private int yearInCollege;
        public int age;
        public bool hasDegree;
        public decimal money;

        public int YearInCollege { get => yearInCollege; set => yearInCollege = value; }
        public double Grade { get => grade; set => grade = value; }

        public Student()
        {
            Grade = 4.0;
            YearInCollege = 1;
            hasDegree = false;
            money = 0M;
        }

        public Student(string name, string subject, int age) : this()
        {
            this.name = name;
            this.subject = subject;
            this.age = age;
        }

        public void UpYear()
        {
            if (hasDegree == false)
            {
                this.YearInCollege++;
                if (this.YearInCollege == 4)
                {
                    hasDegree = true;
                    return;
                }
            } else
            {
                Console.WriteLine("The Student already has a degree!");
                return;
            }
                    
        }

        public decimal ReceiveScholarship(double min, decimal amount)
        {
            if (this.Grade >= min && this.age < 30)
            {
              return this.money += amount;
            } else
            {
                return this.money;
            }
        }
    }
}
