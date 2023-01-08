using System.Data;


namespace ET
{
    public partial class ExpenseTracker : Form
    {

        // private Dictionary<int, Category> currentCategories = new Dictionary<int, Category>();
        //private Dictionary<int, Transaction> currentTransactions = new Dictionary<int, Transaction>();
        List<Transaction> currentTransactions = new List<Transaction>();

        DataTable dt = new DataTable();
        DataTable catData = new DataTable();

        CategoryFactory categoryFactory = new CategoryFactory();
        IncomeFactory incomeFactory;
        ExpenseFactory expenseFactory;

        double totalIncome = 0;
        double totalExpense = 0;
        string currency = "LKR";


        public ExpenseTracker()
        {
            InitializeComponent();
            incomeFactory = new IncomeFactory(currentTransactions);
            expenseFactory = new ExpenseFactory(currentTransactions);
        }


        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            System.Windows.Forms.Application.Run(new ExpenseTracker());

        }


        public void hidePanels()
        {
            group_home.Hide();
            group_tr_add.Hide();
            group_tr_list.Hide();
            group_setting.Hide();
            group_cat_add.Hide();
            group_tr_view.Hide();
            group_tr_edit.Hide();
        }

        public void fillCategoryData()
        {

            fb_tr_add_category.Items.Clear();
            fb_tr_edit_category.Items.Clear();
            fb_tr_search_category.Items.Clear();
            catData.Rows.Clear();


            fb_tr_add_category.DisplayMember = "Text";
            fb_tr_add_category.ValueMember = "Value";
            fb_tr_edit_category.DisplayMember = "Text";
            fb_tr_edit_category.ValueMember = "Value";
            fb_tr_search_category.DisplayMember = "Text";
            fb_tr_search_category.ValueMember = "Value";

            fb_tr_add_category.Items.Add(new { Text = "--Please select--", Value = 0 });


            foreach (Category currCat in categoryFactory.getCategories())
            {
                // fb_tr_add_category.Items.Add(currCat.getCategoryName());
                fb_tr_add_category.Items.Add(new { Text = currCat.getCategoryName(), Value = currCat.getId() });
                fb_tr_edit_category.Items.Add(new { Text = currCat.getCategoryName(), Value = currCat.getId() });
                fb_tr_search_category.Items.Add(new { Text = currCat.getCategoryName(), Value = currCat.getId() });

                DataRow catRow = catData.NewRow();
                catRow[0] = currCat.getId(); ;
                catRow[1] = currCat.getCategoryName();
                catRow[2] = currCat.getBudget();

                catData.Rows.Add(catRow);
                cat_data.DataSource = catData;
            }

            fb_tr_add_category.SelectedIndex = 0;

        }


        public void fillTransactionData(){

            dt.Rows.Clear();

            foreach (Transaction currTr in currentTransactions)
            {
                DataRow dr = dt.NewRow();
                dr[0] = currTr.getId();
                dr[1] = currTr.getDescription();
                dr[2] = currTr.getDate();
                dr[3] = currTr.getAmount();
                dr[4] = currTr.getType();
                dr[5] = categoryFactory.getCategroyNameById(currTr.getCategroyId());
                dr[6] = currTr.getRecurrence();
                dr[7] = currTr.getNotes();

                dt.Rows.Add(dr);
                tr_data.DataSource = dt;
            }
              
          
        }
        
        
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

            fb_tr_search_type.Items.Add(new { Text = "Income", Value = "Income" });
            fb_tr_search_type.Items.Add(new { Text = "Expense", Value = "Expense" });


