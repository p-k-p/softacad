using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork16
{
    public class Person
    {

        public string FullName { get; set; }
        public List<BankAccount> Accounts { get; set; }
        public GSM Phone { get; set; }

        public Person(string fullName, GSM phone)
        {
            this.FullName = fullName;
            this.Phone = phone;

            //this.Account.OnBankAccountDebit += Account_OnBankAccountDebit;
        }

        public void AddBankAccount(BankAccount bankAccount)
        {
            if (bankAccount != null)
            {
                this.Accounts.Add(bankAccount);

                this.Accounts.Last().OnBankAccountDebit += Account_OnBankAccountDebit;
            }
        }

        private void Account_OnBankAccountDebit(decimal balance, decimal amount, string iban, bool success)
        {
            if (success == true)
            {
                this.Phone.SendMessage(this.FullName + " Successful debit from Bank Account: " + amount + "$. " + "Balance remaining: " + balance + "$");
            } else if (success == false)
            {
                this.Phone.SendMessage(this.FullName + " Unsuccessful debit from Bank Account: " + amount + "$. " + "Balance remaining: " + balance + "$");
            }
        }
    }
}
