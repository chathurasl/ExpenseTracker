using System.Data;

namespace ET
{
    public partial class ExpenseTracker : Form
    {

        DataTable dt = new DataTable();

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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new ExpenseTracker());
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

        private void ExpenseTracker_Load(object sender, EventArgs e)
        {
            cb_type.Items.Add("Income");
            cb_type.Items.Add("Expense");

            cb_category.Items.Add("Salary");
            cb_category.Items.Add("Shopping");
            cb_category.Items.Add("Food");
            cb_category.Items.Add("Fuel");
            cb_category.Items.Add("Other");


            //Data view columns
            dt.Columns.Add("ID");
            dt.Columns.Add("Date");
            dt.Columns.Add("Amount");
            dt.Columns.Add("Type");
            dt.Columns.Add("Category");
            dt.Columns.Add("Recurring");
            dt.Columns.Add("Notes");

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

            if (!Double.TryParse(fb_amount.Text, out currAmount))
            {
                mzg = "Please enter valid Amount";
            }else if (cb_type.Text == "")
            {
                mzg = "Please select a Type";
            }
            else if (cb_category.Text == "")
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
                date = fb_date.Text;
                type = cb_type.Text;
                category = cb_category.Text;
                notes = fb_notes.Text;
                recurring = (cb_recurring.Checked) ? "Yes" : "No";

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

            MessageBox.Show("Transaction successfully added.", "Add Transaction");
        }


        public void resetAddTr()
        {

            fb_amount.Text = "";
            fb_date.Text = "";
            cb_type.Text = "";
            cb_category.Text = "";
            cb_recurring.Checked = false;

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

    
    }
}