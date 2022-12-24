namespace ExpenseTracker
{
    partial class TransactionView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.fb_recurring = new System.Windows.Forms.CheckBox();
            this.fb_category = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fb_type = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fb_amount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.fb_recurring);
            this.groupBox1.Controls.Add(this.fb_category);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.fb_type);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.fb_amount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 284);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Transaction";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(109)))), ((int)(((byte)(133)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(188, 220);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 44);
            this.button2.TabIndex = 9;
            this.button2.Text = "ADD";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Recurring:";
            // 
            // fb_recurring
            // 
            this.fb_recurring.AutoSize = true;
            this.fb_recurring.Location = new System.Drawing.Point(92, 179);
            this.fb_recurring.Name = "fb_recurring";
            this.fb_recurring.Size = new System.Drawing.Size(15, 14);
            this.fb_recurring.TabIndex = 6;
            this.fb_recurring.UseVisualStyleBackColor = true;
            this.fb_recurring.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // fb_category
            // 
            this.fb_category.Location = new System.Drawing.Point(92, 126);
            this.fb_category.Multiline = true;
            this.fb_category.Name = "fb_category";
            this.fb_category.Size = new System.Drawing.Size(220, 29);
            this.fb_category.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Category:";
            // 
            // fb_type
            // 
            this.fb_type.Location = new System.Drawing.Point(92, 80);
            this.fb_type.Multiline = true;
            this.fb_type.Name = "fb_type";
            this.fb_type.Size = new System.Drawing.Size(220, 29);
            this.fb_type.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type:";
            // 
            // fb_amount
            // 
            this.fb_amount.Location = new System.Drawing.Point(92, 33);
            this.fb_amount.Multiline = true;
            this.fb_amount.Name = "fb_amount";
            this.fb_amount.Size = new System.Drawing.Size(220, 29);
            this.fb_amount.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount:";
            // 
            // TransactionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 308);
            this.Controls.Add(this.groupBox1);
            this.Name = "TransactionView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Transaction";
            this.Load += new System.EventHandler(this.TransactionView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox fb_recurring;
        private System.Windows.Forms.TextBox fb_category;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fb_type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fb_amount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}