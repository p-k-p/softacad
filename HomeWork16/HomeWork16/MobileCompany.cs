using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork16
{
    public class MobileCompany
    {

        private Person[] _clients;

        public MobileCompany(Person[] clients)
        {
            this._clients = clients;
        }

        public void MonthlyCharge(decimal fee, string iban, string name)
        {

            for (int i = 0; i < this._clients.Length; i++)
            {
                if (this._clients[i] != null && this._clients[i].FullName == name)
                {
                    foreach (BankAccount account in this._clients[i].Accounts)
                    {
                        if (account.IBAN == iban)
                        {
                            account.Debit(fee);
                        }
                    }
                }
            }
        }

    }
}
