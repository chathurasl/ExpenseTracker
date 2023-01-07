using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public abstract class Transaction
    {

        private int id;
        private double amount;
        private bool isRecurring;
        private DateTime date;
        //private string transactionType;
        private string transactionDescription;
        private string otherNotes;
        private int categroyId;


        //Constractor
        public Transaction(int id, string transactionDescription, double amount, bool isRecurring, DateTime date, string otherNotes, int categroyId)
        {
            this.id = id;
            this.transactionDescription = transactionDescription;
            this.amount = amount;
            this.isRecurring = isRecurring;
            this.date = date;
            this.otherNotes = otherNotes;
            this.categroyId = categroyId;
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

        //Get Categroy Id
        public int getCategroyId()
        {
            return this.categroyId;
        }

        public abstract string getType();

    }
}
