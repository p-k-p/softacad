using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionLibrary
{
    public interface ICustomer
    {
        string CustomerName { get; }
        IAccount Account { get; }
    }
}
