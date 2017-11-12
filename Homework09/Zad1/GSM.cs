using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    public class GSM
    {

        public string Model { get; set; }
        public bool HasSimCard { get; set; }
        private string _simMobileNumber;
        public string SimMobileNumber
        {
            get
            {
                return this._simMobileNumber;
            }
            set
            {
                if (this.HasSimCard == true)
                {
                    this._simMobileNumber = value;
                }
            }
        }
        public double OutgoingCallsDuration { get; set; }
        public Call LastOutgoingCall { get; set; }
        public Call LastIncomingCall { get; set; }

        public GSM(string model)
        {
            this.Model = model;
        }

        public void InsertSimCard(string simMobileNumber)
        {
            if (simMobileNumber.Length == 10 && simMobileNumber.StartsWith("08"))
            {
                this.HasSimCard = true;
                this.SimMobileNumber = simMobileNumber;
            }
        }

        public void RemoveSimCard()
        {
            this.HasSimCard = false;
        }

        public void MakeCall(GSM receiver, double duration)
        {
            if (Call.IsDurationValid(duration))
            {
                if (this.SimMobileNumber != receiver.SimMobileNumber)
                {
                    if (this.HasSimCard && receiver.HasSimCard)
                    {
                        Call newcall = new Call(this, receiver, duration);
                        this.LastOutgoingCall = newcall;
                        receiver.LastIncomingCall = newcall;
                        this.OutgoingCallsDuration += duration;
                    }
                }
            }
        }

        public decimal SumForCalls
        {
            get
            {
                return decimal.Multiply(Convert.ToDecimal(this.OutgoingCallsDuration), Call.PricePerMinute);
            }
        }
    }
}
