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
        private int categroyId;


        //Constractor
        public Transaction(int id, double amount, bool isRecurring, DateTime date, string transactionDescription, int categroyId)
        {
            this.id = id;
            this.amount = amount;
            this.isRecurring = isRecurring;
            this.date = date;
            //this.transactionType = transactionType;
            this.transactionDescription = transactionDescription;
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
        public DateTime getDate()
        {
            return this.date;
        }


        //Get Description
        public string getDescription()
        {
            return this.transactionDescription;
        }

        //Get Categroy Id
        public int getCategroyId()
        {
            return this.categroyId;
        }

    }
}
