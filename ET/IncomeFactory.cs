
namespace ET
{
    public class IncomeFactory:TransactionFactory
    {

        private List<Transaction> currentTransactions;


        public IncomeFactory(List<Transaction>  currentTransactions)
        {

            this.currentTransactions = currentTransactions;
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
            bool found = true;

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


        public Transaction getTransaction(int incomeId) {

            //Loop Transactions
            foreach (Transaction currTr in currentTransactions)
            {

                //Check if given id is exist in the Transaction list
                if (incomeId == currTr.getId())
                {
                    return currTr;
                }
            }

            return null;
        }


        public double getTotalIncome()
        {

            double sum = 0;

            //Loop Transactions
            foreach (Transaction currTr in currentTransactions)
            {

                sum += currTr.getAmount();
            }

            return sum;
        }

        public double getMonthTotalIncome() {

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
