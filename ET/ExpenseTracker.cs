using System.Collections.Generic;
using System.Data;


namespace ET
{
    public partial class ExpenseTracker : Form
    {

        DataTable dt = new DataTable();
        DataTable catData = new DataTable();

        CategoryFactory categoryFactory = new CategoryFactory();
        IncomeFactory incomeFactory;
        ExpenseFactory expenseFactory;

        double totalIncome = 0;
        double totalExpense = 0;
        string currency = "LKR";

        //Load the constructor
        public ExpenseTracker()
        {
            InitializeComponent();
            incomeFactory = new IncomeFactory();
            expenseFactory = new ExpenseFactory();
        }

        //LoadAllTransaction into 1 list
        public List<Transaction> loadTransaction() 
        {
            List<Transaction> list = new List<Transaction>();
            list.AddRange(incomeFactory.getList());
            list.AddRange(expenseFactory.getList());
            return list;
            
        }

        //Main Function of the program
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            System.Windows.Forms.Application.Run(new ExpenseTracker());

        }

        //Hide the non active panels in the program
        public void hidePanels()
        {
            group_home.Hide();
            group_tr_add.Hide();
            group_tr_list.Hide();
            group_setting.Hide();
            group_cat_add.Hide();
            group_tr_view.Hide();
            group_tr_edit.Hide();
            group_abt.Hide();
            group_general.Hide();
        }

        //Fill the updated category name in all the category drop downs and tables
        public void fillCategoryData()
        {
            //Clear the category details from the tables and drop downs
            fb_tr_add_category.Items.Clear();
            fb_tr_edit_category.Items.Clear();
            fb_tr_search_category.Items.Clear();
            catData.Rows.Clear();
            resetCategoryForm();

            //Set display parameters
            fb_tr_add_category.DisplayMember = "Text";
            fb_tr_add_category.ValueMember = "Value";
            fb_tr_edit_category.DisplayMember = "Text";
            fb_tr_edit_category.ValueMember = "Value";
            fb_tr_search_category.DisplayMember = "Text";
            fb_tr_search_category.ValueMember = "Value";

            //For add add a please select value 
            fb_tr_add_category.Items.Add(new { Text = "--Please select--", Value = 0 });

            //For edit add an all option as a common option
            fb_tr_search_category.Items.Add(new { Text = "All", Value = 0 });

            //Navigate through each category and updated the dropdows/tables
            foreach (Category currCat in categoryFactory.getCategories())
            {
                fb_tr_add_category.Items.Add(new { Text = currCat.getCategoryName(), Value = currCat.getId() });
                fb_tr_edit_category.Items.Add(new { Text = currCat.getCategoryName(), Value = currCat.getId() });
                fb_tr_search_category.Items.Add(new { Text = currCat.getCategoryName(), Value = currCat.getId() });

                DataRow catRow = catData.NewRow();
                catRow[0] = currCat.getId(); ;
                catRow[1] = currCat.getCategoryName();
                catRow[2] = (currCat.getBudget() == 0)?"Unlimited": currCat.getBudget();

                catData.Rows.Add(catRow);
                cat_data.DataSource = catData;
            }

            //Set the selected index for add category drop down
            fb_tr_add_category.SelectedIndex = 0;

        }

        //Fill the transaction details in all the transaction tble
        public void fillTransactionData(){

            //Clear the details
            dt.Rows.Clear();

            foreach (Transaction currTr in loadTransaction())
            {
                DataRow dr = dt.NewRow();
                dr[0] = currTr.getId();
                dr[1] = currTr.getDescription();
                dr[2] = currTr.getDate();
                dr[3] = currTr.getAmount();
                dr[4] = currTr.getType();
                dr[5] = categoryFactory.getCategoryById(currTr.getCategoryId()).getCategoryName();
                dr[6] = currTr.getRecurrence();
                dr[7] = currTr.getNotes();

                dt.Rows.Add(dr);
            }
              
          
        }

        //Fill the transaction  type details in all the transaction type drop downs
        public void fillTransactionTypes()
        {
            fb_tr_add_type.Items.Clear();
            fb_tr_edit_type.Items.Clear();
            fb_tr_search_type.Items.Clear();

            fb_tr_add_type.DisplayMember = "Text";
            fb_tr_add_type.ValueMember = "Value";
            fb_tr_edit_type.DisplayMember = "Text";
            fb_tr_edit_type.ValueMember = "Value";
            fb_tr_search_type.DisplayMember = "Text";
            fb_tr_search_type.ValueMember = "Value";

            fb_tr_add_type.Items.Add(new { Text = "--Please select--", Value = "" });
            fb_tr_add_type.Items.Add(new { Text = "Income", Value = "Income" });
            fb_tr_add_type.Items.Add(new { Text = "Expense", Value = "Expense" });

            fb_tr_edit_type.Items.Add(new { Text = "Income", Value = "Income" });
            fb_tr_edit_type.Items.Add(new { Text = "Expense", Value = "Expense" });

            fb_tr_search_type.Items.Add(new { Text = "All", Value = 0 });
            fb_tr_search_type.Items.Add(new { Text = "Income", Value = "Income" });
            fb_tr_search_type.Items.Add(new { Text = "Expense", Value = "Expense" });


            fb_tr_add_type.SelectedIndex = 0;

        }

