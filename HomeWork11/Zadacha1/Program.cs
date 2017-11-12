using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankInterfaceLibrary;
using BankClassLibrary;

namespace Zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {

            ICustomer customer1 = new Customer("Ivan Petrov", new BankAccount("BGSOF02020202", 200M, "Unicredit"));

            BankTransaction transaction1 = new BankTransaction(new Bank("Unicredit"), customer1, TransactionType.Credit, 300m);

            transaction1.ExecuteTransaction();

            Console.WriteLine(customer1.Account.Balance);
            Console.ReadKey();

        }
    }
}
