using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public abstract class Transaction : IComparable<Transaction>
    {

        private int id;
        private double amount;
        private bool isRecurring;
        private DateTime date;
        private string transactionDescription;
        private string otherNotes;
        private int categoryId;


        //Constractor
        public Transaction(int id, string transactionDescription, double amount, bool isRecurring, DateTime date, string otherNotes, int categoryId)
        {
            this.id = id;
            this.transactionDescription = transactionDescription;
            this.amount = amount;
            this.isRecurring = isRecurring;
            this.date = date;
            this.otherNotes = otherNotes;
            this.categoryId = categoryId;
        }


        //Set transaction recurrence
        public void setRecurrence(bool isRecurring)
        {
            this.isRecurring = isRecurring;
        }

        //Get ID
        public int getId()
        {
            return this.id;
        }   
        
        //Get Amount
        public double getAmount()
        {
            return this.amount;
        }


        //Get Recurrence 
        public bool getRecurrence()
        {
            return this.isRecurring;
        }   
        
        //Get Date
        public string getDate()
        {
            return this.date.ToShortDateString();
        }


        //Get Description
        public string getDescription()
        {
            return this.transactionDescription;
        }

        //Get Notes
        public string getNotes()
        {
            return this.otherNotes;
        }

        //Get category Id
        public int getCategoryId()
        {
            return this.categoryId;
        }

        //Abstract function to be implemented by the child classes of the transaction parent
        public abstract string getType();

        //This function is used to sort the Transactions Overriding the IComparable Interface
        public int CompareTo(Transaction compareTransaction) {

            if (compareTransaction == null)
                return 1;

            else
                return this.date.CompareTo(DateTime.Parse(compareTransaction.getDate()));
        }

    }
}
