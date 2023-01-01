using System.Data;
using System.Windows.Forms;
using System.Drawing;


namespace ET
{
    public partial class ExpenseTracker : Form
    {

       // private Dictionary<int, Category> currentCategories = new Dictionary<int, Category>();
        DataTable dt = new DataTable();
        DataTable catData = new DataTable();

        CategoryFactory categoryFactory = new CategoryFactory();

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

            foreach (Category currCat in categoryFactory.getCategories())
            {
                fb_tr_add_category.Items.Add(currCat.getCategoryName());
                fb_tr_edit_category.Items.Add(currCat.getCategoryName());

                DataRow catRow = catData.NewRow();
                catRow[0] = currCat.getId(); ;
                catRow[1] = currCat.getCategoryName();
                catRow[2] = currCat.getBudget();

                catData.Rows.Add(catRow);
                cat_data.DataSource = catData;
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

                setAddTr();
                resetAddTr();
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

            /* // Add a button column. 
             DataGridViewButtonColumn buttonColumn =  new DataGridViewButtonColumn();
             buttonColumn.HeaderText = "";
             buttonColumn.Name = "Status Request";
             buttonColumn.Text = "Request Status";
             buttonColumn.UseColumnTextForButtonValue = true;


             tr_data.Columns.Add(buttonColumn);*/

            //dr[7] = buttonColumn;


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
    }
}