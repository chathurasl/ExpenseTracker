namespace ET
{
    partial class ListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_desc = new System.Windows.Forms.Label();
            this.lbl_note = new System.Windows.Forms.Label();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.lbl_date = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_category = new System.Windows.Forms.Label();
            this.rec_icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.rec_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_desc
            // 
            this.lbl_desc.AutoEllipsis = true;
            this.lbl_desc.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.lbl_desc.Location = new System.Drawing.Point(6, 3);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(241, 23);
            this.lbl_desc.TabIndex = 0;
            this.lbl_desc.Text = "Sample Description";
            // 
            // lbl_note
            // 
            this.lbl_note.AutoEllipsis = true;
            this.lbl_note.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_note.Location = new System.Drawing.Point(6, 20);
            this.lbl_note.Name = "lbl_note";
            this.lbl_note.Size = new System.Drawing.Size(241, 23);
            this.lbl_note.TabIndex = 1;
            this.lbl_note.Text = "Note here long content ";
            // 
            // lbl_amount
            // 
            this.lbl_amount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_amount.Location = new System.Drawing.Point(352, 10);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(165, 30);
            this.lbl_amount.TabIndex = 2;
            this.lbl_amount.Text = "LKR 124,789";
            this.lbl_amount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.btn_edit.BackgroundImage = global::ET.Properties.Resources.edit1;
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_edit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_edit.Location = new System.Drawing.Point(560, 12);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(29, 30);
            this.btn_edit.TabIndex = 3;
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // lbl_date
            // 
            this.lbl_date.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_date.Location = new System.Drawing.Point(7, 35);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(100, 18);
            this.lbl_date.TabIndex = 4;
            this.lbl_date.Text = "2023/01/13";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.btn_delete.BackgroundImage = global::ET.Properties.Resources.remove;
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_delete.Location = new System.Drawing.Point(594, 12);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(30, 30);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // lbl_category
            // 
            this.lbl_category.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.lbl_category.Location = new System.Drawing.Point(264, 16);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(85, 19);
            this.lbl_category.TabIndex = 6;
            this.lbl_category.Text = "Shopping";
            this.lbl_category.Click += new System.EventHandler(this.lbl_category_Click);
            // 
            // rec_icon
            // 
            this.rec_icon.BackgroundImage = global::ET.Properties.Resources.recurring;
            this.rec_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rec_icon.Location = new System.Drawing.Point(522, 16);
            this.rec_icon.Name = "rec_icon";
            this.rec_icon.Size = new System.Drawing.Size(22, 23);
            this.rec_icon.TabIndex = 7;
            this.rec_icon.TabStop = false;
            this.rec_icon.Visible = false;
            // 
            // ListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.rec_icon);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.lbl_amount);
            this.Controls.Add(this.lbl_note);
            this.Controls.Add(this.lbl_desc);
            this.Name = "ListItem";
            this.Size = new System.Drawing.Size(637, 51);
            this.Load += new System.EventHandler(this.ListItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rec_icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lbl_desc;
        private Label lbl_note;
        private Label lbl_amount;
        private Button btn_edit;
        private Label lbl_date;
        private Button btn_delete;
        private Label lbl_category;
        private PictureBox rec_icon;
    }
}
