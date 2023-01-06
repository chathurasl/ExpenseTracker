using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{

    //Income subclass of Transaction
    public class Income : Transaction
    {
        private string transactionType = "Income";

        //Constractor
        public Income(int id, double amount, bool isRecurring, DateTime date, string transactionDescription, int categroyId) : base(id, amount, isRecurring, date, transactionDescription, categroyId)
        {
        }

        public override string getType()
        {
            return transactionType;
        }
    

    }
}