        //Fill the recurrence controls in the add transaction drop down
        public void fillRecurrenceOptions()
        {
            //Add 1 to 100 options in days/months selection
            for (int i = 1; i < 101; i++)
            {
                fb_tr_add_rec_count.Items.Add(i);
            }

            
            fb_tr_add_rec_type.Items.Add("months");
            fb_tr_add_rec_type.Items.Add("days");

            fb_tr_add_rec_count.SelectedIndex = 0;
            fb_tr_add_rec_type.SelectedIndex = 0;

        }

        //Load the expense tracker
        private void ExpenseTracker_Load(object sender, EventArgs e)
        {

            //ExpenseTracker ET = new ExpenseTracker();

            //Set table columns
            setDataTableHeadings();

            //Fill category dropdowns.
            fillCategoryData();

            //Fill type dropdowns
            fillTransactionTypes();

            //Fill recurrence options
            fillRecurrenceOptions();

            //Display today date
            displayDate();

            //Display summary
            displaySummary();

            //Set currecny
            setCurrency();

        }

     
        //Set the currency details in all currency labels
        public void setCurrency()
        {
            List<Label> labels = new List<Label>();

            labels.Add(currency_222);
            labels.Add(currency_34);
            labels.Add(currency_27);
            labels.Add(currency_334);
            labels.Add(currency_35);
            labels.Add(currency_28);
            labels.Add(currency_229);
            labels.Add(currency_272);
            labels.Add(currency_24);


            foreach (Label label in labels)
            {

                label.Text = currency;
            }
        }

        //Display today's date in date label
        public void displayDate()
        {

            string today = DateTime.Now.ToString("dddd, dd MMMM yyyy h:mm tt");
            lbl_date.Text = today;

        }       
        
        
        //Set transaction table heasings
        public void setDataTableHeadings()
        {

            //Data view columns
            dt.Columns.Clear();
            dt.Columns.Add("ID");
            dt.Columns.Add("Description");
            dt.Columns.Add("Date");
            dt.Columns.Add("Amount (" + currency + ")");
            dt.Columns.Add("Type");
            dt.Columns.Add("Category");
            dt.Columns.Add("Recurring");
            dt.Columns.Add("Notes");

            //Category table colimns
            catData.Columns.Clear();
            catData.Columns.Add("ID");
            catData.Columns.Add("Name");
            catData.Columns.Add("Budget (" + currency + ")");

        }

        //Display Summary in the home page
        public void displaySummary()
        {
            double monthlyExp = 0,
                monthlyInc = 0,
                mothlyBlc = 0,
                totalExp = 0,
                totalInc = 0,
                totalBlc = 0;

            totalInc = incomeFactory.getTotalIncome();
            totalExp = expenseFactory.getTotalExpense();
            monthlyInc = incomeFactory.getMonthTotalIncome();
            monthlyExp = expenseFactory.getMonthTotalExpense();

            mothlyBlc = monthlyInc - monthlyExp;
            totalBlc = totalInc - totalExp;

            lbl_mon_inc.Text = monthlyInc.ToString("N0");
            lbl_mon_exp.Text = monthlyExp.ToString("N0");
            lbl_mon_bal.Text = mothlyBlc.ToString("N0");

            lbl_tot_inc.Text = totalInc.ToString("N0");
            lbl_tot_exp.Text = totalExp.ToString("N0");
            lbl_tot_bal.Text = totalBlc.ToString("N0");

            lbl_mon_bal.ForeColor = (mothlyBlc < 0) ? Color.FromArgb(183, 28, 28) : Color.FromArgb(27, 94, 32);
            lbl_tot_bal.ForeColor = (totalBlc < 0) ? Color.FromArgb(183, 28, 28) : Color.FromArgb(27, 94, 32);

        }

