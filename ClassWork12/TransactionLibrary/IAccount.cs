using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionLibrary
{
    public interface IAccount
    {
        string AccountNumber { get;}
        decimal AccountBalance { get; set; }
    }
}
