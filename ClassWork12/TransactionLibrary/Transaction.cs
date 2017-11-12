using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionLibrary
{
    public abstract class Transaction
    {
        public ICustomer Customer { get; private set; }
        public TransactionType type { get; private set; }
        public decimal Amount { get; private set; }

        public Transaction(ICustomer cust, TransactionType type, decimal sum)
        {
            this.Customer = cust;
            this.type = type;
            this.Amount = sum;
        }

        public abstract decimal CalculateFee();
        public virtual void ExecuteTransaction()
        {
            if (this.type == TransactionType.Credit)
            {
                this.Customer.Account.AccountBalance += this.Amount;
            }
            else if (this.type == TransactionType.Debit)
            {
                this.Customer.Account.AccountBalance -= this.Amount;
                this.Customer.Account.AccountBalance -= this.CalculateFee();
            }
        }

      
    }

    public class TransactionException : Exception
    {
        private Transaction _tran;
        public TransactionException(Transaction transaction, string message) : base(message)
        {
            this._tran = transaction;
        }
    }
}
