
namespace ET
{
    public class ExpenseFactory : TransactionFactory
    {

        private List<Transaction> currentTransactions;


        public ExpenseFactory(List<Transaction> currentTransactions)
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
    }
}
