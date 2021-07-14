namespace Employee_Management_System
{
    partial class frm_Search_Employee_Details_By_Department
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Search_Employee_Details_By_Department = new System.Windows.Forms.DataGridView();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.btn_Search_Employee_Details = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_View_All_Details = new System.Windows.Forms.Button();
            this.btn_Add_New_Employee = new System.Windows.Forms.Button();
            this.cb_Department = new System.Windows.Forms.ComboBox();
            this.lbl_Department = new System.Windows.Forms.Label();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.employee_Management_SystemDataSet = new Employee_Management_System.Employee_Management_SystemDataSet();
            this.employeeManagementSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search_Employee_Details_By_Department)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeManagementSystemDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Search_Employee_Details_By_Department
            // 
            this.dgv_Search_Employee_Details_By_Department.AllowUserToAddRows = false;
            this.dgv_Search_Employee_Details_By_Department.AllowUserToDeleteRows = false;
            this.dgv_Search_Employee_Details_By_Department.AutoGenerateColumns = false;
            this.dgv_Search_Employee_Details_By_Department.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Search_Employee_Details_By_Department.BackgroundColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Search_Employee_Details_By_Department.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Search_Employee_Details_By_Department.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Search_Employee_Details_By_Department.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.dOBDataGridViewTextBoxColumn1,
            this.salaryDataGridViewTextBoxColumn1,
            this.departmentDataGridViewTextBoxColumn1});
            this.dgv_Search_Employee_Details_By_Department.DataSource = this.employeeManagementSystemDataSetBindingSource;
            this.dgv_Search_Employee_Details_By_Department.Location = new System.Drawing.Point(35, 159);
            this.dgv_Search_Employee_Details_By_Department.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Search_Employee_Details_By_Department.Name = "dgv_Search_Employee_Details_By_Department";
            this.dgv_Search_Employee_Details_By_Department.ReadOnly = true;
            this.dgv_Search_Employee_Details_By_Department.RowTemplate.Height = 28;
            this.dgv_Search_Employee_Details_By_Department.Size = new System.Drawing.Size(1074, 311);
            this.dgv_Search_Employee_Details_By_Department.TabIndex = 49;
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Log_Out.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Log_Out.Location = new System.Drawing.Point(1016, 11);
            this.btn_Log_Out.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(132, 41);
            this.btn_Log_Out.TabIndex = 48;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            // 
            // btn_Search_Employee_Details
            // 
            this.btn_Search_Employee_Details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Search_Employee_Details.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Employee_Details.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Search_Employee_Details.Location = new System.Drawing.Point(752, 486);
            this.btn_Search_Employee_Details.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Search_Employee_Details.Name = "btn_Search_Employee_Details";
            this.btn_Search_Employee_Details.Size = new System.Drawing.Size(337, 39);
            this.btn_Search_Employee_Details.TabIndex = 47;
            this.btn_Search_Employee_Details.Text = "Search Employee Details";
            this.btn_Search_Employee_Details.UseVisualStyleBackColor = false;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Yellow;
            this.btn_Refresh.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Red;
            this.btn_Refresh.Location = new System.Drawing.Point(818, 103);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(132, 36);
            this.btn_Refresh.TabIndex = 46;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // btn_View_All_Details
            // 
            this.btn_View_All_Details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_View_All_Details.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_All_Details.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_View_All_Details.Location = new System.Drawing.Point(436, 486);
            this.btn_View_All_Details.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_View_All_Details.Name = "btn_View_All_Details";
            this.btn_View_All_Details.Size = new System.Drawing.Size(257, 39);
            this.btn_View_All_Details.TabIndex = 45;
            this.btn_View_All_Details.Text = "View All Details";
            this.btn_View_All_Details.UseVisualStyleBackColor = false;
            // 
            // btn_Add_New_Employee
            // 
            this.btn_Add_New_Employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Add_New_Employee.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Employee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Add_New_Employee.Location = new System.Drawing.Point(75, 486);
            this.btn_Add_New_Employee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add_New_Employee.Name = "btn_Add_New_Employee";
            this.btn_Add_New_Employee.Size = new System.Drawing.Size(289, 39);
            this.btn_Add_New_Employee.TabIndex = 44;
            this.btn_Add_New_Employee.Text = "Add New Employee";
            this.btn_Add_New_Employee.UseVisualStyleBackColor = false;
            // 
            // cb_Department
            // 
            this.cb_Department.Font = new System.Drawing.Font("Modern No. 20", 16F);
            this.cb_Department.FormattingEnabled = true;
            this.cb_Department.Items.AddRange(new object[] {
            "HR",
            "Manager",
            "Accounts and Finance",
            "Sales and marketing",
            ""});
            this.cb_Department.Location = new System.Drawing.Point(436, 106);
            this.cb_Department.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_Department.Name = "cb_Department";
            this.cb_Department.Size = new System.Drawing.Size(306, 37);
            this.cb_Department.TabIndex = 43;
            // 
            // lbl_Department
            // 
            this.lbl_Department.AutoSize = true;
            this.lbl_Department.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Department.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Department.Location = new System.Drawing.Point(157, 99);
            this.lbl_Department.Name = "lbl_Department";
            this.lbl_Department.Size = new System.Drawing.Size(221, 44);
            this.lbl_Department.TabIndex = 42;
            this.lbl_Department.Text = "Department";
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.Color.White;
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.Red;
            this.lbl_Header.Location = new System.Drawing.Point(214, 12);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(609, 58);
            this.lbl_Header.TabIndex = 41;
            this.lbl_Header.Text = "Search Employee Details";
            // 
            // employee_Management_SystemDataSet
            // 
            this.employee_Management_SystemDataSet.DataSetName = "Employee_Management_SystemDataSet";
            this.employee_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeManagementSystemDataSetBindingSource
            // 
            this.employeeManagementSystemDataSetBindingSource.DataSource = this.employee_Management_SystemDataSet;
            this.employeeManagementSystemDataSetBindingSource.Position = 0;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dOBDataGridViewTextBoxColumn1
            // 
            this.dOBDataGridViewTextBoxColumn1.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn1.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn1.Name = "dOBDataGridViewTextBoxColumn1";
            this.dOBDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // salaryDataGridViewTextBoxColumn1
            // 
            this.salaryDataGridViewTextBoxColumn1.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn1.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn1.Name = "salaryDataGridViewTextBoxColumn1";
            this.salaryDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // departmentDataGridViewTextBoxColumn1
            // 
            this.departmentDataGridViewTextBoxColumn1.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn1.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn1.Name = "departmentDataGridViewTextBoxColumn1";
            this.departmentDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // frm_Search_Employee_Details_By_Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 562);
            this.Controls.Add(this.dgv_Search_Employee_Details_By_Department);
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.btn_Search_Employee_Details);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_View_All_Details);
            this.Controls.Add(this.btn_Add_New_Employee);
            this.Controls.Add(this.cb_Department);
            this.Controls.Add(this.lbl_Department);
            this.Controls.Add(this.lbl_Header);
            this.Name = "frm_Search_Employee_Details_By_Department";
            this.Text = "Search Employee Details By Department";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search_Employee_Details_By_Department)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeManagementSystemDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Search_Employee_Details_By_Department;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.Button btn_Search_Employee_Details;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_View_All_Details;
        private System.Windows.Forms.Button btn_Add_New_Employee;
        private System.Windows.Forms.ComboBox cb_Department;
        private System.Windows.Forms.Label lbl_Department;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.BindingSource employeeManagementSystemDataSetBindingSource;
        private Employee_Management_SystemDataSet employee_Management_SystemDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn1;
    }
}