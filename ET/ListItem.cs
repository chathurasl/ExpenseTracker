using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ET
{
    public partial class ListItem : UserControl
    {
        public ListItem()
        {
            InitializeComponent();
        }

        private string _desc;
        private string _notes;
        private string _date;
        private string _amount;
        private string _category;
        private string _type;
        private bool _recurrence;

        public string Desc { get { return _desc; } set { _desc = value;  lbl_desc.Text = value; } }
        public string Notes { get { return _notes; } set { _notes = value;  lbl_note.Text = value;  } }
        public string Date { get { return _date; } set { _date = value; lbl_date.Text = value;  } }
        public string Amount { get { return _amount; } set { _amount = value; lbl_amount.Text = value; } }
        public string Category { get { return _category; } set { _category = value; lbl_category.Text = value; } }
        public string Type { get { return _type; } set { _type = value; } }
        public bool Recurrence { get { return _recurrence; } set { _recurrence = value; } }
        private void ListItem_Load(object sender, EventArgs e)
        {
            lbl_amount.ForeColor = (_type == "Income") ? Color.FromArgb(183, 28, 28) : Color.FromArgb(27, 94, 32);
            if (_recurrence == true) {
                rec_icon.Show();
            }
            else
            {
                rec_icon.Hide();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

        }

        private void lbl_category_Click(object sender, EventArgs e)
        {

        }
    }
}
