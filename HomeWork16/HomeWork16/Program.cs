using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork16
{
    class Program
    {
        static void Main(string[] args)
        {

            Person human1 = new Person("Pesho1", new GSM("088913313"));
            Person human2 = new Person("Pesho2", new GSM("098193383"));
            Person human3 = new Person("Pesho3", new GSM("0919392932"));

            human1.AddBankAccount(new BankAccount(1999m, "BGPB020202"));
            human1.AddBankAccount(new BankAccount(200m, "BGUN02030230"));
            human2.AddBankAccount(new BankAccount(200m, "BGUN03333230"));
            human3.AddBankAccount(new BankAccount(200m, "BGUN05555230"));

            MobileCompany mtel = new MobileCompany(new Person[5] { human1, human2, human3, null, null });

            mtel.MonthlyCharge(5m, "BGUN03333230", "Pesho2");

            Console.ReadKey();

        }
    }
}
