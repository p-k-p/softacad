using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork14
{
    public class Person
    {

        public string FullName { get; set; }
        public BankAccount Account { get; set; }
        public GSM Phone { get; set; }

        public Person(string fullName, BankAccount account, GSM phone)
        {
            this.FullName = fullName;
            this.Account = account;
            this.Phone = phone;

            this.Account.OnBankAccountDebit += Account_OnBankAccountDebit;
        }

        private void Account_OnBankAccountDebit(decimal balance, decimal amount, bool success)
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
