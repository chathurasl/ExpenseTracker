
using System.Windows.Forms;

namespace ET
{
    public class ExpenseFactory : TransactionFactory
    {

        private List<Transaction> currentTransactions = new List<Transaction>();


        public ExpenseFactory()
        {

        }

        public List<Transaction> getList()
        {
            return currentTransactions;
        }


        //Create Transaction method
        public bool createTransaction(Transaction t)
        {

            //Adding new Transaction to Transactions list
            currentTransactions.Add(t);
            return true;

        }

        //Edit Transaction method
        public bool editTransaction(Transaction t)
        {
            bool rtn = false;
            bool found = false;

            //Loop Transactions
            foreach (Transaction currTr in currentTransactions)
            {

                //Check if given id is exist in the Transaction list
                if (t.getId() == currTr.getId())
                {
                    found = true;
                    rtn = true;

                    int index = currentTransactions.IndexOf(currTr);
                    currentTransactions[index] = t;
                    break;
                }
            }

            return rtn;
        }

        //Delete Transaction method
        public bool deleteTransaction(int id)
        {
            bool found = false; //set flag
            bool rtn = false;

            //Loop Transactions
            foreach (Transaction currTr in currentTransactions)
            {

                //Check if given id is exist in the Transaction list
                if (id == currTr.getId())
                {
                    found = true;
                    rtn = true;

                    currentTransactions.Remove(currTr);
                    break;
                }
            }

            return rtn;
        }


        //Get Expense Amount and validate with the category budget
        public double getSpentAmountOfACategory(int categoryId)
        {
            double spentAmount = 0;

            foreach (Transaction transaction in currentTransactions) {

                if (transaction.getCategoryId() == categoryId &&
                (DateTime.Parse(transaction.getDate()).Year == DateTime.Now.Year && DateTime.Parse(transaction.getDate()).Month == DateTime.Now.Month)) 
                {
                    spentAmount += transaction.getAmount();
                }
            }

            return spentAmount;

        }

        //Get Expense Amount and validate with the category budget
        public bool isExpenseExceedBudget(Category category)
        {

            double spentAmount = getSpentAmountOfACategory(category.getId());

            if (spentAmount >= category.getBudget()) {

                return true;
            
            }
            else
            {

                return false;
            }

        }

        public Transaction getTransaction(int expenseId)
        {

            //Loop Transactions
            foreach (Transaction currTr in currentTransactions)
            {

                //Check if given id is exist in the Transaction list
                if (expenseId == currTr.getId())
                {
                    return currTr;
                }
            }

            return null;
        }


        public double getTotalExpense()
        {

            double sum = 0;

            //Loop Transactions
            foreach (Transaction currTr in currentTransactions)
            {

                sum += currTr.getAmount();
            }

            return sum;
        }


        public double getMonthTotalExpense()
        {

            double sum = 0;

            //Loop Transactions
            foreach (Transaction currTr in currentTransactions)
            {

                if ((DateTime.Parse(currTr.getDate()).Year == DateTime.Now.Year && DateTime.Parse(currTr.getDate()).Month == DateTime.Now.Month))
                {
                    sum += currTr.getAmount();

                }

            }

            return sum;
        }
    }
}
