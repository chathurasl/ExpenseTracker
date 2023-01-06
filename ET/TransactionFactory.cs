using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public interface TransactionFactory
    {

        //Create Transaction method
        public bool createTransaction(Transaction t);

        //Edit Transaction method
        public bool editTransaction(Transaction t);

        //Delete Transaction method
        public bool deleteTransaction(int id);

    }
}
