namespace Book_Management_System
{
    partial class frm_Add_New_Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Add_New_Book));
            this.btn_Submit = new System.Windows.Forms.Button();
            this.tb_Book_Price = new System.Windows.Forms.TextBox();
            this.tb_Book_Name = new System.Windows.Forms.TextBox();
            this.lbl_Book_Name = new System.Windows.Forms.Label();
            this.lbl_Book_Id = new System.Windows.Forms.Label();
            this.lbl_Add_New_Book = new System.Windows.Forms.Label();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.lbl_Book_Price = new System.Windows.Forms.Label();
            this.lbl_Publish_Date = new System.Windows.Forms.Label();
            this.tb_Book_ID = new System.Windows.Forms.TextBox();
            this.dtp_Publish_Date = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Submit.Enabled = false;
            this.btn_Submit.Font = new System.Drawing.Font("Javanese Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_Submit.Location = new System.Drawing.Point(422, 462);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(159, 51);
            this.btn_Submit.TabIndex = 5;
            this.btn_Submit.Text = "SUBMIT";
            this.btn_Submit.UseVisualStyleBackColor = false;
            // 
            // tb_Book_Price
            // 
            this.tb_Book_Price.Enabled = false;
            this.tb_Book_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Book_Price.Location = new System.Drawing.Point(544, 368);
            this.tb_Book_Price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Book_Price.MaxLength = 10;
            this.tb_Book_Price.Multiline = true;
            this.tb_Book_Price.Name = "tb_Book_Price";
            this.tb_Book_Price.Size = new System.Drawing.Size(339, 40);
            this.tb_Book_Price.TabIndex = 4;
            // 
            // tb_Book_Name
            // 
            this.tb_Book_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Book_Name.Location = new System.Drawing.Point(544, 219);
            this.tb_Book_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Book_Name.MaxLength = 12;
            this.tb_Book_Name.Multiline = true;
            this.tb_Book_Name.Name = "tb_Book_Name";
            this.tb_Book_Name.Size = new System.Drawing.Size(339, 40);
            this.tb_Book_Name.TabIndex = 2;
            // 
            // lbl_Book_Name
            // 
            this.lbl_Book_Name.AutoSize = true;
            this.lbl_Book_Name.Font = new System.Drawing.Font("Modern No. 20", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_Name.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Book_Name.Location = new System.Drawing.Point(193, 219);
            this.lbl_Book_Name.Name = "lbl_Book_Name";
            this.lbl_Book_Name.Size = new System.Drawing.Size(189, 36);
            this.lbl_Book_Name.TabIndex = 26;
            this.lbl_Book_Name.Text = "Book Name";
            // 
            // lbl_Book_Id
            // 
            this.lbl_Book_Id.AutoSize = true;
            this.lbl_Book_Id.Font = new System.Drawing.Font("Modern No. 20", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_Id.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Book_Id.Location = new System.Drawing.Point(193, 137);
            this.lbl_Book_Id.Name = "lbl_Book_Id";
            this.lbl_Book_Id.Size = new System.Drawing.Size(146, 36);
            this.lbl_Book_Id.TabIndex = 25;
            this.lbl_Book_Id.Text = "Book ID";
            // 
            // lbl_Add_New_Book
            // 
            this.lbl_Add_New_Book.AutoSize = true;
            this.lbl_Add_New_Book.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Add_New_Book.Font = new System.Drawing.Font("Franklin Gothic Demi", 32F);
            this.lbl_Add_New_Book.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Add_New_Book.Location = new System.Drawing.Point(337, 24);
            this.lbl_Add_New_Book.Name = "lbl_Add_New_Book";
            this.lbl_Add_New_Book.Size = new System.Drawing.Size(373, 68);
            this.lbl_Add_New_Book.TabIndex = 24;
            this.lbl_Add_New_Book.Text = "Add New Book";
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.Linen;
            this.btn_Log_Out.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Log_Out.Enabled = false;
            this.btn_Log_Out.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Log_Out.Location = new System.Drawing.Point(956, 11);
            this.btn_Log_Out.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(119, 44);
            this.btn_Log_Out.TabIndex = 6;
            this.btn_Log_Out.Text = "LOG OUT";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // lbl_Book_Price
            // 
            this.lbl_Book_Price.AutoSize = true;
            this.lbl_Book_Price.Font = new System.Drawing.Font("Modern No. 20", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_Price.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Book_Price.Location = new System.Drawing.Point(193, 372);
            this.lbl_Book_Price.Name = "lbl_Book_Price";
            this.lbl_Book_Price.Size = new System.Drawing.Size(185, 36);
            this.lbl_Book_Price.TabIndex = 30;
            this.lbl_Book_Price.Text = "Book Price";
            // 
            // lbl_Publish_Date
            // 
            this.lbl_Publish_Date.AutoSize = true;
            this.lbl_Publish_Date.Font = new System.Drawing.Font("Modern No. 20", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Publish_Date.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Publish_Date.Location = new System.Drawing.Point(193, 298);
            this.lbl_Publish_Date.Name = "lbl_Publish_Date";
            this.lbl_Publish_Date.Size = new System.Drawing.Size(213, 36);
            this.lbl_Publish_Date.TabIndex = 29;
            this.lbl_Publish_Date.Text = "Publish Date";
            // 
            // tb_Book_ID
            // 
            this.tb_Book_ID.Enabled = false;
            this.tb_Book_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Book_ID.Location = new System.Drawing.Point(544, 133);
            this.tb_Book_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Book_ID.MaxLength = 10;
            this.tb_Book_ID.Multiline = true;
            this.tb_Book_ID.Name = "tb_Book_ID";
            this.tb_Book_ID.Size = new System.Drawing.Size(339, 40);
            this.tb_Book_ID.TabIndex = 1;
            // 
            // dtp_Publish_Date
            // 
            this.dtp_Publish_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtp_Publish_Date.Location = new System.Drawing.Point(544, 298);
            this.dtp_Publish_Date.Name = "dtp_Publish_Date";
            this.dtp_Publish_Date.Size = new System.Drawing.Size(339, 30);
            this.dtp_Publish_Date.TabIndex = 3;
            // 
            // frm_Add_New_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 544);
            this.Controls.Add(this.dtp_Publish_Date);
            this.Controls.Add(this.tb_Book_ID);
            this.Controls.Add(this.lbl_Book_Price);
            this.Controls.Add(this.lbl_Publish_Date);
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.tb_Book_Price);
            this.Controls.Add(this.tb_Book_Name);
            this.Controls.Add(this.lbl_Book_Name);
            this.Controls.Add(this.lbl_Book_Id);
            this.Controls.Add(this.lbl_Add_New_Book);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Add_New_Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.TextBox tb_Book_Price;
        private System.Windows.Forms.TextBox tb_Book_Name;
        private System.Windows.Forms.Label lbl_Book_Name;
        private System.Windows.Forms.Label lbl_Book_Id;
        private System.Windows.Forms.Label lbl_Add_New_Book;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.Label lbl_Book_Price;
        private System.Windows.Forms.Label lbl_Publish_Date;
        private System.Windows.Forms.TextBox tb_Book_ID;
        private System.Windows.Forms.DateTimePicker dtp_Publish_Date;
    }
}