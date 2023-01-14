using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    //category Class
    public class Category
    {

        private int categoryId;
        private string categoryName;
        private double budgetAmount;
        private static int CID = 1000;

        //Constractor
        public Category(string categoryName, double budgetAmount)
        {
            this.categoryId = CID++;
            this.categoryName = categoryName;
            this.budgetAmount = budgetAmount;

            categoryId++;

        }

        //Update category name
        public void changeName(string name)
        {
            this.categoryName = name;
        }
           
        
        //Update category budget
        public void changeBudget(double amount)
        {
            this.budgetAmount = amount;
        }

        //Get category name
        public string getCategoryName()
        {
            return this.categoryName;
        }

         //Get category ID
        public int getId()
        {
            return this.categoryId;
        }        
        
        //Get category budget
        public double getBudget()
        {
            return this.budgetAmount;
        }

    }


}
