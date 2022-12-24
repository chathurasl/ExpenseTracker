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
    public partial class Form1 : Form
    {

        TransactionView addTR = new TransactionView();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!addTR)
            {
                addTR = new TransactionView();
            }
 

            if (!addTR.Visible)
            {
                addTR.Show();
            }
            else
            {
                addTR.BringToFront();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
