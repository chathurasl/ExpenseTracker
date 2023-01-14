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
        public Income(int id, string transactionDescription, double amount, bool isRecurring, DateTime date, string otherNotes, int categoryId) : base(id, transactionDescription, amount, isRecurring, date, otherNotes, categoryId)
        {
        }

        public override string getType()
        {
            return transactionType;
        }
    

    }
}
