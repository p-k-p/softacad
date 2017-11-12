using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    public class Student:Person
    {
        private double _score;
        public double Score
        {
            get { return this._score; }
            set
            {
                if (value > 2 && value < 6)
                {
                    this._score = value;
                }
                else
                {
                    Console.WriteLine("Invalid score!");
                }
            }
            
        }

        public Student():base("Default Student", 1, true)
        {
            this.Score = 2;
        }

        public Student(string name, int age, bool isMale, double score):base(name, age, isMale)
        {

            this.Score = score;

        }

        public void ShowStudentInfo()
        {
            base.ShowPersonInfo();
            Console.WriteLine("Score: " + this.Score);
            Console.WriteLine();
        }

    }
}
