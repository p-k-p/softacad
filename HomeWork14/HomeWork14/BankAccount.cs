using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork14
{
    public class BankAccount
    {


        public decimal Balance { get; set; }

        public BankAccount(decimal amount)
        {
            if (amount > 0)
            {
                this.Balance = amount;
            }
        }

        public void Debit(decimal amount)
        {
            if (amount <= this.Balance)
            {
                this.Balance -= amount;
                if (this.OnBankAccountDebit != null)
                {
                    this.OnBankAccountDebit(this.Balance, amount, true);
                }
            } else
            {
                if (this.OnBankAccountDebit != null)
                {
                    this.OnBankAccountDebit(this.Balance, amount, false);
                }
            }
        }

        public delegate void DebitEventHandler(decimal balance, decimal amount, bool success);

        public event DebitEventHandler OnBankAccountDebit;

    }
}