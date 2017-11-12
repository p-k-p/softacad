using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    public class Person
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            private set
            {
                if (value != string.Empty)
                {
                    _name = value;
                }
            }

        }
        private int _age;
        public int Age
        {
            get
            {
                return this._age;
            }
            private set
            {
                if (value > 0)
                {
                    this._age = value;
                }
            }
        }
        public bool IsMale { get; set; }

        public Person(string name, int age, bool male)
        {
            this.Name = name;
            this.Age = age;
            this.IsMale = male;
        }

        public void ShowPersonInfo()
        {
            //Console.WriteLine("Personal info :");
            Console.WriteLine();
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine("Age: " + this.Age);
            Console.Write("Sex: ");
            if (IsMale)
                Console.Write("Male\n");
            else Console.Write("Female\n");
        }
    }
}
