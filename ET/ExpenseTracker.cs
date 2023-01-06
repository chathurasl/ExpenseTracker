using System.Data;
using System.Windows.Forms;
using System.Drawing;


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

        int trId = 1000;
        double amount;
        string date;
        string type;
        string category;
        string recurring;
        string notes;


        public ExpenseTracker()
        {
            InitializeComponent();
            incomeFactory = new IncomeFactory(currentTransactions);
            expenseFactory = new ExpenseFactory();
        }


        static void Main()
        {

            // ExpenseTracker ET = new ExpenseTracker();


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new ExpenseTracker());







            //

            // 
        }


        public void hidePanels()
        {
            group_tr_add.Hide();
            // group_tr_list.Hide();
            group_setting.Hide();
            group_cat_add.Hide();
            group_tr_view.Hide();
            group_tr_edit.Hide();
        }

        public void fillCategoryData()
        {

            fb_tr_add_category.Items.Clear();
            fb_tr_edit_category.Items.Clear();
            catData.Rows.Clear();


            fb_tr_add_category.DisplayMember = "Text";
            fb_tr_add_category.ValueMember = "Value";

            foreach (Category currCat in categoryFactory.getCategories())
            {
                // fb_tr_add_category.Items.Add(currCat.getCategoryName());
                fb_tr_add_category.Items.Add(new { Text = currCat.getCategoryName(), Value = currCat.getId() });
                fb_tr_edit_category.Items.Add(new { Text = currCat.getCategoryName(), Value = currCat.getId() });

                DataRow catRow = catData.NewRow();
                catRow[0] = currCat.getId(); ;
                catRow[1] = currCat.getCategoryName();
                catRow[2] = currCat.getBudget();

                catData.Rows.Add(catRow);
                cat_data.DataSource = catData;
            }

        }


        public void fillTransactionData(){

            foreach (Transaction currTr in currentTransactions)
            {
                DataRow dr = dt.NewRow();
                dr[0] = currTr.getId();
                dr[1] = currTr.getDate();
                dr[2] = currTr.getAmount();
                dr[3] = type;
                dr[4] = currTr.getCategroyId();
                dr[5] = currTr.getRecurrence();
                dr[6] = currTr.getDescription();

                dt.Rows.Add(dr);
                tr_data.DataSource = dt;
            }
              
          
        }
        
        
        public void fillTransactionTypes()
        {

            fb_tr_add_type.Items.Add("Income");
            fb_tr_add_type.Items.Add("Expense");

            fb_tr_edit_type.Items.Add("Income");
            fb_tr_edit_type.Items.Add("Expense");

        }

        private void ExpenseTracker_Load(object sender, EventArgs e)
        {

            //ExpenseTracker ET = new ExpenseTracker();




            //Data view columns
            dt.Columns.Add("ID");
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


            /* DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();

             btnColumn.DataPropertyName = "id";

             btnColumn.Width = 50;
             btnColumn.Text = "Delete";

             btnColumn.ReadOnly = true;

             tr_data.Columns.Add(btnColumn);*/





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

        private void group_tr_add_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_add_tr_Click(object sender, EventArgs e)
        {
            string mzg = "";
            double currAmount;

            if (!Double.TryParse(fb_tr_add_amount.Text, out currAmount))
            {
                mzg = "Please enter valid Amount";
            }else if (fb_tr_add_type.Text == "")
            {
                mzg = "Please select a Type";
            }
            else if (fb_tr_add_category.Text == "")
            {
                mzg = "Please select a Category";
            }


            if (mzg != "")
            {
                MessageBox.Show(mzg, "Add Transaction");
            }
            else
            {
                amount = currAmount;
                date = fb_tr_add_date.Text;
                type = fb_tr_add_type.Text;
                category = fb_tr_add_category.Text;
                notes = fb_tr_add_notes.Text;
                recurring = (fb_tr_add_recurring.Checked) ? "Yes" : "No";

              //  setAddTr();
                resetAddTr();
                int catKey = (fb_tr_add_category.SelectedItem as dynamic).Value;


               // MessageBox.Show(catKey);
                bool response = false;
                int id = (int) DateTime.Now.ToFileTime();
               // int catKey = int.Parse(((KeyValuePair<int, string>)fb_tr_add_category.SelectedItem).Value);

              

                if (type == "Income")
                {

                   
                    Transaction tempIncome = new Income(id, amount, fb_tr_add_recurring.Checked, fb_tr_add_date.Value, notes, catKey);
                     response = incomeFactory.createTransaction(tempIncome);
                   
                   
                }
               
                if (response)
                {
                    MessageBox.Show(currentTransactions.Count().ToString());
                    //Show Transaction Data;
                    fillTransactionData();
                }
            }

        }

        public void setAddTr()
        {

            trId = trId + 1;
            DataRow dr = dt.NewRow();
            dr[0] = trId;
            dr[1] = date;
            dr[2] = amount;
            dr[3] = type;
            dr[4] = category;
            dr[5] = recurring;
            dr[6] = notes;



            dt.Rows.Add(dr);
            tr_data.DataSource = dt;

         


            MessageBox.Show("Transaction successfully added.", "Add Transaction");
        }


        public void resetAddTr()
        {

            fb_tr_add_amount.Text = "";
            fb_tr_add_date.Text = "";
            fb_tr_add_type.Text = "";
            fb_tr_add_category.Text = "";
            fb_tr_add_notes.Text = "";
            fb_tr_add_recurring.Checked = false;

            fb_tr_add_type.SelectedIndex = 0;
            fb_tr_add_category.SelectedIndex = 0;

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



        private void tr_data_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //int id = int.Parse(tr_data.Rows[e.RowIndex].Cells[0].Value.ToString());

            fb_tr_edit_index.Text = e.RowIndex.ToString();
            fb_tr_edit_id.Text = tr_data.Rows[e.RowIndex].Cells[0].Value.ToString();
            fb_tr_edit_date.Text = tr_data.Rows[e.RowIndex].Cells[1].Value.ToString();
            fb_tr_edit_amount.Text = tr_data.Rows[e.RowIndex].Cells[2].Value.ToString();
            fb_tr_edit_type.Text = tr_data.Rows[e.RowIndex].Cells[3].Value.ToString();
            fb_tr_edit_category.Text = tr_data.Rows[e.RowIndex].Cells[4].Value.ToString();
            fb_tr_edit_notes.Text = tr_data.Rows[e.RowIndex].Cells[6].Value.ToString();
            fb_tr_edit_recurring.Checked = false;

            if (tr_data.Rows[e.RowIndex].Cells[5].Value.ToString() == "Yes")
            {
                fb_tr_edit_recurring.Checked = true;
            }

            hidePanels();
            group_tr_edit.Show();
        }

        private void tr_edit_submit_Click(object sender, EventArgs e)
        {
            int index = int.Parse(fb_tr_edit_index.Text);
            tr_data.Rows[index].Cells[0].Value = fb_tr_edit_id.Text;
            tr_data.Rows[index].Cells[1].Value = fb_tr_edit_date.Text;
            tr_data.Rows[index].Cells[2].Value = fb_tr_edit_amount.Text;
            tr_data.Rows[index].Cells[3].Value = fb_tr_edit_type.Text;
            tr_data.Rows[index].Cells[4].Value = fb_tr_edit_category.Text;
            tr_data.Rows[index].Cells[6].Value = fb_tr_edit_notes.Text;
            tr_data.Rows[index].Cells[5].Value = (fb_tr_edit_recurring.Checked) ? "Yes" : "No";

            MessageBox.Show("Transaction successfully updated.", "Update Transaction");

        }

        private void button8_Click(object sender, EventArgs e)
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
                MessageBox.Show(mzg, "Add Category");
            }
            else
            {
                bool response = categoryFactory.addCategory(cat_add_name.Text, currBudget);
                if (response)
                {
                    //RE-fill category dropdowns.
                    fillCategoryData();
                }
            }
            
           
        }

        private void cat_data_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cat_id.Text = cat_data.Rows[e.RowIndex].Cells[0].Value.ToString();
            cat_add_name.Text = cat_data.Rows[e.RowIndex].Cells[1].Value.ToString();
            cat_add_budget.Text = cat_data.Rows[e.RowIndex].Cells[2].Value.ToString();

            btn_cat_add.Hide();
            btn_cat_update.Show();
            btn_cat_delete.Show();
            btn_cat_update_cancel.Show();
        }

        private void button3_Click(object sender, EventArgs e)
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
                MessageBox.Show(mzg, "Update Category");
            }
            else
            {
                bool response = categoryFactory.updateCategory(int.Parse(cat_id.Text), cat_add_name.Text, currBudget);
                if (response)
                {
                    //RE-fill category dropdowns.
                    fillCategoryData();

                    //Reset category form data.
                    resetCategroyForm();
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
            var confirmResult = MessageBox.Show("Are you sure you want to delete this category?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                bool response = categoryFactory.deleteCategory(int.Parse(cat_id.Text));
                if (response)
                {
                    //RE-fill category dropdowns.
                    fillCategoryData();

                    //Reset category form data.
                    resetCategroyForm();
                }
            }

        }
    }
}