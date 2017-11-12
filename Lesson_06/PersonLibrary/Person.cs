using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLibrary
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        private static int coef;

        public int Coef { get => coef; set => coef = value; }

        //public Person()
        //{

        //}

        public Person(int a)
        {
            Coef = a;
        }

        public string GetFullName()
        {
            return (FirstName + " " + LastName);
        }

        public string Walk(int kilometers,string destFrom,string destTo)
        {
            return (GetFullName() + " is walking each day " + kilometers + " from " + destFrom + " to " + destTo);
        }
    }
}
