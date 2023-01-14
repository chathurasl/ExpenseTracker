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
        public Expense(int id, string transactionDescription, double amount, bool isRecurring, DateTime date, string otherNotes, int categoryId) : base(id, transactionDescription, amount, isRecurring, date, otherNotes, categoryId)
        {
        }

        public override string getType()
        {
            return transactionType;
        }

    }
}
