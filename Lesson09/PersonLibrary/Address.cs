using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLibrary
{
    public class Address
    {

        public string Country { get; set; }
        public string City { get; set; }
        public string AddressLine { get; set; }
        public TypeAddress Type { get; set; }


        public Address(TypeAddress type, string country, string city, string address)
        {
            this.Type = type;
            this.Country = country;
            this.City = city;
            this.AddressLine = address;
        }
    }
}
