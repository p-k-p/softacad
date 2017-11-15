using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork14
{
    public class GSM
    {

        public string Number { get; set; }

        public GSM(string number)
        {
            this.Number = number;
        }

        public void SendMessage(string message)
        {
            Console.WriteLine(message);
        }

    }
}
