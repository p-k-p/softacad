using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLibrary
{
    public class Person
    {

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string FullName { get => this.FirstName + this.LastName; }
        
        public string EGN { get; set; }
        public TypeSex Sex;
        public PhoneNumber[] Phones { get; set; }
        public IdentityCard IDcard;
        public Address[] Addresses { get; set; }
        

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }



    }
}
