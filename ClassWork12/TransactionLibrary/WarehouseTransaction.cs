using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionLibrary
{
    public class WarehouseTransaction : Transaction
    {
        public decimal Weight { get; private set; }
        public new WarehouseCustomer Customer { get; set; }


        public WarehouseTransaction(WarehouseCustomer cust, TransactionType type, decimal weight) : base(cust, type, weight)
        {
            this.Weight = base.Amount;
            this.Customer = cust;

        }

        public override decimal CalculateFee()
        {
            if (this.Weight >= 1000M)
            {
                return 1.5M;
            }
            else if (this.Weight < 2000M)
            {
                return 2.0M;
            }
            else
            {
                return 1.1M;
            }
        }

        public override void ExecuteTransaction()
        {
            if ((this.Customer.Storage + this.Weight) > 5000M)
            {
                throw new TransactionException(this, "Storage quota EXCEEDED !!!");
            }


            if (this.type == TransactionType.Credit)
            {
                this.Customer.Storage += this.Weight;
                this.Customer.Account.AccountBalance -= this.CalculateFee();
            }
            else if (this.type == TransactionType.Debit)
            {
                this.Customer.Storage -= this.Weight;
                this.Customer.Account.AccountBalance -= this.CalculateFee();
            }

            
        }
    }
}
