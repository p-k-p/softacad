using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork16
{
    public class BankAccount
    {


        public decimal Balance { get; set; }

        public string IBAN { get; set; }

        public BankAccount(decimal amount, string iban)
        {
            if (amount > 0)
            {
                this.Balance = amount;
            }

            this.IBAN = iban;
        }

        public void Debit(decimal amount)
        {
            if (amount <= this.Balance)
            {
                this.Balance -= amount;
                if (this.OnBankAccountDebit != null)
                {
                    this.OnBankAccountDebit(this.Balance, amount, this.IBAN, true);
                }
            } else
            {
                if (this.OnBankAccountDebit != null)
                {
                    this.OnBankAccountDebit(this.Balance, amount, this.IBAN, false);
                }
            }
        }

        public delegate void DebitEventHandler(decimal balance, decimal amount, string iban, bool success);

        public event DebitEventHandler OnBankAccountDebit;

    }
}