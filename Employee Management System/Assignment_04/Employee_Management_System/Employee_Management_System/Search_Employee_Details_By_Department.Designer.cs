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
            this.lbl_Search_Employee_Details_By_Department = new System.Windows.Forms.Label();
            this.cmb_Department = new System.Windows.Forms.ComboBox();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.btn_Search_Employee_Details = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_View_All_Details = new System.Windows.Forms.Button();
            this.btn_Add_New_Employee = new System.Windows.Forms.Button();
            this.lbl_Department = new System.Windows.Forms.Label();
            this.employee_Management_SystemDataSet2 = new Employee_Management_System.Employee_Management_SystemDataSet2();
            this.employeeManagementSystemDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_Search_Employee_Details_By_Department = new System.Windows.Forms.DataGridView();
            this.employee_Management_SystemDataSet = new Employee_Management_System.Employee_Management_SystemDataSet();
            this.employeeDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_DetailsTableAdapter = new Employee_Management_System.Employee_Management_SystemDataSetTableAdapters.Employee_DetailsTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_SystemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeManagementSystemDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search_Employee_Details_By_Department)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Search_Employee_Details_By_Department
            // 
            this.lbl_Search_Employee_Details_By_Department.AutoSize = true;
            this.lbl_Search_Employee_Details_By_Department.BackColor = System.Drawing.Color.White;
            this.lbl_Search_Employee_Details_By_Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search_Employee_Details_By_Department.ForeColor = System.Drawing.Color.Red;
            this.lbl_Search_Employee_Details_By_Department.Location = new System.Drawing.Point(302, 9);
            this.lbl_Search_Employee_Details_By_Department.Name = "lbl_Search_Employee_Details_By_Department";
            this.lbl_Search_Employee_Details_By_Department.Size = new System.Drawing.Size(609, 58);
            this.lbl_Search_Employee_Details_By_Department.TabIndex = 69;
            this.lbl_Search_Employee_Details_By_Department.Text = "Search Employee Details";
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
            this.cmb_Department.Location = new System.Drawing.Point(465, 101);
            this.cmb_Department.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Department.Name = "cmb_Department";
            this.cmb_Department.Size = new System.Drawing.Size(306, 37);
            this.cmb_Department.TabIndex = 1;
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Log_Out.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Log_Out.Location = new System.Drawing.Point(1025, 0);
            this.btn_Log_Out.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(132, 41);
            this.btn_Log_Out.TabIndex = 6;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            // 
            // btn_Search_Employee_Details
            // 
            this.btn_Search_Employee_Details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Search_Employee_Details.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Employee_Details.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Search_Employee_Details.Location = new System.Drawing.Point(764, 481);
            this.btn_Search_Employee_Details.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Search_Employee_Details.Name = "btn_Search_Employee_Details";
            this.btn_Search_Employee_Details.Size = new System.Drawing.Size(321, 39);
            this.btn_Search_Employee_Details.TabIndex = 3;
            this.btn_Search_Employee_Details.Text = "Search Employee Details";
            this.btn_Search_Employee_Details.UseVisualStyleBackColor = false;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Yellow;
            this.btn_Refresh.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Red;
            this.btn_Refresh.Location = new System.Drawing.Point(861, 101);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(132, 36);
            this.btn_Refresh.TabIndex = 2;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // btn_View_All_Details
            // 
            this.btn_View_All_Details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_View_All_Details.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_All_Details.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_View_All_Details.Location = new System.Drawing.Point(448, 481);
            this.btn_View_All_Details.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_View_All_Details.Name = "btn_View_All_Details";
            this.btn_View_All_Details.Size = new System.Drawing.Size(257, 39);
            this.btn_View_All_Details.TabIndex = 4;
            this.btn_View_All_Details.Text = "View All Details";
            this.btn_View_All_Details.UseVisualStyleBackColor = false;
            // 
            // btn_Add_New_Employee
            // 
            this.btn_Add_New_Employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Add_New_Employee.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Employee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Add_New_Employee.Location = new System.Drawing.Point(87, 481);
            this.btn_Add_New_Employee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add_New_Employee.Name = "btn_Add_New_Employee";
            this.btn_Add_New_Employee.Size = new System.Drawing.Size(289, 39);
            this.btn_Add_New_Employee.TabIndex = 5;
            this.btn_Add_New_Employee.Text = "Add New Employee";
            this.btn_Add_New_Employee.UseVisualStyleBackColor = false;
            // 
            // lbl_Department
            // 
            this.lbl_Department.AutoSize = true;
            this.lbl_Department.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Department.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Department.Location = new System.Drawing.Point(200, 97);
            this.lbl_Department.Name = "lbl_Department";
            this.lbl_Department.Size = new System.Drawing.Size(221, 44);
            this.lbl_Department.TabIndex = 63;
            this.lbl_Department.Text = "Department";
            // 
            // employee_Management_SystemDataSet2
            // 
            this.employee_Management_SystemDataSet2.DataSetName = "Employee_Management_SystemDataSet2";
            this.employee_Management_SystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeManagementSystemDataSet2BindingSource
            // 
            this.employeeManagementSystemDataSet2BindingSource.DataSource = this.employee_Management_SystemDataSet2;
            this.employeeManagementSystemDataSet2BindingSource.Position = 0;
            // 
            // dgv_Search_Employee_Details_By_Department
            // 
            this.dgv_Search_Employee_Details_By_Department.AllowUserToAddRows = false;
            this.dgv_Search_Employee_Details_By_Department.AllowUserToDeleteRows = false;
            this.dgv_Search_Employee_Details_By_Department.AutoGenerateColumns = false;
            this.dgv_Search_Employee_Details_By_Department.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Search_Employee_Details_By_Department.BackgroundColor = System.Drawing.Color.LightBlue;
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
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn});
            this.dgv_Search_Employee_Details_By_Department.DataSource = this.employeeDetailsBindingSource;
            this.dgv_Search_Employee_Details_By_Department.Location = new System.Drawing.Point(43, 152);
            this.dgv_Search_Employee_Details_By_Department.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Search_Employee_Details_By_Department.Name = "dgv_Search_Employee_Details_By_Department";
            this.dgv_Search_Employee_Details_By_Department.ReadOnly = true;
            this.dgv_Search_Employee_Details_By_Department.RowTemplate.Height = 28;
            this.dgv_Search_Employee_Details_By_Department.Size = new System.Drawing.Size(1074, 311);
            this.dgv_Search_Employee_Details_By_Department.TabIndex = 70;
            // 
            // employee_Management_SystemDataSet
            // 
            this.employee_Management_SystemDataSet.DataSetName = "Employee_Management_SystemDataSet";
            this.employee_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeDetailsBindingSource
            // 
            this.employeeDetailsBindingSource.DataMember = "Employee_Details";
            this.employeeDetailsBindingSource.DataSource = this.employee_Management_SystemDataSet;
            // 
            // employee_DetailsTableAdapter
            // 
            this.employee_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frm_Search_Employee_Details_By_Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 562);
            this.Controls.Add(this.dgv_Search_Employee_Details_By_Department);
            this.Controls.Add(this.lbl_Search_Employee_Details_By_Department);
            this.Controls.Add(this.cmb_Department);
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.btn_Search_Employee_Details);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_View_All_Details);
            this.Controls.Add(this.btn_Add_New_Employee);
            this.Controls.Add(this.lbl_Department);
            this.Name = "frm_Search_Employee_Details_By_Department";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Employee Details By Department";
            this.Load += new System.EventHandler(this.frm_Search_Employee_Details_By_Department_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_SystemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeManagementSystemDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search_Employee_Details_By_Department)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Search_Employee_Details_By_Department;
        private System.Windows.Forms.ComboBox cmb_Department;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.Button btn_Search_Employee_Details;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_View_All_Details;
        private System.Windows.Forms.Button btn_Add_New_Employee;
        private System.Windows.Forms.Label lbl_Department;
        private System.Windows.Forms.BindingSource employeeManagementSystemDataSet2BindingSource;
        private Employee_Management_SystemDataSet2 employee_Management_SystemDataSet2;
        private System.Windows.Forms.DataGridView dgv_Search_Employee_Details_By_Department;
        private Employee_Management_SystemDataSet employee_Management_SystemDataSet;
        private System.Windows.Forms.BindingSource employeeDetailsBindingSource;
        private Employee_Management_SystemDataSetTableAdapters.Employee_DetailsTableAdapter employee_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
    }
}