        //Reset the All the forms in the system
        public void resetTrForms()
        {

            fb_tr_add_description.Text = "";
            fb_tr_add_amount.Text = "";
            fb_tr_add_date.Text = "";
            fb_tr_add_type.Text = "";
            fb_tr_add_category.Text = "";
            fb_tr_add_notes.Text = "";
            fb_tr_add_recurring.Checked = false;
            fb_tr_add_rec_untill.Text = "";

            fb_tr_add_type.SelectedIndex = 0;
            fb_tr_add_category.SelectedIndex = 0;

            fb_tr_edit_description.Text = "";
            fb_tr_edit_amount.Text = "";
            fb_tr_edit_date.Text = "";
            fb_tr_edit_type.Text = "";
            fb_tr_edit_category.Text = "";
            fb_tr_edit_notes.Text = "";
            fb_tr_edit_recurring.Checked = false;

            fb_tr_edit_type.SelectedIndex = 0;
            fb_tr_edit_category.SelectedIndex = 0;

            fb_tr_add_rec_count.SelectedIndex = 0;
            fb_tr_add_rec_type.SelectedIndex = 0;

            label_tr_add_rec_count.Hide();
            label_tr_add_rec_untill.Hide();
            fb_tr_add_rec_count.Hide();
            fb_tr_add_rec_type.Hide();
            fb_tr_add_rec_untill.Hide();
        }

        //Reset the category forms
        public void resetCategoryForm()
        {

            btn_cat_add.Show();
            btn_cat_update.Hide();
            btn_cat_delete.Hide();
            btn_cat_update_cancel.Hide();

            cat_id.Text = "";
            cat_add_name.Text = "";
            cat_add_budget.Text = "";

        }


        private void button1_Click(object sender, EventArgs e)
        {
            hidePanels();
            group_tr_add.Show();

            fillCategoryData();
            fillTransactionTypes();
            budgetAddCategory.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            hidePanels();
            group_tr_view.Show();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            hidePanels();
            group_setting.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hidePanels();
            group_cat_add.Show();
        }

