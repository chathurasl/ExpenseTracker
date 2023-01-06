using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    //Expense subclass of Transaction
    public class Expense : Transaction
    {

        private string transactionType = "Expense";

        //Constractor
        public Expense(int id, double amount, bool isRecurring, DateTime date, string transactionDescription, int categroyId) : base(id, amount, isRecurring, date, transactionDescription, categroyId)
        {
        }

        public override string getType()
        {
            return transactionType;
        }

    }
}
