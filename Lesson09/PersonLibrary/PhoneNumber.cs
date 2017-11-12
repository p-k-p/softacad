using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLibrary
{
    public class PhoneNumber
    {
        public TypePhoneNumber Type { get; private set; }
        public string Notes { get; set; }
        public string Number { get; private set; }

        public PhoneNumber(string number, TypePhoneNumber type)
        {
            this.Number = number;
            this.Type = type;
        }
            
            

    }
}
