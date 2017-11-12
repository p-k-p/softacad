using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    public class Call
    {
        public static decimal PricePerMinute { get; set; }
        public GSM Caller { get;private set; }
        public GSM Receiver { get;private set; }
        public static bool IsDurationValid(double duration)
        {
            if (duration >= 0 && duration <= 120)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private double _duration;
        public double Duration
        {
            get
            {
                return this._duration;
            }

            set
            {
                if (Call.IsDurationValid(value))
                {
                    this._duration = value;
                }
            }
        }

        public Call(GSM caller, GSM receiver, double duration)
        {
            this.Caller = caller;
            this.Receiver = receiver;
            this.Duration = duration;
        }



    }
}
