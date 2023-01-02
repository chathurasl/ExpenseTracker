using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    //Categroy Class
    public class Category
    {

        private int categoryId;
        private string categroyName;
        private double budgetAmount;
        private static int CID = 1000;

        //Constractor
        public Category(string categroyName, double budgetAmount)
        {
            this.categoryId = CID++;
            this.categroyName = categroyName;
            this.budgetAmount = budgetAmount;

            categoryId++;

        }

        //Update category name
        public void changeName(string name)
        {
            this.categroyName = name;
        }
           
        
        //Update category budget
        public void changeBudget(double amount)
        {
            this.budgetAmount = amount;
        }

        //Get categroy name
        public string getCategoryName()
        {
            return this.categroyName;
        }

         //Get categroy ID
        public int getId()
        {
            return this.categoryId;
        }        
        
        //Get categroy budget
        public double getBudget()
        {
            return this.budgetAmount;
        }

    }


}
