namespace Employee_Management_System
{
    partial class frm_Add_New_Employee
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
            this.lbl_Salary = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.btn_View_All_Details = new System.Windows.Forms.Button();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.cmb_Department = new System.Windows.Forms.ComboBox();
            this.dtp_Date_Of_Birth = new System.Windows.Forms.DateTimePicker();
            this.lbl_Department = new System.Windows.Forms.Label();
            this.tb_Salary = new System.Windows.Forms.TextBox();
            this.lbl_Date_Of_Birth = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Salary
            // 
            this.lbl_Salary.AutoSize = true;
            this.lbl_Salary.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Salary.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Salary.Location = new System.Drawing.Point(133, 337);
            this.lbl_Salary.Name = "lbl_Salary";
            this.lbl_Salary.Size = new System.Drawing.Size(128, 44);
            this.lbl_Salary.TabIndex = 73;
            this.lbl_Salary.Text = "Salary";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Name.Location = new System.Drawing.Point(133, 198);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(117, 44);
            this.lbl_Name.TabIndex = 71;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_ID.Location = new System.Drawing.Point(133, 132);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(68, 44);
            this.lbl_ID.TabIndex = 72;
            this.lbl_ID.Text = "ID";
            // 
            // btn_View_All_Details
            // 
            this.btn_View_All_Details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_View_All_Details.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_All_Details.ForeColor = System.Drawing.Color.Maroon;
            this.btn_View_All_Details.Location = new System.Drawing.Point(603, 497);
            this.btn_View_All_Details.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_View_All_Details.Name = "btn_View_All_Details";
            this.btn_View_All_Details.Size = new System.Drawing.Size(257, 49);
            this.btn_View_All_Details.TabIndex = 7;
            this.btn_View_All_Details.Text = "View All Details";
            this.btn_View_All_Details.UseVisualStyleBackColor = false;
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Log_Out.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Log_Out.Location = new System.Drawing.Point(975, 1);
            this.btn_Log_Out.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(132, 40);
            this.btn_Log_Out.TabIndex = 7;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            // 
            // cmb_Department
            // 
            this.cmb_Department.Font = new System.Drawing.Font("Modern No. 20", 16F);
            this.cmb_Department.FormattingEnabled = true;
            this.cmb_Department.Items.AddRange(new object[] {
            "HR",
            "Manager",
            "Accounts and Finance",
            "Sales and marketing",
            ""});
            this.cmb_Department.Location = new System.Drawing.Point(709, 403);
            this.cmb_Department.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Department.Name = "cmb_Department";
            this.cmb_Department.Size = new System.Drawing.Size(306, 37);
            this.cmb_Department.TabIndex = 5;
            // 
            // dtp_Date_Of_Birth
            // 
            this.dtp_Date_Of_Birth.Font = new System.Drawing.Font("Modern No. 20", 16F);
            this.dtp_Date_Of_Birth.Location = new System.Drawing.Point(709, 277);
            this.dtp_Date_Of_Birth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_Date_Of_Birth.Name = "dtp_Date_Of_Birth";
            this.dtp_Date_Of_Birth.Size = new System.Drawing.Size(306, 36);
            this.dtp_Date_Of_Birth.TabIndex = 3;
            // 
            // lbl_Department
            // 
            this.lbl_Department.AutoSize = true;
            this.lbl_Department.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Department.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Department.Location = new System.Drawing.Point(133, 403);
            this.lbl_Department.Name = "lbl_Department";
            this.lbl_Department.Size = new System.Drawing.Size(221, 44);
            this.lbl_Department.TabIndex = 70;
            this.lbl_Department.Text = "Department";
            // 
            // tb_Salary
            // 
            this.tb_Salary.Font = new System.Drawing.Font("Modern No. 20", 17F);
            this.tb_Salary.Location = new System.Drawing.Point(709, 337);
            this.tb_Salary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Salary.MaxLength = 20;
            this.tb_Salary.Multiline = true;
            this.tb_Salary.Name = "tb_Salary";
            this.tb_Salary.Size = new System.Drawing.Size(306, 40);
            this.tb_Salary.TabIndex = 4;
            // 
            // lbl_Date_Of_Birth
            // 
            this.lbl_Date_Of_Birth.AutoSize = true;
            this.lbl_Date_Of_Birth.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date_Of_Birth.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Date_Of_Birth.Location = new System.Drawing.Point(133, 277);
            this.lbl_Date_Of_Birth.Name = "lbl_Date_Of_Birth";
            this.lbl_Date_Of_Birth.Size = new System.Drawing.Size(261, 44);
            this.lbl_Date_Of_Birth.TabIndex = 68;
            this.lbl_Date_Of_Birth.Text = "Date Of Birth";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Save.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Save.Location = new System.Drawing.Point(247, 497);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(156, 49);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Modern No. 20", 17F);
            this.tb_Name.Location = new System.Drawing.Point(709, 198);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Name.MaxLength = 20;
            this.tb_Name.Multiline = true;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(306, 40);
            this.tb_Name.TabIndex = 2;
            // 
            // tb_ID
            // 
            this.tb_ID.Font = new System.Drawing.Font("Modern No. 20", 17F);
            this.tb_ID.Location = new System.Drawing.Point(709, 132);
            this.tb_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_ID.MaxLength = 40000;
            this.tb_ID.Multiline = true;
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(306, 40);
            this.tb_ID.TabIndex = 1;
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.Color.White;
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.Red;
            this.lbl_Header.Location = new System.Drawing.Point(330, 17);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(479, 58);
            this.lbl_Header.TabIndex = 69;
            this.lbl_Header.Text = "Add New Employee";
            // 
            // frm_Add_New_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 586);
            this.Controls.Add(this.lbl_Salary);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.btn_View_All_Details);
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.cmb_Department);
            this.Controls.Add(this.dtp_Date_Of_Birth);
            this.Controls.Add(this.lbl_Department);
            this.Controls.Add(this.tb_Salary);
            this.Controls.Add(this.lbl_Date_Of_Birth);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.lbl_Header);
            this.Name = "frm_Add_New_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Employee";
            this.Load += new System.EventHandler(this.frm_Add_New_Employee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Salary;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Button btn_View_All_Details;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.ComboBox cmb_Department;
        private System.Windows.Forms.DateTimePicker dtp_Date_Of_Birth;
        private System.Windows.Forms.Label lbl_Department;
        private System.Windows.Forms.TextBox tb_Salary;
        private System.Windows.Forms.Label lbl_Date_Of_Birth;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label lbl_Header;
    }
}