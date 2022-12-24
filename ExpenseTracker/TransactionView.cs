using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class TransactionView : Form
    {
        public TransactionView()
        {
            InitializeComponent();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // this.Hide();
            string message = "Data saved!";
            string title = "Title";
            MessageBox.Show(message, title);

            string amount = fb_amount.Text;
            string type = fb_type.Text;
            string category = fb_category.Text;
            string recurring = (fb_recurring.Checked) ? "Yes" : "No";
        }

        private void TransactionView_Load(object sender, EventArgs e)
        {

        }
    }
}
