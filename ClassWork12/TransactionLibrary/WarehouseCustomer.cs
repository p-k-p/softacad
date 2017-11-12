using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionLibrary
{
    public class WarehouseCustomer : ICustomer
    {
        public string CustomerName { get; set; }
        public IAccount Account { get; set; }
        public IAccount Storage { get; set; }

        public WarehouseCustomer(string name, IAccount acc, decimal weight)
        {
            this.CustomerName = name;
            this.Account = acc;
            this.Storage.AccountBalance = weight;
            this.Storage.AccountNumber = acc.AccountNumber; 
        }
    }
}
