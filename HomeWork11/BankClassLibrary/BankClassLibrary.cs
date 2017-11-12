using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankInterfaceLibrary;


namespace BankClassLibrary
{
   
        public class Customer : ICustomer
        {
            public string ClientName { get; set; }
            public IBankAccount Account { get; set; }
            
            public Customer(string client, IBankAccount acc)
            {
                this.ClientName = client;
                this.Account = acc;
            }
        }
               
        public class Bank : IBank
        {
            public string BankName { get; set; }
            public Bank(string name)
            {
            this.BankName = name;
            }
        }

        public class BankAccount : IBankAccount
        {
            public string IBAN { get; set; }
            public decimal Balance { get; set; }
            public string BankName { get; set; }

            public BankAccount (string iban, decimal balance, string name)
            {
            this.IBAN = iban;
            this.Balance = balance;
            this.BankName = name;

            }
         

        }

        public class BankTransaction : Transaction
        {
            public Bank TBank;

            public BankTransaction(Bank bank, ICustomer customer, TransactionType type, decimal sum)
            :base(customer, type, sum)
            {
                this.TBank = bank;
            }

            public override decimal CalculateFee()
            {
                if (this.TBank.BankName == base.Customer.Account.BankName)
                {
                    return 0;
                } else
                {
                    return 1.5M;
                }
            }
        }
    }

