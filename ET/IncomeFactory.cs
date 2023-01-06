using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class IncomeFactory:TransactionFactory
    {

        private List<Transaction> currentTransactions = new List<Transaction>();


        public IncomeFactory(List<Transaction>  currentTransactions)
        {

            this.currentTransactions = currentTransactions;
        }


        //Create Transaction method
        public bool createTransaction(Transaction t)
        {

     
            //Adding new Transaction to Current Transaction list
            currentTransactions.Add(t);
            MessageBox.Show("Category sucessfully added to the list.");
            return true;

        }

        //Get Transaction()
        public Transaction getTransaction() {
        
            return null;
        }


        //Edit Transaction method
        public void editTransaction(Transaction t)
        {

        }

        //Delete Transaction method
        public void deleteTransaction(Transaction t)
        {

        }
    }
}