        //Click on the Add Transaction Button to add a new transaction to the system
        private void btn_add_tr_Click(object sender, EventArgs e)
        {
            string mzg = "";
            double currAmount = 0;
            int catKey = (fb_tr_add_category.SelectedItem as dynamic).Value;
            string type = (fb_tr_add_type.SelectedItem as dynamic).Value;

            //Validate mandatory details
            if (fb_tr_add_description.Text == "")
            {
                mzg = "Please enter the transaction description";
            }
            else if (!Double.TryParse(fb_tr_add_amount.Text, out currAmount))
            {
                mzg = "Please enter a valid transaction amount";
            }else if (type == "")
            {
                mzg = "Please select a type";
            }
            else if (catKey == 0)
            {
                mzg = "Please select a category";
            }


            if (mzg != "")
            {
                MessageBox.Show(mzg, "Add Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool response = false;
                int id = Math.Abs((int) DateTime.Now.ToFileTime());

                //Add the transaction to the respective factory
                if (type == "Income")
                {
                    response = incomeFactory.createTransaction(new Income(id, fb_tr_add_description.Text, currAmount, fb_tr_add_recurring.Checked, fb_tr_add_date.Value, fb_tr_add_notes.Text, catKey));

                }
                else
                {
                    response = expenseFactory.createTransaction(new Expense(id, fb_tr_add_description.Text, currAmount, fb_tr_add_recurring.Checked, fb_tr_add_date.Value, fb_tr_add_notes.Text, catKey));
                }

                if (response)
                {
                    MessageBox.Show("Transaction sucessfully added to the list.", "Add Transaction", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Set recurrences
                    if (fb_tr_add_recurring.Checked)
                    {
                        int count = int.Parse(fb_tr_add_rec_count.Text);
                        string recType = fb_tr_add_rec_type.Text;

                        TransactionRecurrence tempRec = new TransactionRecurrence(id, fb_tr_add_date.Value.Date, fb_tr_add_rec_untill.Value.Date, recType, count);
                        List<DateTime> recDates = tempRec.getRecurringDates();

                        foreach (DateTime d in recDates)
                        {
                            id = Math.Abs((int)DateTime.Now.ToFileTime());

                            if (type == "Income")
                            {
                                response = incomeFactory.createTransaction(new Income(id, fb_tr_add_description.Text, currAmount, false, d, fb_tr_add_notes.Text, catKey));
                            }
                            else
                            {
                                response = expenseFactory.createTransaction(new Expense(id, fb_tr_add_description.Text, currAmount, false, d, fb_tr_add_notes.Text, catKey));
                            }

                        }

                    }

                    budgetAddCategory.Text = "";
                    resetTrForms();
                }
            }

        }

        //Click on the Edit Transaction Button to update a  transaction in the system
        private void btn_tr_update_Click(object sender, EventArgs e)
        {

            string mzg = "";
            double currAmount = 0;
            int catKey = (fb_tr_edit_category.SelectedItem as dynamic).Value;
            string type = (fb_tr_edit_type.SelectedItem as dynamic).Value;

            //Mandatory Validation
            if (fb_tr_edit_description.Text == "")
            {
                mzg = "Please enter the transaction description";
            }
            else if (!Double.TryParse(fb_tr_edit_amount.Text, out currAmount))
            {
                mzg = "Please enter a valid transaction amount";
            }else if (type == "")
            {
                mzg = "Please select a type";
            }
            else if (catKey == 0)
            {
                mzg = "Please select a category";
            }


            if (mzg != "")
            {
                MessageBox.Show(mzg, "Update Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool response = false;
                currAmount = Double.Parse(fb_tr_edit_amount.Text);


                if (type == "Income")
                {
                    if (incomeFactory.getTransaction(int.Parse(fb_tr_edit_id.Text)) == null)
                    {
                        changeTransactionType(new Income(int.Parse(fb_tr_edit_id.Text), fb_tr_edit_description.Text, currAmount, fb_tr_edit_recurring.Checked, fb_tr_edit_date.Value, fb_tr_edit_notes.Text, catKey));
                        response = true;
                    }
                    else {

                        response = incomeFactory.editTransaction(new Income(int.Parse(fb_tr_edit_id.Text), fb_tr_edit_description.Text, currAmount, fb_tr_edit_recurring.Checked, fb_tr_edit_date.Value, fb_tr_edit_notes.Text, catKey));
                    }
                }
                else
                {
                    if (expenseFactory.getTransaction(int.Parse(fb_tr_edit_id.Text)) == null)
                    {
                        changeTransactionType(new Expense(int.Parse(fb_tr_edit_id.Text), fb_tr_edit_description.Text, currAmount, fb_tr_edit_recurring.Checked, fb_tr_edit_date.Value, fb_tr_edit_notes.Text, catKey));
                        response = true;
                    }
                    else {
                        response = expenseFactory.editTransaction(new Expense(int.Parse(fb_tr_edit_id.Text), fb_tr_edit_description.Text, currAmount, fb_tr_edit_recurring.Checked, fb_tr_edit_date.Value, fb_tr_edit_notes.Text, catKey));
                    }
                }

                //Response is false if the relevant factories do not have the tansaction
                if (response)
                {

                    MessageBox.Show("Transaction successfully updated.", "Update Transaction", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Clear forms
                    resetTrForms();

                    //Show transaction list
                    hidePanels();
                    group_tr_view.Show();
                    btn_view_transactions_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Sorry, This Transaction ID does not exist in the system.", "Update Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        //Click on the Delete Transaction Button to delete a  transaction in the system
        private void btn_tr_delete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete this transaction?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                bool response = false;

                if (fb_tr_edit_type.Text == "Income")
                {
                    response = incomeFactory.deleteTransaction(int.Parse(fb_tr_edit_id.Text));

                }
                else
                {
                    response = expenseFactory.deleteTransaction(int.Parse(fb_tr_edit_id.Text));
                }

                //Response is false if the relevant factories do not have the tansaction
                if (response)
                {

                    MessageBox.Show("Transaction successfully deleted.", "Delete Transaction", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //List Transaction Data;
                    fillTransactionData();

                    //Clear forms
                    resetTrForms();

                    //Show transaction list
                    hidePanels();
                    group_tr_view.Show();
                    btn_view_transactions_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Sorry, This Transaction ID does not exist in the system.", "Delete Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        //This function allows a category to be added to the system
        private void btn_cat_add_Click(object sender, EventArgs e)
        {

            string mzg = "";
            double currBudget = 0;

            //Mandatory validation
            if (cat_add_name.Text == "")
            {
                mzg = "Please enter a name";
            }
            else if (cat_add_budget.Text != "")
            {
                if (!Double.TryParse(cat_add_budget.Text, out currBudget))
                {
                    mzg = "Please enter valid budget";

                }else if (Double.Parse(cat_add_budget.Text) == 0 )
                {
                    mzg = "The budget must be greater than 0";
                }

            }

            if (mzg != "")
            {
                MessageBox.Show(mzg, "Add Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Duplicate validation
                bool response = categoryFactory.addCategory(cat_add_name.Text, currBudget);
                if (response)
                {
                    MessageBox.Show("Category sucessfully added to the list.", "Add Category", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //RE-fill category dropdowns.
                    fillCategoryData();


                    //Reset category form data.
                    resetCategoryForm();
                }
                else
                {
                    MessageBox.Show("Sorry, The Provided category name already exists in the system.", "Add Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
           
        }

        //Open an existing category to edit its details
        private void cat_data_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && cat_data.Rows[e.RowIndex].Cells[0].Value.ToString() != "")
            {

                cat_id.Text = cat_data.Rows[e.RowIndex].Cells[0].Value.ToString();
                cat_add_name.Text = cat_data.Rows[e.RowIndex].Cells[1].Value.ToString();

                string budget = cat_data.Rows[e.RowIndex].Cells[2].Value.ToString();

                //Unlimited budget should be displayed as saved as ""
                if (budget == "Unlimited")
                {
                    cat_add_budget.Text = "";
                }
                else {
                    cat_add_budget.Text = cat_data.Rows[e.RowIndex].Cells[2].Value.ToString();
                }

                btn_cat_add.Hide();
                btn_cat_update.Show();
                btn_cat_delete.Show();
                btn_cat_update_cancel.Show();

            }
            else
            {
                MessageBox.Show("Invalid Category data.", "Update Category", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Update a category successfully in the system
        private void btn_cat_update_Click(object sender, EventArgs e)
        {
            string mzg = "";
            double currBudget = 0;

            //Mandatory validation
            if (cat_add_name.Text == "")
            {
                mzg = "Please enter a name";
            }
            else if (cat_add_budget.Text != "")
            {
                if (!Double.TryParse(cat_add_budget.Text, out currBudget))
                {
                    mzg = "Please enter valid budget";

                }
                else if (Double.Parse(cat_add_budget.Text) == 0)
                {
                    mzg = "The budget must be greater than 0";
                }

            }


            if (mzg != "")
            {
                MessageBox.Show(mzg, "Update Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Response is false if the category factory does not have the category
                bool response = categoryFactory.updateCategory(int.Parse(cat_id.Text), cat_add_name.Text, currBudget);
                if (response)
                {
                    MessageBox.Show("Category data successfully updated.", "Update Category", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //RE-fill category dropdowns.
                    fillCategoryData();

                    //Reset category form data.
                    resetCategoryForm();
                }
                else
                {
                    MessageBox.Show("Sorry, The provided category does not exist in the system.", "Update Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Cancel update
        private void btn_cat_update_cancel_Click(object sender, EventArgs e)
        {
            //Reset category form data.
            resetCategoryForm();
        }

        //Delete a category in the system
        private void btn_cat_delete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete this category?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                //Response is false if the category factory does not have the category
                bool response = categoryFactory.deleteCategory(int.Parse(cat_id.Text));
                if (response)
                {

                    MessageBox.Show("Category successfully deleted.", "Delete Category", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //RE-fill category dropdowns.
                    fillCategoryData();

                    //Reset category form data.
                    resetCategoryForm();
                }
                else
                {
                    MessageBox.Show("Sorry, The provided category does not exist in the system.", "Delete Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        //Navigate to edit from view transactions
        private void btn_view_transactions_Click(object sender, EventArgs e)
        {
            //Populate the category drop down
            fillCategoryData();

            //Populate the transaction type
            fb_tr_search_type.Items.Clear();
            fillTransactionTypes();

            //Clear all the drop downs and Controls
            fb_tr_search_category.SelectedIndex = 0;
            fb_tr_search_type.SelectedIndex = 0;

            //Set Date time picker for month and year
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MMMM";
            dateTimePicker1.ShowUpDown = true;

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy";
            dateTimePicker2.ShowUpDown = true;

            //Show transaction list
            hidePanels();
            group_tr_view.Show();
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowStyles.Clear();

            DateTime month = dateTimePicker1.Value;
            DateTime year = dateTimePicker2.Value;

            DateTime filteredDate = new DateTime(year.Year, month.Month, 1);

            //On Load get the transactions of the given details
            List<Transaction> list = getTransactionsOfGivenMonth(filteredDate, 0, "");

            //Populate the details in the panel
            updatePanel(list);
        }

        //Cancel transaction update
        private void btn_tr_update_cancle_Click(object sender, EventArgs e)
        {
            //Show transaction list
            hidePanels();
            group_tr_view.Show();
        }

        //Load Edit Transaction details
        private void loadEditTransaction(Transaction tr)
        {
            hidePanels();
            group_tr_edit.Show();

            //Populate the details in the edit page constrols
            fb_tr_edit_id.Text = tr.getId().ToString();

            fb_tr_edit_description.Text = tr.getDescription();
            fb_tr_edit_amount.Text = tr.getAmount().ToString();

            fb_tr_edit_recurring.Checked = tr.getRecurrence();
            fb_tr_edit_date.Value = DateTime.Parse(tr.getDate());
            fb_tr_edit_notes.Text = tr.getNotes();

            string category = categoryFactory.getCategoryById(tr.getCategoryId()).getCategoryName();

            //Fill the transaction type and category drop downs
            fillCategoryData();
            fillTransactionTypes();

            fb_tr_edit_category.SelectedIndex = fb_tr_edit_category.FindString(category);
            fb_tr_edit_type.SelectedIndex = fb_tr_edit_type.FindString(tr.getType());

            //Apply validate budget principle
            double budget = categoryFactory.getCategoryById(tr.getCategoryId()).getBudget();

            int catKey = (fb_tr_add_category.SelectedItem as dynamic).Value;

                if (budget > 0)
                {
                    double spentAmount = getMonthExpenditureOfBudget(tr.getCategoryId());
                    budgetEditCategory.Text = "You have spent " + currency + " " + spentAmount.ToString("N0") + " and your budget is " + currency + " " + budget.ToString("N0") +
                    ".";
                    budgetEditCategory.ForeColor = (budget > spentAmount) ? Color.FromArgb(56, 142, 60) : Color.FromArgb(244, 67, 54);

                }
                else
                {
                    budgetEditCategory.Text = "Unlimited Budget";
                    budgetEditCategory.ForeColor = Color.FromArgb(56, 142, 60);

                }
        }

        //Return a list of transactions depending on the filters
        private List<Transaction> getTransactionsOfGivenMonth(DateTime date, int categoryId, string transactionType)
        {

            //Get last date of the month, year
            int lastDay = DateTime.DaysInMonth(date.Year, date.Month);
            DateTime lastDate = new DateTime(date.Year, date.Month, lastDay);

            //Get the first date of the month year
            DateTime firstDate = new DateTime(date.Year, date.Month, 1);

            //Get all the expenses matching this year
            List<Transaction> filteredTransaction = new List<Transaction>();

            //Navigate through current transaction and get the lists based on the filters 
            foreach (Transaction tr in loadTransaction())
            {
                //Date filteration
                if (DateTime.Parse(tr.getDate()) >= firstDate && DateTime.Parse(tr.getDate()) <= lastDate)
                {
                    //Category Filterations if category is selected
                    if (categoryId != 0 && tr.getCategoryId() == categoryId)
                    {
                        //Transaction type filteration if type is selected
                        if (transactionType != "" && tr.getType() == transactionType)
                        {
                            filteredTransaction.Add(tr);
                        }
                        else if (transactionType == "") //if type is not selected
                        {
                            filteredTransaction.Add(tr);

                        }
                    }
                    else if (categoryId == 0) // if category is not selected
                    {
                        if (transactionType != "" && tr.getType() == transactionType) // but type is selected
                        {
                            filteredTransaction.Add(tr);
                        }
                        else if (transactionType == "") // type is also not selected
                        {
                            filteredTransaction.Add(tr);
                        }
                    }
                }
            }

            //Sort transaction list with IComparable implementation and reverse the sort
            filteredTransaction.Sort();
            filteredTransaction.Reverse();

            return filteredTransaction;

        }

        //Click on the budget overview to load all the budgets of categories
        private void btn_tr_list_Click(object sender, EventArgs e)
        {
            hidePanels();
            group_tr_list.Show();
            budgetPanel.Controls.Clear();
            budgetPanel.RowStyles.Clear();

            double overAllSpending = 0;
            double overAllBudget = 0;

            //Panel Headers
            budgetPanel.Controls.Add(new Label()
            {
                Text = "Category Name",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                TextAlign = ContentAlignment.TopLeft,
                //Size = new System.Drawing.Size(900, 26)
            }, 0, 0);

            budgetPanel.Controls.Add(new Label()
            {
                Text = "Budget (" + currency + ")",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                TextAlign = ContentAlignment.TopRight

            }, 1, 0);
            budgetPanel.Controls.Add(new Label()
            {
                Text = "Spent (" + currency + ")",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                TextAlign = ContentAlignment.TopRight

            }, 2, 0);
            budgetPanel.Controls.Add(new Label()
            {
                Text = "Balance (" + currency + ")",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                TextAlign = ContentAlignment.TopRight

            }, 3, 0);

            //Navigate through categories to display there budget
            int count = 1;
            foreach (Category cat in categoryFactory.getCategories())
            {
                double budgetAmount = cat.getBudget();
                double spentAmount = getMonthExpenditureOfBudget(cat.getId());

                bool budgetExceed = false;

                overAllBudget += budgetAmount;
                overAllSpending += spentAmount;

                if (budgetAmount > 0 && spentAmount >= budgetAmount) {

                    budgetExceed = true;
                }

                budgetPanel.RowCount = budgetPanel.RowCount + 1;
                budgetPanel.Controls.Add(new Label()
                {
                    Text = cat.getCategoryName(),
                    Font = new Font("Segoe UI", 12),
                    TextAlign = ContentAlignment.TopLeft,
                    //Size = new System.Drawing.Size(900, 26)
                }, 0, count);
                
                budgetPanel.Controls.Add(new Label()
                {
                    Text = budgetAmount > 0 ? cat.getBudget().ToString("N0") : "Unlimited",
                    Font = new Font("Segoe UI", 12),
                    //Size = new System.Drawing.Size(900, 30),
                    TextAlign = ContentAlignment.TopRight

                }, 1, count);     
                budgetPanel.Controls.Add(new Label()
                {
                    Text = spentAmount.ToString("N0"),
                    Font = new Font("Segoe UI", 12),
                    //Size = new System.Drawing.Size(900, 30),
                    ForeColor = (budgetExceed)?Color.Red:Color.Black,
                    TextAlign = ContentAlignment.TopRight

                }, 2, count);

                string balance = "";
                if (budgetAmount > 0) {

                    balance = (budgetAmount - spentAmount).ToString("N0");
                }
                else 
                {
                    balance = "-";    
                }
                budgetPanel.Controls.Add(new Label()
                {
                    Text = balance,
                    Font = new Font("Segoe UI", 12),
                    //Size = new System.Drawing.Size(900, 30),
                    ForeColor = (budgetExceed) ? Color.Red : Color.Black,
                    TextAlign = ContentAlignment.TopRight

                }, 3, count);
                
                count++;

            }

            //Set the overall budget details
            lblOverallBudget.Text = currency + " " +  overAllBudget.ToString("N0");
            lblOverallSpending.Text = currency + " " + overAllSpending.ToString("N0");

            lblOverallSpending.ForeColor = (overAllSpending > overAllBudget) ? Color.FromArgb(183, 28, 28) : Color.FromArgb(27, 94, 32);

        }

        //Get the Expense Sum of a Category
        private double getMonthExpenditureOfBudget(int categoryId) {

            double sumExpense = expenseFactory.getSpentAmountOfACategory(categoryId);

            return sumExpense;
        
        }

        //Enable/Disable recurring controls on selecting recurrence 
        private void fb_tr_add_recurring_CheckedChanged(object sender, EventArgs e)
        {
            if (fb_tr_add_recurring.Checked)
            {
                label_tr_add_rec_count.Show();
                label_tr_add_rec_untill.Show();
                fb_tr_add_rec_count.Show();
                fb_tr_add_rec_type.Show();
                fb_tr_add_rec_untill.Show();
            }
            else
            {
                label_tr_add_rec_count.Hide();
                label_tr_add_rec_untill.Hide();
                fb_tr_add_rec_count.Hide();
                fb_tr_add_rec_type.Hide();
                fb_tr_add_rec_untill.Hide();
            }
           
        }

        //Navigate to home page
        private void button2_Click_1(object sender, EventArgs e)
        {
            //Update summary
            displaySummary();

            hidePanels();
            group_home.Show();
        }

        //Navigate to view transactions page
        private void button1_Click_1(object sender, EventArgs e)
        {
            hidePanels();
            group_tr_view.Show();
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowStyles.Clear();

            int catKey = 0;
            string type = "";

            if (fb_tr_search_category.SelectedIndex != 0) {
                catKey = (fb_tr_search_category.SelectedItem as dynamic).Value;
            }
            if (fb_tr_search_type.SelectedIndex != 0)
            {
                type = (fb_tr_search_type.SelectedItem as dynamic).Value;
            }

            DateTime month = dateTimePicker1.Value;
            DateTime year = dateTimePicker2.Value;

            DateTime filteredDate = new DateTime(year.Year, month.Month, 1);

            List<Transaction> list = getTransactionsOfGivenMonth(filteredDate, catKey, type);

            updatePanel(list);
        }


        //Update the transaction list panel
        private void updatePanel(List<Transaction> list) {
            totalIncome = 0;
            totalExpense = 0;

            int count = -1;
            Boolean isIncome = false;
            foreach (Transaction tr in list)
            {
                if (tr.getType() == "Income")
                {

                    totalIncome += tr.getAmount();
                    isIncome = true;

                }
                else
                {
                    isIncome = false;
                    totalExpense += tr.getAmount();
                }
                count++;
                tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount + 2;

                tableLayoutPanel1.Controls.Add(new Label()
                {
                    Text = tr.getDescription(),
                    ForeColor = Color.FromArgb(26, 35, 126),
                    Font = new Font("Segoe UI Semibold", 12),
                    TextAlign = ContentAlignment.TopLeft,
                    Size = new System.Drawing.Size(900, 26)
                }, 0, count);


                if (tr.getRecurrence())
                {
                    tableLayoutPanel1.Controls.Add(new PictureBox()
                    {
                        BackgroundImage = global::ET.Properties.Resources.recurring,
                        BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom,
                        Size = new System.Drawing.Size(16, 16)
                    }, 2, count);
                }


                tableLayoutPanel1.Controls.Add(new Label()
                {
                    Text = categoryFactory.getCategoryById(tr.getCategoryId()).getCategoryName(),
                    ForeColor = Color.FromArgb(26, 35, 126),
                    Font = new Font("Segoe UI Semibold", 10),
                    TextAlign = ContentAlignment.TopLeft,
                     Size = new System.Drawing.Size(120, 26)
                }, 1, count);

                tableLayoutPanel1.Controls.Add(new Label()
                {
                    Text = currency + " " + tr.getAmount().ToString("N0"),
                    // ForeColor = isIncome ? Color.DarkGreen : Color.DarkRed,
                    ForeColor = (isIncome) ? Color.FromArgb(76, 175, 80) : Color.FromArgb(244, 67, 54),
                    Font = new Font("Segoe UI", 15),
                    Size = new System.Drawing.Size(900, 30),
                    TextAlign = ContentAlignment.BottomRight

                }, 3, count);

                tableLayoutPanel1.Controls.Add(
                new Button()
                {
                    BackgroundImage = ET.Properties.Resources.arrow_right,
                    BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom,
                    FlatStyle = FlatStyle.Flat,
                    FlatAppearance = { BorderSize = 0 },
                        Size = new System.Drawing.Size(40, 30),
                        ImageAlign = ContentAlignment.BottomRight,
                    }, 4, count);
               // tableLayoutPanel1.SetRowSpan(tableLayoutPanel1.GetControlFromPosition(2, count), 2);

                tableLayoutPanel1.GetControlFromPosition(4, count).Click += (object sender, EventArgs e) =>
                {
                    //you can use your variables inside event
                    loadEditTransaction(tr);
                };
                count++;

                tableLayoutPanel1.Controls.Add(new Label()
                {
                    Text = tr.getNotes(),
                    TextAlign = ContentAlignment.TopLeft,
                    Font = new Font("Segoe UI", 9),
                    Size = new System.Drawing.Size(900, 20)
                }, 0, count);

                tableLayoutPanel1.Controls.Add(new Label()
                {
                    Text = tr.getDate(),
                    TextAlign = ContentAlignment.TopLeft,
                    Font = new Font("Segoe UI", 10),
                    Size = new System.Drawing.Size(120, 20)
                }, 1, count);
            }

            panel2.Controls.Clear();
            panel3.Controls.Clear();


            panel2.Controls.Add(
                new Label()
                {
                    Text = currency + " " + totalIncome.ToString("N0"),
                    TextAlign = ContentAlignment.TopRight,
                    Size = panel2.Size,
                    Font = new Font("Segoe UI", 12),
                });
            panel3.Controls.Add(new Label()
            {
                Text = currency + " " + totalExpense.ToString("N0"),
                TextAlign = ContentAlignment.TopRight,
                Size = panel3.Size,
                Font = new Font("Segoe UI", 12),
            });
        }

        //Validate budget when the add category drop down index changes
        private void fb_tr_add_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            int catKey = (fb_tr_add_category.SelectedItem as dynamic).Value;

            if (catKey > 0)
            {
                double budget = categoryFactory.getCategoryById(catKey).getBudget();

                if (budget > 0)
                {
                    double spentAmount = getMonthExpenditureOfBudget(catKey);
                    bool isExpenseExceeded = expenseFactory.isExpenseExceedBudget(categoryFactory.getCategoryById(catKey));
                    budgetAddCategory.Text = "You have spent " + currency + " " + spentAmount.ToString("N0") + " and your budget is " + currency + " " + budget.ToString("N0") +
                    ".";
                    budgetAddCategory.ForeColor = !isExpenseExceeded ? Color.FromArgb(56, 142, 60) : Color.FromArgb(244, 67, 54);

                }
                else
                {
                    budgetAddCategory.Text = "Unlimited Budget";
                    budgetAddCategory.ForeColor = Color.FromArgb(56, 142, 60);
                }
            }
        }

        //Validate budget when the edit category drop down index changes
        private void fb_tr_edit_category_SelectedIndexChanged(object sender, EventArgs e)
        {

            int catKey = (fb_tr_edit_category.SelectedItem as dynamic).Value;


            double budget = categoryFactory.getCategoryById(catKey).getBudget();


            if (budget > 0)
            {
                double spentAmount = getMonthExpenditureOfBudget(catKey);
                bool isExpenseExceeded = expenseFactory.isExpenseExceedBudget(categoryFactory.getCategoryById(catKey));
                budgetEditCategory.Text = "You have spent " + currency + " " + spentAmount.ToString("N0") + " and your budget is " + currency + " " + budget.ToString("N0") +
                ".";
                budgetEditCategory.ForeColor = !isExpenseExceeded ? Color.FromArgb(56, 142, 60) : Color.FromArgb(244, 67, 54);

            }
            else
            {
                budgetEditCategory.Text = "Unlimited Budget";
                budgetEditCategory.ForeColor = Color.FromArgb(56, 142, 60);
            }
        }

        //Navigate to General Page
        private void btn_general_Click(object sender, EventArgs e)
        {
            hidePanels();
            group_general.Show();
        }

        //Navigate to About Page
        private void btn_about_Click_1(object sender, EventArgs e)
        {
            hidePanels();
            group_abt.Show();
        }

        //Navigate to Settings page
        private void btn_save_settings_Click(object sender, EventArgs e)
        {
            currency = fb_currency.Text;
            setCurrency();
            setDataTableHeadings();

            MessageBox.Show("Application settings sucessfully updated.", "Save Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //Update relevant 
        private void changeTransactionType(Transaction tr)
        {
            if (tr.getType() == "Income")
            {
                incomeFactory.createTransaction(tr);
                expenseFactory.deleteTransaction(tr.getId());
            }
            else {
                expenseFactory.createTransaction(tr);
                incomeFactory.deleteTransaction(tr.getId());
            }
        }

    }
}