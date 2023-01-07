

namespace ET
{
    public class TransactionRecurrence
    {
        private int transactionId;
        private DateTime recurringStart;
        private DateTime recurringUntil;
        private string recurranceType;
        private int period;
        private List<DateTime> recurringDates = new List<DateTime>();

        //Constractor
        public TransactionRecurrence(int transactionId, DateTime recurringStart, DateTime recurringUntil, string recurranceType, int period)
        {
            this.transactionId = transactionId;
            this.recurringStart = recurringStart;
            this.recurringUntil = recurringUntil;
            this.recurranceType = recurranceType;
            this.period = period;


            this.setRecurringDates();

        }

        //Set recurring dates
        public void setRecurringDates()
        {
            DateTime tempDate = (recurranceType == "months") ? recurringStart.AddMonths(period) : recurringStart.AddDays(period);

            while (tempDate < recurringUntil)
            {
                recurringDates.Add(tempDate);
                tempDate = (recurranceType == "months") ? tempDate.AddMonths(period) : tempDate.AddDays(period);
            }
        }


        //Get recurring dates
        public List<DateTime> getRecurringDates()
        {
            return recurringDates;
        }

    }
}
