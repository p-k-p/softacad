using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankInterfaceLibrary
{
    public interface IBank
    {
        string BankName { get; set; }
    }

    public interface IBankAccount : IBank
    {
        string IBAN { get; set; }
        decimal Balance { get; set; }
    }

    public interface ICustomer
    {
        string ClientName { get; set; }
        IBankAccount Account { get; set; }
    }

    public abstract class Transaction
    {
        public ICustomer Customer { get; private set; }
        public TransactionType Type { get; private set; }
        public decimal Sum { get; private set; }

        public Transaction(ICustomer cust, TransactionType type, decimal sum)
        {
            this.Customer = cust;
            this.Type = type;
            this.Sum = sum;
        }

        public abstract decimal CalculateFee();
        public void ExecuteTransaction()
        {
            if (this.Type == TransactionType.Credit)
            {
                this.Customer.Account.Balance += this.Sum;
            }
            else if (this.Type == TransactionType.Debit)
            {
                this.Customer.Account.Balance -= this.Sum;
                this.Customer.Account.Balance -= this.CalculateFee();
            }
        }
    }
}
