namespace ET
{
    partial class ExpenseTracker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpenseTracker));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_view_transactions = new System.Windows.Forms.Button();
            this.btn_add_transactions = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.group_tr_add = new System.Windows.Forms.GroupBox();
            this.fb_tr_add_description = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fb_tr_add_date = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.fb_tr_add_notes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.fb_tr_add_submit = new System.Windows.Forms.Button();
            this.fb_tr_add_recurring = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fb_tr_add_category = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fb_tr_add_type = new System.Windows.Forms.ComboBox();
            this.fb_tr_add_amount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.group_cat_add = new System.Windows.Forms.GroupBox();
            this.btn_cat_update_cancel = new System.Windows.Forms.Button();
            this.cat_id = new System.Windows.Forms.TextBox();
            this.btn_cat_delete = new System.Windows.Forms.Button();
            this.btn_cat_update = new System.Windows.Forms.Button();
            this.cat_data = new System.Windows.Forms.DataGridView();
            this.cat_add_budget = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_cat_add = new System.Windows.Forms.Button();
            this.cat_add_name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.group_setting = new System.Windows.Forms.GroupBox();
            this.btn_manage_categories = new System.Windows.Forms.Button();
            this.btn_about = new System.Windows.Forms.Button();
            this.group_tr_view = new System.Windows.Forms.GroupBox();
            this.tr_data = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.group_tr_edit = new System.Windows.Forms.GroupBox();
            this.fb_tr_edit_description = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_tr_update_cancle = new System.Windows.Forms.Button();
            this.btn_tr_delete = new System.Windows.Forms.Button();
            this.fb_tr_edit_id = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.fb_tr_edit_date = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.fb_tr_edit_notes = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_tr_update = new System.Windows.Forms.Button();
            this.fb_tr_edit_recurring = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.fb_tr_edit_category = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.fb_tr_edit_type = new System.Windows.Forms.ComboBox();
            this.fb_tr_edit_amount = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.group_tr_add.SuspendLayout();
            this.group_cat_add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cat_data)).BeginInit();
            this.group_setting.SuspendLayout();
            this.group_tr_view.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tr_data)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.group_tr_edit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.panel1.Controls.Add(this.btn_settings);
            this.panel1.Controls.Add(this.btn_view_transactions);
            this.panel1.Controls.Add(this.btn_add_transactions);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 448);
            this.panel1.TabIndex = 0;
            // 
            // btn_settings
            // 
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_settings.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_settings.Location = new System.Drawing.Point(12, 203);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(148, 40);
            this.btn_settings.TabIndex = 4;
            this.btn_settings.Text = "SETTINGS";
            this.btn_settings.UseVisualStyleBackColor = false;
            this.btn_settings.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_view_transactions
            // 
            this.btn_view_transactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_view_transactions.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_view_transactions.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_view_transactions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_view_transactions.Location = new System.Drawing.Point(12, 158);
            this.btn_view_transactions.Name = "btn_view_transactions";
            this.btn_view_transactions.Size = new System.Drawing.Size(148, 40);
            this.btn_view_transactions.TabIndex = 2;
            this.btn_view_transactions.Text = "VIEW ALL";
            this.btn_view_transactions.UseVisualStyleBackColor = false;
            this.btn_view_transactions.Click += new System.EventHandler(this.btn_view_transactions_Click);
            // 
            // btn_add_transactions
            // 
            this.btn_add_transactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_transactions.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_add_transactions.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_add_transactions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_transactions.Location = new System.Drawing.Point(12, 112);
            this.btn_add_transactions.Name = "btn_add_transactions";
            this.btn_add_transactions.Size = new System.Drawing.Size(148, 40);
            this.btn_add_transactions.TabIndex = 1;
            this.btn_add_transactions.Text = "ADD NEW";
            this.btn_add_transactions.UseVisualStyleBackColor = false;
            this.btn_add_transactions.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ET.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 78);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // group_tr_add
            // 
            this.group_tr_add.Controls.Add(this.fb_tr_add_description);
            this.group_tr_add.Controls.Add(this.label6);
            this.group_tr_add.Controls.Add(this.fb_tr_add_date);
            this.group_tr_add.Controls.Add(this.label15);
            this.group_tr_add.Controls.Add(this.fb_tr_add_notes);
            this.group_tr_add.Controls.Add(this.label7);
            this.group_tr_add.Controls.Add(this.fb_tr_add_submit);
            this.group_tr_add.Controls.Add(this.fb_tr_add_recurring);
            this.group_tr_add.Controls.Add(this.label4);
            this.group_tr_add.Controls.Add(this.label3);
            this.group_tr_add.Controls.Add(this.fb_tr_add_category);
            this.group_tr_add.Controls.Add(this.label2);
            this.group_tr_add.Controls.Add(this.fb_tr_add_type);
            this.group_tr_add.Controls.Add(this.fb_tr_add_amount);
            this.group_tr_add.Controls.Add(this.label1);
            this.group_tr_add.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.group_tr_add.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.group_tr_add.Location = new System.Drawing.Point(194, 14);
            this.group_tr_add.Name = "group_tr_add";
            this.group_tr_add.Size = new System.Drawing.Size(654, 421);
            this.group_tr_add.TabIndex = 1;
            this.group_tr_add.TabStop = false;
            this.group_tr_add.Text = "Add Transaction";
            this.group_tr_add.Visible = false;
            // 
            // fb_tr_add_description
            // 
            this.fb_tr_add_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fb_tr_add_description.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fb_tr_add_description.Location = new System.Drawing.Point(121, 42);
            this.fb_tr_add_description.Name = "fb_tr_add_description";
            this.fb_tr_add_description.Size = new System.Drawing.Size(505, 25);
            this.fb_tr_add_description.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(22, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Description:";
            // 
            // fb_tr_add_date
            // 
            this.fb_tr_add_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fb_tr_add_date.Location = new System.Drawing.Point(121, 88);
            this.fb_tr_add_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fb_tr_add_date.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.fb_tr_add_date.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.fb_tr_add_date.Name = "fb_tr_add_date";
            this.fb_tr_add_date.Size = new System.Drawing.Size(183, 25);
            this.fb_tr_add_date.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(22, 89);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 19);
            this.label15.TabIndex = 11;
            this.label15.Text = "Date:";
            // 
            // fb_tr_add_notes
            // 
            this.fb_tr_add_notes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fb_tr_add_notes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fb_tr_add_notes.Location = new System.Drawing.Point(121, 187);
            this.fb_tr_add_notes.Multiline = true;
            this.fb_tr_add_notes.Name = "fb_tr_add_notes";
            this.fb_tr_add_notes.Size = new System.Drawing.Size(505, 94);
            this.fb_tr_add_notes.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(22, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Notes:";
            // 
            // fb_tr_add_submit
            // 
            this.fb_tr_add_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.fb_tr_add_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fb_tr_add_submit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fb_tr_add_submit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.fb_tr_add_submit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fb_tr_add_submit.Location = new System.Drawing.Point(479, 338);
            this.fb_tr_add_submit.Name = "fb_tr_add_submit";
            this.fb_tr_add_submit.Size = new System.Drawing.Size(148, 40);
            this.fb_tr_add_submit.TabIndex = 4;
            this.fb_tr_add_submit.Text = "ADD";
            this.fb_tr_add_submit.UseVisualStyleBackColor = false;
            this.fb_tr_add_submit.Click += new System.EventHandler(this.btn_add_tr_Click);
            // 
            // fb_tr_add_recurring
            // 
            this.fb_tr_add_recurring.AutoSize = true;
            this.fb_tr_add_recurring.Location = new System.Drawing.Point(121, 304);
            this.fb_tr_add_recurring.Name = "fb_tr_add_recurring";
            this.fb_tr_add_recurring.Size = new System.Drawing.Size(15, 14);
            this.fb_tr_add_recurring.TabIndex = 8;
            this.fb_tr_add_recurring.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(26, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Recurring:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(348, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Category:";
            // 
            // fb_tr_add_category
            // 
            this.fb_tr_add_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fb_tr_add_category.FormattingEnabled = true;
            this.fb_tr_add_category.Location = new System.Drawing.Point(430, 138);
            this.fb_tr_add_category.Name = "fb_tr_add_category";
            this.fb_tr_add_category.Size = new System.Drawing.Size(196, 25);
            this.fb_tr_add_category.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type:";
            // 
            // fb_tr_add_type
            // 
            this.fb_tr_add_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fb_tr_add_type.FormattingEnabled = true;
            this.fb_tr_add_type.Location = new System.Drawing.Point(121, 138);
            this.fb_tr_add_type.Name = "fb_tr_add_type";
            this.fb_tr_add_type.Size = new System.Drawing.Size(183, 25);
            this.fb_tr_add_type.TabIndex = 2;
            // 
            // fb_tr_add_amount
            // 
            this.fb_tr_add_amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fb_tr_add_amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fb_tr_add_amount.Location = new System.Drawing.Point(430, 89);
            this.fb_tr_add_amount.Name = "fb_tr_add_amount";
            this.fb_tr_add_amount.Size = new System.Drawing.Size(196, 25);
            this.fb_tr_add_amount.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(348, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount:";
            // 
            // group_cat_add
            // 
            this.group_cat_add.Controls.Add(this.btn_cat_update_cancel);
            this.group_cat_add.Controls.Add(this.cat_id);
            this.group_cat_add.Controls.Add(this.btn_cat_delete);
            this.group_cat_add.Controls.Add(this.btn_cat_update);
            this.group_cat_add.Controls.Add(this.cat_data);
            this.group_cat_add.Controls.Add(this.cat_add_budget);
            this.group_cat_add.Controls.Add(this.label5);
            this.group_cat_add.Controls.Add(this.btn_cat_add);
            this.group_cat_add.Controls.Add(this.cat_add_name);
            this.group_cat_add.Controls.Add(this.label8);
            this.group_cat_add.Cursor = System.Windows.Forms.Cursors.Default;
            this.group_cat_add.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.group_cat_add.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.group_cat_add.Location = new System.Drawing.Point(194, 10);
            this.group_cat_add.Name = "group_cat_add";
            this.group_cat_add.Size = new System.Drawing.Size(654, 421);
            this.group_cat_add.TabIndex = 3;
            this.group_cat_add.TabStop = false;
            this.group_cat_add.Text = "Manage Categories";
            this.group_cat_add.Visible = false;
            // 
            // btn_cat_update_cancel
            // 
            this.btn_cat_update_cancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cat_update_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cat_update_cancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cat_update_cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_cat_update_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cat_update_cancel.Location = new System.Drawing.Point(266, 135);
            this.btn_cat_update_cancel.Name = "btn_cat_update_cancel";
            this.btn_cat_update_cancel.Size = new System.Drawing.Size(82, 32);
            this.btn_cat_update_cancel.TabIndex = 13;
            this.btn_cat_update_cancel.Text = "CANCEL";
            this.btn_cat_update_cancel.UseVisualStyleBackColor = false;
            this.btn_cat_update_cancel.Visible = false;
            this.btn_cat_update_cancel.Click += new System.EventHandler(this.btn_cat_update_cancel_Click);
            // 
            // cat_id
            // 
            this.cat_id.Location = new System.Drawing.Point(527, 54);
            this.cat_id.Name = "cat_id";
            this.cat_id.ReadOnly = true;
            this.cat_id.Size = new System.Drawing.Size(100, 25);
            this.cat_id.TabIndex = 12;
            this.cat_id.Visible = false;
            // 
            // btn_cat_delete
            // 
            this.btn_cat_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.btn_cat_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cat_delete.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cat_delete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cat_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cat_delete.Location = new System.Drawing.Point(178, 135);
            this.btn_cat_delete.Name = "btn_cat_delete";
            this.btn_cat_delete.Size = new System.Drawing.Size(82, 32);
            this.btn_cat_delete.TabIndex = 11;
            this.btn_cat_delete.Text = "DELETE";
            this.btn_cat_delete.UseVisualStyleBackColor = false;
            this.btn_cat_delete.Visible = false;
            this.btn_cat_delete.Click += new System.EventHandler(this.btn_cat_delete_Click);
            // 
            // btn_cat_update
            // 
            this.btn_cat_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.btn_cat_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cat_update.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cat_update.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cat_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cat_update.Location = new System.Drawing.Point(90, 135);
            this.btn_cat_update.Name = "btn_cat_update";
            this.btn_cat_update.Size = new System.Drawing.Size(82, 32);
            this.btn_cat_update.TabIndex = 10;
            this.btn_cat_update.Text = "UPDATE";
            this.btn_cat_update.UseVisualStyleBackColor = false;
            this.btn_cat_update.Visible = false;
            this.btn_cat_update.Click += new System.EventHandler(this.btn_cat_update_Click);
            // 
            // cat_data
            // 
            this.cat_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cat_data.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.cat_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cat_data.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.cat_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cat_data.Location = new System.Drawing.Point(6, 195);
            this.cat_data.Name = "cat_data";
            this.cat_data.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.cat_data.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.cat_data.RowTemplate.Height = 25;
            this.cat_data.Size = new System.Drawing.Size(642, 219);
            this.cat_data.TabIndex = 9;
            this.cat_data.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cat_data_CellDoubleClick);
            // 
            // cat_add_budget
            // 
            this.cat_add_budget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cat_add_budget.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cat_add_budget.Location = new System.Drawing.Point(90, 90);
            this.cat_add_budget.Name = "cat_add_budget";
            this.cat_add_budget.Size = new System.Drawing.Size(258, 25);
            this.cat_add_budget.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(26, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Budget:";
            // 
            // btn_cat_add
            // 
            this.btn_cat_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.btn_cat_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cat_add.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cat_add.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cat_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cat_add.Location = new System.Drawing.Point(90, 135);
            this.btn_cat_add.Name = "btn_cat_add";
            this.btn_cat_add.Size = new System.Drawing.Size(82, 32);
            this.btn_cat_add.TabIndex = 4;
            this.btn_cat_add.Text = "ADD";
            this.btn_cat_add.UseVisualStyleBackColor = false;
            this.btn_cat_add.Click += new System.EventHandler(this.btn_cat_add_Click);
            // 
            // cat_add_name
            // 
            this.cat_add_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cat_add_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cat_add_name.Location = new System.Drawing.Point(90, 54);
            this.cat_add_name.Name = "cat_add_name";
            this.cat_add_name.Size = new System.Drawing.Size(258, 25);
            this.cat_add_name.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(26, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Name:";
            // 
            // group_setting
            // 
            this.group_setting.Controls.Add(this.btn_manage_categories);
            this.group_setting.Controls.Add(this.btn_about);
            this.group_setting.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.group_setting.Location = new System.Drawing.Point(194, 10);
            this.group_setting.Name = "group_setting";
            this.group_setting.Size = new System.Drawing.Size(654, 421);
            this.group_setting.TabIndex = 2;
            this.group_setting.TabStop = false;
            this.group_setting.Text = "Settings";
            this.group_setting.Visible = false;
            // 
            // btn_manage_categories
            // 
            this.btn_manage_categories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.btn_manage_categories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_manage_categories.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_manage_categories.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_manage_categories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_manage_categories.Location = new System.Drawing.Point(29, 46);
            this.btn_manage_categories.Name = "btn_manage_categories";
            this.btn_manage_categories.Size = new System.Drawing.Size(120, 112);
            this.btn_manage_categories.TabIndex = 7;
            this.btn_manage_categories.Text = "MANAGE CATEGORIES";
            this.btn_manage_categories.UseVisualStyleBackColor = false;
            this.btn_manage_categories.Click += new System.EventHandler(this.button9_Click);
            // 
            // btn_about
            // 
            this.btn_about.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.btn_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_about.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_about.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_about.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_about.Location = new System.Drawing.Point(172, 48);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(118, 111);
            this.btn_about.TabIndex = 6;
            this.btn_about.Text = "ABOUT";
            this.btn_about.UseVisualStyleBackColor = false;
            // 
            // group_tr_view
            // 
            this.group_tr_view.Controls.Add(this.tr_data);
            this.group_tr_view.Controls.Add(this.groupBox1);
            this.group_tr_view.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.group_tr_view.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.group_tr_view.Location = new System.Drawing.Point(194, 10);
            this.group_tr_view.Name = "group_tr_view";
            this.group_tr_view.Size = new System.Drawing.Size(654, 428);
            this.group_tr_view.TabIndex = 4;
            this.group_tr_view.TabStop = false;
            this.group_tr_view.Text = "Transactions";
            this.group_tr_view.Visible = false;
            // 
            // tr_data
            // 
            this.tr_data.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.tr_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tr_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tr_data.Location = new System.Drawing.Point(6, 102);
            this.tr_data.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tr_data.Name = "tr_data";
            this.tr_data.RowHeadersWidth = 51;
            this.tr_data.RowTemplate.Height = 29;
            this.tr_data.Size = new System.Drawing.Size(642, 318);
            this.tr_data.TabIndex = 0;
            this.tr_data.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tr_data_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Location = new System.Drawing.Point(6, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(642, 68);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(25, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(74, 27);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(105, 25);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(231, 27);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(133, 25);
            this.comboBox3.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(183, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 19);
            this.label11.TabIndex = 14;
            this.label11.Text = "Type:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(372, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 19);
            this.label10.TabIndex = 16;
            this.label10.Text = "Category:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(450, 26);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(138, 25);
            this.comboBox2.TabIndex = 15;
            // 
            // group_tr_edit
            // 
            this.group_tr_edit.Controls.Add(this.fb_tr_edit_description);
            this.group_tr_edit.Controls.Add(this.label12);
            this.group_tr_edit.Controls.Add(this.btn_tr_update_cancle);
            this.group_tr_edit.Controls.Add(this.btn_tr_delete);
            this.group_tr_edit.Controls.Add(this.fb_tr_edit_id);
            this.group_tr_edit.Controls.Add(this.label14);
            this.group_tr_edit.Controls.Add(this.fb_tr_edit_date);
            this.group_tr_edit.Controls.Add(this.label16);
            this.group_tr_edit.Controls.Add(this.fb_tr_edit_notes);
            this.group_tr_edit.Controls.Add(this.label17);
            this.group_tr_edit.Controls.Add(this.btn_tr_update);
            this.group_tr_edit.Controls.Add(this.fb_tr_edit_recurring);
            this.group_tr_edit.Controls.Add(this.label18);
            this.group_tr_edit.Controls.Add(this.label19);
            this.group_tr_edit.Controls.Add(this.fb_tr_edit_category);
            this.group_tr_edit.Controls.Add(this.label20);
            this.group_tr_edit.Controls.Add(this.fb_tr_edit_type);
            this.group_tr_edit.Controls.Add(this.fb_tr_edit_amount);
            this.group_tr_edit.Controls.Add(this.label21);
            this.group_tr_edit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.group_tr_edit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.group_tr_edit.Location = new System.Drawing.Point(194, 14);
            this.group_tr_edit.Name = "group_tr_edit";
            this.group_tr_edit.Size = new System.Drawing.Size(654, 421);
            this.group_tr_edit.TabIndex = 6;
            this.group_tr_edit.TabStop = false;
            this.group_tr_edit.Text = "Edit Transaction";
            this.group_tr_edit.Visible = false;
            // 
            // fb_tr_edit_description
            // 
            this.fb_tr_edit_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fb_tr_edit_description.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fb_tr_edit_description.Location = new System.Drawing.Point(120, 42);
            this.fb_tr_edit_description.Name = "fb_tr_edit_description";
            this.fb_tr_edit_description.Size = new System.Drawing.Size(196, 25);
            this.fb_tr_edit_description.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(22, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 19);
            this.label12.TabIndex = 19;
            this.label12.Text = "Description:";
            // 
            // btn_tr_update_cancle
            // 
            this.btn_tr_update_cancle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_tr_update_cancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tr_update_cancle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_tr_update_cancle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.btn_tr_update_cancle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tr_update_cancle.Location = new System.Drawing.Point(527, 342);
            this.btn_tr_update_cancle.Name = "btn_tr_update_cancle";
            this.btn_tr_update_cancle.Size = new System.Drawing.Size(100, 40);
            this.btn_tr_update_cancle.TabIndex = 18;
            this.btn_tr_update_cancle.Text = "CANCLE";
            this.btn_tr_update_cancle.UseVisualStyleBackColor = false;
            this.btn_tr_update_cancle.Click += new System.EventHandler(this.btn_tr_update_cancle_Click);
            // 
            // btn_tr_delete
            // 
            this.btn_tr_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.btn_tr_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tr_delete.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_tr_delete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_tr_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tr_delete.Location = new System.Drawing.Point(421, 342);
            this.btn_tr_delete.Name = "btn_tr_delete";
            this.btn_tr_delete.Size = new System.Drawing.Size(100, 40);
            this.btn_tr_delete.TabIndex = 17;
            this.btn_tr_delete.Text = "DELETE";
            this.btn_tr_delete.UseVisualStyleBackColor = false;
            this.btn_tr_delete.Click += new System.EventHandler(this.btn_tr_delete_Click);
            // 
            // fb_tr_edit_id
            // 
            this.fb_tr_edit_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fb_tr_edit_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fb_tr_edit_id.Location = new System.Drawing.Point(431, 42);
            this.fb_tr_edit_id.Name = "fb_tr_edit_id";
            this.fb_tr_edit_id.ReadOnly = true;
            this.fb_tr_edit_id.Size = new System.Drawing.Size(196, 25);
            this.fb_tr_edit_id.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(345, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 19);
            this.label14.TabIndex = 14;
            this.label14.Text = "ID:";
            // 
            // fb_tr_edit_date
            // 
            this.fb_tr_edit_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fb_tr_edit_date.Location = new System.Drawing.Point(120, 92);
            this.fb_tr_edit_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fb_tr_edit_date.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.fb_tr_edit_date.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.fb_tr_edit_date.Name = "fb_tr_edit_date";
            this.fb_tr_edit_date.Size = new System.Drawing.Size(196, 25);
            this.fb_tr_edit_date.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(22, 93);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 19);
            this.label16.TabIndex = 11;
            this.label16.Text = "Date:";
            // 
            // fb_tr_edit_notes
            // 
            this.fb_tr_edit_notes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fb_tr_edit_notes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fb_tr_edit_notes.Location = new System.Drawing.Point(120, 191);
            this.fb_tr_edit_notes.Multiline = true;
            this.fb_tr_edit_notes.Name = "fb_tr_edit_notes";
            this.fb_tr_edit_notes.Size = new System.Drawing.Size(506, 94);
            this.fb_tr_edit_notes.TabIndex = 10;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(22, 189);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 19);
            this.label17.TabIndex = 9;
            this.label17.Text = "Notes:";
            // 
            // btn_tr_update
            // 
            this.btn_tr_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.btn_tr_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tr_update.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_tr_update.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_tr_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tr_update.Location = new System.Drawing.Point(316, 342);
            this.btn_tr_update.Name = "btn_tr_update";
            this.btn_tr_update.Size = new System.Drawing.Size(100, 40);
            this.btn_tr_update.TabIndex = 4;
            this.btn_tr_update.Text = "UPDATE";
            this.btn_tr_update.UseVisualStyleBackColor = false;
            this.btn_tr_update.Click += new System.EventHandler(this.btn_tr_update_Click);
            // 
            // fb_tr_edit_recurring
            // 
            this.fb_tr_edit_recurring.AutoSize = true;
            this.fb_tr_edit_recurring.Location = new System.Drawing.Point(108, 308);
            this.fb_tr_edit_recurring.Name = "fb_tr_edit_recurring";
            this.fb_tr_edit_recurring.Size = new System.Drawing.Size(15, 14);
            this.fb_tr_edit_recurring.TabIndex = 8;
            this.fb_tr_edit_recurring.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(26, 304);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 19);
            this.label18.TabIndex = 7;
            this.label18.Text = "Recurring:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(348, 144);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(68, 19);
            this.label19.TabIndex = 5;
            this.label19.Text = "Category:";
            // 
            // fb_tr_edit_category
            // 
            this.fb_tr_edit_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fb_tr_edit_category.FormattingEnabled = true;
            this.fb_tr_edit_category.Location = new System.Drawing.Point(430, 142);
            this.fb_tr_edit_category.Name = "fb_tr_edit_category";
            this.fb_tr_edit_category.Size = new System.Drawing.Size(196, 25);
            this.fb_tr_edit_category.TabIndex = 4;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(22, 145);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 19);
            this.label20.TabIndex = 3;
            this.label20.Text = "Type:";
            // 
            // fb_tr_edit_type
            // 
            this.fb_tr_edit_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fb_tr_edit_type.FormattingEnabled = true;
            this.fb_tr_edit_type.Location = new System.Drawing.Point(120, 142);
            this.fb_tr_edit_type.Name = "fb_tr_edit_type";
            this.fb_tr_edit_type.Size = new System.Drawing.Size(196, 25);
            this.fb_tr_edit_type.TabIndex = 2;
            // 
            // fb_tr_edit_amount
            // 
            this.fb_tr_edit_amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fb_tr_edit_amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fb_tr_edit_amount.Location = new System.Drawing.Point(430, 93);
            this.fb_tr_edit_amount.Name = "fb_tr_edit_amount";
            this.fb_tr_edit_amount.Size = new System.Drawing.Size(196, 25);
            this.fb_tr_edit_amount.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(348, 96);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(62, 19);
            this.label21.TabIndex = 0;
            this.label21.Text = "Amount:";
            // 
            // ExpenseTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(870, 448);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.group_tr_view);
            this.Controls.Add(this.group_cat_add);
            this.Controls.Add(this.group_setting);
            this.Controls.Add(this.group_tr_add);
            this.Controls.Add(this.group_tr_edit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ExpenseTracker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expense Tracker";
            this.Load += new System.EventHandler(this.ExpenseTracker_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.group_tr_add.ResumeLayout(false);
            this.group_tr_add.PerformLayout();
            this.group_cat_add.ResumeLayout(false);
            this.group_cat_add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cat_data)).EndInit();
            this.group_setting.ResumeLayout(false);
            this.group_tr_view.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tr_data)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.group_tr_edit.ResumeLayout(false);
            this.group_tr_edit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btn_add_transactions;
        private PictureBox pictureBox1;
        private Button btn_view_transactions;
        private GroupBox group_tr_add;
        private Label label1;
        private TextBox fb_tr_add_amount;
        private Label label2;
        private ComboBox fb_tr_add_type;
        private Label label3;
        private ComboBox fb_tr_add_category;
        private CheckBox fb_tr_add_recurring;
        private Label label4;
        private Button fb_tr_add_submit;
        private Button btn_settings;
        private GroupBox group_setting;
        private Button btn_manage_categories;
        private Button btn_about;
        private GroupBox group_cat_add;
        private TextBox cat_add_budget;
        private Label label5;
        private Button btn_cat_add;
        private TextBox cat_add_name;
        private Label label8;
        private GroupBox group_tr_view;
        private DataGridView tr_data;
        private TextBox fb_tr_add_notes;
        private Label label7;
        private DateTimePicker fb_tr_add_date;
        private Label label15;
        private GroupBox group_tr_edit;
        private DateTimePicker fb_tr_edit_date;
        private Label label16;
        private TextBox fb_tr_edit_notes;
        private Label label17;
        private Button btn_tr_update;
        private CheckBox fb_tr_edit_recurring;
        private Label label18;
        private Label label19;
        private ComboBox fb_tr_edit_category;
        private Label label20;
        private ComboBox fb_tr_edit_type;
        private TextBox fb_tr_edit_amount;
        private Label label21;
        private TextBox fb_tr_edit_id;
        private Label label14;
        private DateTimePicker dateTimePicker1;
        private Label label9;
        private Label label10;
        private ComboBox comboBox2;
        private Label label11;
        private ComboBox comboBox3;
        private GroupBox groupBox1;
        private Button btn_cat_delete;
        private Button btn_cat_update;
        private DataGridView cat_data;
        private TextBox cat_id;
        private Button btn_cat_update_cancel;
        private Button btn_tr_update_cancle;
        private Button btn_tr_delete;
        private TextBox fb_tr_add_description;
        private Label label6;
        private TextBox fb_tr_edit_description;
        private Label label12;
    }
}