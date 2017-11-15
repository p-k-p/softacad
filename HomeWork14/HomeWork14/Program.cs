using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork14
{
    class Program
    {
        static void Main(string[] args)
        {

            Person human1 = new Person("Pesho1", new BankAccount(1m), new GSM("088913313"));
            Person human2 = new Person("Pesho2", new BankAccount(1000m), new GSM("098193383"));
            Person human3 = new Person("Pesho3", new BankAccount(299m), new GSM("0919392932"));

            MobileCompany mtel = new MobileCompany(new Person[5] { human1, human2, human3, null, null });

            mtel.MonthlyCharge(5m);

            Console.ReadKey();

        }
    }
}
