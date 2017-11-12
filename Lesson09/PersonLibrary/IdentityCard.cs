using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLibrary
{
    public class IdentityCard
    {
        public string Number { get; set; }
        public DateTime ValidityDate { get; set; }
        
        public IdentityCard(string number, DateTime valid)
        {
            this.Number = number;
            this.ValidityDate = valid;
        }
    }
}
