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

        //Get Transaction()
        public Transaction getTransaction();

        //Edit Transaction method
        public void editTransaction(Transaction t);

        //Delete Transaction method
        public void deleteTransaction(Transaction t);

    }
}
