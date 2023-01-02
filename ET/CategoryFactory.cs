using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class CategoryFactory
    {
        //private Dictionary<int, Category> currentCategories = new Dictionary<int, Category>();
        private List<Category> currentCategories = new List<Category>();

        public CategoryFactory()
        {

            //Predefined categories
            currentCategories.Add(new Category("Salary", 100000));
            currentCategories.Add(new Category("Cloths", 20000));
            currentCategories.Add(new Category("Fuel", 10000));
            currentCategories.Add(new Category("Shopping", 30000));
            currentCategories.Add(new Category("Foods", 20000));
        }

        //Get Categories method
        public List<Category> getCategories()
        {
            return currentCategories;
        }

        //Add New Category method
        public bool addCategory(String name, double budget)
        {

            bool newCategory = true; //set flag
            bool rtn = false;

            //Loop Category Dictionary
            foreach (Category currCat in currentCategories)
            {

                //Check if given name is already exist in the category list
                if (name == currCat.getCategoryName())
                {
                    newCategory = false;
                    MessageBox.Show("Sorry, please check the category name, provided name already exist in the system.");
                    break;
                }
            }

            //Adding new attraction to Current attractions dictionary
            if (newCategory)
            {
                currentCategories.Add(new Category( name, budget));

                MessageBox.Show("Category sucessfully added to the list.");
                rtn = true;
            }

            return rtn;

        }     
        
        
        //Update Category method
        public bool updateCategory(int id, String name, double budget)
        {

            bool found = false; //set flag
            bool rtn = false;

            //Loop Category Dictionary
            foreach (Category currCat in currentCategories)
            {

                //Check if given id is exist in the category list
                if (id == currCat.getId())
                {
                    found = true;
                    rtn = true;

                    currCat.changeName(name);
                    currCat.changeBudget(budget);

                    MessageBox.Show("Category data successfully updated.");
                    break;
                }
            }

            //If not exist, show error message
            if (!found)
            {
                MessageBox.Show("Sorry, this category is not in the system, please try again.");
            }

            return rtn;

        } 
        
        
        //Dwlete Category method
        public bool deleteCategory(int id)
        {

            bool found = false; //set flag
            bool rtn = false;

            //Loop Category Dictionary
            foreach (Category currCat in currentCategories)
            {

                //Check if given id is exist in the category list
                if (id == currCat.getId())
                {
                    found = true;
                    rtn = true;

                    currentCategories.Remove(currCat);
                    MessageBox.Show("Category successfully deleted.");
                    break;
                }
            }

            //If not exist, show error message
            if (!found)
            {
                MessageBox.Show("Sorry, this category is not in the system, please try again.");
            }

            return rtn;

        }

    }
}