            fb_tr_add_type.SelectedIndex = 0;

        }


        public void fillRecurrenceOptions()
        {

            for (int i = 1; i < 101; i++)
            {
                fb_tr_add_rec_count.Items.Add(i);
            }

            
            fb_tr_add_rec_type.Items.Add("months");
            fb_tr_add_rec_type.Items.Add("days");

            fb_tr_add_rec_count.SelectedIndex = 0;
            fb_tr_add_rec_type.SelectedIndex = 0;

        }




        private void ExpenseTracker_Load(object sender, EventArgs e)
        {

            //ExpenseTracker ET = new ExpenseTracker();

            //Data view columns
            dt.Columns.Add("ID");
            dt.Columns.Add("Description");
            dt.Columns.Add("Date");
            dt.Columns.Add("Amount");
            dt.Columns.Add("Type");
            dt.Columns.Add("Category");
            dt.Columns.Add("Recurring");
            dt.Columns.Add("Notes");

            //Category table colimns
            catData.Columns.Add("ID");
            catData.Columns.Add("Name");
            catData.Columns.Add("Budget");


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
        }

        public void displayDate()
        {

            string today = DateTime.Now.ToString("dddd, dd MMMM yyyy h:mm tt");
            lbl_date.Text = today;

        }

        public void displaySummary()
        {
            double monthlyExp = 0,
                monthlyInc = 0,
                mothlyBlc = 0,
                totalExp = 0,
                totalInc = 0,
                totalBlc = 0;


            foreach (Transaction currTr in currentTransactions)
            {

                if (currTr.getType() == "Income")
                {
                    totalInc += currTr.getAmount();
                }
                else
                {
                    totalExp += currTr.getAmount();
                }

                if ((DateTime.Parse(currTr.getDate()).Year == DateTime.Now.Year && DateTime.Parse(currTr.getDate()).Month == DateTime.Now.Month))
                {
                    if (currTr.getType() == "Income")
                    {
                        monthlyInc += currTr.getAmount();
                    }
                    else
                    {
                        monthlyExp += currTr.getAmount();
                    }
                }
            }

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

        public void resetCategroyForm()
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


        private void btn_add_tr_Click(object sender, EventArgs e)
        {
            string mzg = "";
            double currAmount = 0;
            int catKey = (fb_tr_add_category.SelectedItem as dynamic).Value;
            string type = (fb_tr_add_type.SelectedItem as dynamic).Value;

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

                    //List Transaction Data;
                    fillTransactionData();
                    resetTrForms();

                   

                }
            }

        }

        private void btn_tr_update_Click(object sender, EventArgs e)
        {

            string mzg = "";
            double currAmount = 0;
            int catKey = (fb_tr_edit_category.SelectedItem as dynamic).Value;
            string type = (fb_tr_edit_type.SelectedItem as dynamic).Value;


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

                    response = incomeFactory.editTransaction(new Income(int.Parse(fb_tr_edit_id.Text), fb_tr_edit_description.Text, currAmount, fb_tr_edit_recurring.Checked, fb_tr_edit_date.Value, fb_tr_edit_notes.Text, catKey));

                }
                else
                {
                    response = expenseFactory.editTransaction(new Expense(int.Parse(fb_tr_edit_id.Text), fb_tr_edit_description.Text, currAmount, fb_tr_edit_recurring.Checked, fb_tr_edit_date.Value, fb_tr_edit_notes.Text, catKey));
                }

                if (response)
                {
                    //List Transaction Data;
                    //fillTransactionData();
                    

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

   

        private void tr_data_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

           if (tr_data.Rows[e.RowIndex].Cells[0].Value.ToString() != "")
            {

                fb_tr_edit_id.Text = tr_data.Rows[e.RowIndex].Cells[0].Value.ToString();
                fb_tr_edit_description.Text = tr_data.Rows[e.RowIndex].Cells[1].Value.ToString();
                fb_tr_edit_date.Text = tr_data.Rows[e.RowIndex].Cells[2].Value.ToString();
                fb_tr_edit_amount.Text = tr_data.Rows[e.RowIndex].Cells[3].Value.ToString();
                fb_tr_edit_type.Text = tr_data.Rows[e.RowIndex].Cells[4].Value.ToString();
                fb_tr_edit_category.Text = tr_data.Rows[e.RowIndex].Cells[5].Value.ToString();
                fb_tr_edit_notes.Text = tr_data.Rows[e.RowIndex].Cells[7].Value.ToString();
                fb_tr_edit_recurring.Checked = false;

                if (tr_data.Rows[e.RowIndex].Cells[6].Value.ToString() == "True")
                {
                    fb_tr_edit_recurring.Checked = true;
                }

                hidePanels();
                group_tr_edit.Show();

            }
            else
            {
                MessageBox.Show("Invalid Transaction data.", "Update Transaction", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
            
        }



        private void btn_cat_add_Click(object sender, EventArgs e)
        {

            string mzg = "";
            double currBudget = 0;

            if (cat_add_name.Text == "")
            {
                mzg = "Please enter a name";
            }
            else if (!Double.TryParse(cat_add_budget.Text, out currBudget))
            {
                mzg = "Please enter valid budget";
            }


            if (mzg != "")
            {
                MessageBox.Show(mzg, "Add Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool response = categoryFactory.addCategory(cat_add_name.Text, currBudget);
                if (response)
                {
                    MessageBox.Show("Category sucessfully added to the list.", "Add Category", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //RE-fill category dropdowns.
                    fillCategoryData();
                }
                else
                {
                    MessageBox.Show("Sorry, The Provided category name already exists in the system.", "Add Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
           
        }

        private void cat_data_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && cat_data.Rows[e.RowIndex].Cells[0].Value.ToString() != "")
            {

                cat_id.Text = cat_data.Rows[e.RowIndex].Cells[0].Value.ToString();
                cat_add_name.Text = cat_data.Rows[e.RowIndex].Cells[1].Value.ToString();
                cat_add_budget.Text = cat_data.Rows[e.RowIndex].Cells[2].Value.ToString();

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

        private void btn_cat_update_Click(object sender, EventArgs e)
        {
            string mzg = "";
            double currBudget = 0;

            if (cat_add_name.Text == "")
            {
                mzg = "Please enter a name";
            }
            else if (!Double.TryParse(cat_add_budget.Text, out currBudget))
            {
                mzg = "Please enter valid budget";
            }


            if (mzg != "")
            {
                MessageBox.Show(mzg, "Update Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool response = categoryFactory.updateCategory(int.Parse(cat_id.Text), cat_add_name.Text, currBudget);
                if (response)
                {
                    MessageBox.Show("Category data successfully updated.", "Update Category", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //RE-fill category dropdowns.
                    fillCategoryData();

                    //Reset category form data.
                    resetCategroyForm();
                }
                else
                {
                    MessageBox.Show("Sorry, The provided category does not exist in the system.", "Update Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_cat_update_cancel_Click(object sender, EventArgs e)
        {
            //Reset category form data.
            resetCategroyForm();
        }

        private void btn_cat_delete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete this category?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                bool response = categoryFactory.deleteCategory(int.Parse(cat_id.Text));
                if (response)
                {

                    MessageBox.Show("Category successfully deleted.", "Delete Category", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //RE-fill category dropdowns.
                    fillCategoryData();

                    //Reset category form data.
                    resetCategroyForm();
                }
                else
                {
                    MessageBox.Show("Sorry, The provided category does not exist in the system.", "Delete Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btn_view_transactions_Click(object sender, EventArgs e)
        {
            fillCategoryData();

            fb_tr_search_type.Items.Clear();
            fillTransactionTypes();

            fb_tr_search_category.ResetText();
            fb_tr_search_type.ResetText();

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

            List<Transaction> list = getTransactionsOfGivenMonth(filteredDate, 0, "");

            updatePanel(list);
        }

        private void btn_tr_update_cancle_Click(object sender, EventArgs e)
        {
            //Show transaction list
            hidePanels();
            group_tr_view.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void loadEditTransaction(Transaction tr)
        {
            hidePanels();
            group_tr_edit.Show();

            fb_tr_edit_id.Text = tr.getId().ToString();

            fb_tr_edit_description.Text = tr.getDescription();
            fb_tr_edit_amount.Text = tr.getAmount().ToString();

            fb_tr_edit_recurring.Checked = tr.getRecurrence();
            fb_tr_edit_date.Value = DateTime.Parse(tr.getDate());
            fb_tr_edit_notes.Text = tr.getNotes();

            string category = categoryFactory.getCategroyNameById(tr.getCategroyId());

            fillCategoryData();
            fillTransactionTypes();

            fb_tr_edit_category.SelectedIndex = fb_tr_edit_category.FindString(category);
            fb_tr_edit_type.SelectedIndex = fb_tr_edit_type.FindString(tr.getType());

        }

        private void label12_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_about_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click_1(object sender, EventArgs e)
        {

        }

        private List<Transaction> getTransactionsOfGivenMonth(DateTime date, int categoryId, string transactionType)
        {

            //Get last date of the month, year
            int lastDay = DateTime.DaysInMonth(date.Year, date.Month);
            DateTime lastDate = new DateTime(date.Year, date.Month, lastDay);

            //Get the first date of the month year
            DateTime firstDate = new DateTime(date.Year, date.Month, 1);

            //Get all the expenses matching this year
            List<Transaction> filteredTransaction = new List<Transaction>();

            foreach (Transaction tr in currentTransactions)
            {
                if (DateTime.Parse(tr.getDate()) >= firstDate && DateTime.Parse(tr.getDate()) <= lastDate)
                {

                    if (categoryId != 0 && tr.getCategroyId() == categoryId)
                    {

                        if (transactionType != "" && tr.getType() == transactionType)
                        {
                            filteredTransaction.Add(tr);
                        }
                        else if (transactionType == "") 
                        {
                            filteredTransaction.Add(tr);

                        }
                    }
                    else if (categoryId == 0)
                    {
                        if (transactionType != "" && tr.getType() == transactionType)
                        {
                            filteredTransaction.Add(tr);
                        }
                        else if (transactionType == "")
                        {
                            filteredTransaction.Add(tr);
                        }
                    }
                }
            }

            filteredTransaction.Sort();
            filteredTransaction.Reverse();

            return filteredTransaction;


        }

        private void btn_tr_list_Click(object sender, EventArgs e)
        {
            hidePanels();
            group_tr_list.Show();
        }

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

        private void button2_Click_1(object sender, EventArgs e)
        {
            //Update summary
            displaySummary();

            hidePanels();
            group_home.Show();
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            hidePanels();
            group_tr_view.Show();
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowStyles.Clear();

            int catKey = 0;
            string type = "";

            if (fb_tr_search_category.SelectedItem != null) {
                catKey = (fb_tr_search_category.SelectedItem as dynamic).Value;
            }
            if (fb_tr_search_type.SelectedItem != null)
            {
                type = (fb_tr_search_type.SelectedItem as dynamic).Value;
            }

            DateTime month = dateTimePicker1.Value;
            DateTime year = dateTimePicker2.Value;

            DateTime filteredDate = new DateTime(year.Year, month.Month, 1);

            List<Transaction> list = getTransactionsOfGivenMonth(filteredDate, catKey, type);

            updatePanel(list);
        }

        private void updatePanel(List<Transaction> list) {
            totalIncome = 0;
            totalExpense = 0;

            int count = -1;
            foreach (Transaction tr in list)
            {
                if (tr.getType() == "Income")
                {

                    totalIncome += tr.getAmount();

                }
                else
                {

                    totalExpense += tr.getAmount();
                }
                count++;
                tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount + 2;
                tableLayoutPanel1.Controls.Add(new Label()
                {
                    Text = tr.getDescription(),
                    ForeColor = Color.DarkGreen,
                    Font = new Font("Segoe UI", 12),
                    TextAlign = ContentAlignment.TopLeft,
                    //Size = new System.Drawing.Size(900, 26)
                }, 0, count);
                tableLayoutPanel1.Controls.Add(new Label()
                {
                    Text = tr.getAmount().ToString(),
                    ForeColor = Color.DarkGreen,
                    Font = new Font("Segoe UI", 15),
                    Size = new System.Drawing.Size(900, 30),
                    TextAlign = ContentAlignment.BottomRight

                }, 1, count);

                tableLayoutPanel1.Controls.Add(
                new Button()
                {
                    BackgroundImage = ET.Properties.Resources.arrow_right,
                    BackgroundImageLayout = ImageLayout.Zoom,
                    FlatStyle = FlatStyle.Flat,
                    FlatAppearance = { BorderSize = 0 },
                    Size = new System.Drawing.Size(40, 30),
                    ImageAlign = ContentAlignment.BottomRight,
                }, 2, count);
                tableLayoutPanel1.SetRowSpan(tableLayoutPanel1.GetControlFromPosition(2, count), 2);

                tableLayoutPanel1.GetControlFromPosition(2, count).Click += (object sender, EventArgs e) =>
                {
                    //you can use your variables inside event
                    loadEditTransaction(tr);
                };
                count++;

                tableLayoutPanel1.Controls.Add(new Label()
                {
                    Text = tr.getDate(),
                    TextAlign = ContentAlignment.TopLeft,
                    Font = new Font("Segoe UI", 8),
                }, 0, count);

            }

            panel2.Controls.Clear();
            panel3.Controls.Clear();


            panel2.Controls.Add(
                new Label()
                {
                    Text = totalIncome.ToString(),
                    TextAlign = ContentAlignment.TopRight,
                    Size = panel2.Size,
                    Font = new Font("Segoe UI", 12),
                });
            panel3.Controls.Add(new Label()
            {
                Text = totalExpense.ToString(),
                TextAlign = ContentAlignment.TopRight,
                Size = panel3.Size,
                Font = new Font("Segoe UI", 12),
            });
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }
    }
}