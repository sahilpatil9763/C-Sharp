namespace Employee_Management_System
{
    partial class frm_View_Employee_Details
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
            this.btn_Search_Employee_Details = new System.Windows.Forms.Button();
            this.btn_Search_Employee_Details_By_Department = new System.Windows.Forms.Button();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.btn_Add_New_Employee = new System.Windows.Forms.Button();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.employee_Management_SystemDataSet = new Employee_Management_System.Employee_Management_SystemDataSet();
            this.employeeManagementSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_Search_Employee_Details_By_Department = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employee_Management_SystemDataSet1 = new Employee_Management_System.Employee_Management_SystemDataSet1();
            this.employeeDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_DetailsTableAdapter = new Employee_Management_System.Employee_Management_SystemDataSet1TableAdapters.Employee_DetailsTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeManagementSystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search_Employee_Details_By_Department)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_SystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Search_Employee_Details
            // 
            this.btn_Search_Employee_Details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Search_Employee_Details.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.btn_Search_Employee_Details.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Search_Employee_Details.Location = new System.Drawing.Point(32, 483);
            this.btn_Search_Employee_Details.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Search_Employee_Details.Name = "btn_Search_Employee_Details";
            this.btn_Search_Employee_Details.Size = new System.Drawing.Size(289, 39);
            this.btn_Search_Employee_Details.TabIndex = 37;
            this.btn_Search_Employee_Details.Text = "Search Employee Details";
            this.btn_Search_Employee_Details.UseVisualStyleBackColor = false;
            // 
            // btn_Search_Employee_Details_By_Department
            // 
            this.btn_Search_Employee_Details_By_Department.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Search_Employee_Details_By_Department.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.btn_Search_Employee_Details_By_Department.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Search_Employee_Details_By_Department.Location = new System.Drawing.Point(385, 483);
            this.btn_Search_Employee_Details_By_Department.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Search_Employee_Details_By_Department.Name = "btn_Search_Employee_Details_By_Department";
            this.btn_Search_Employee_Details_By_Department.Size = new System.Drawing.Size(393, 39);
            this.btn_Search_Employee_Details_By_Department.TabIndex = 36;
            this.btn_Search_Employee_Details_By_Department.Text = "Search Employee Details By Department";
            this.btn_Search_Employee_Details_By_Department.UseVisualStyleBackColor = false;
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Log_Out.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Log_Out.Location = new System.Drawing.Point(1007, 0);
            this.btn_Log_Out.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(125, 30);
            this.btn_Log_Out.TabIndex = 35;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            // 
            // btn_Add_New_Employee
            // 
            this.btn_Add_New_Employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Add_New_Employee.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.btn_Add_New_Employee.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Add_New_Employee.Location = new System.Drawing.Point(833, 483);
            this.btn_Add_New_Employee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add_New_Employee.Name = "btn_Add_New_Employee";
            this.btn_Add_New_Employee.Size = new System.Drawing.Size(268, 39);
            this.btn_Add_New_Employee.TabIndex = 32;
            this.btn_Add_New_Employee.Text = "Add New Employee";
            this.btn_Add_New_Employee.UseVisualStyleBackColor = false;
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.Color.White;
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.Red;
            this.lbl_Header.Location = new System.Drawing.Point(280, 17);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(556, 58);
            this.lbl_Header.TabIndex = 33;
            this.lbl_Header.Text = "View Employee Details";
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
            this.iDDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.dOBDataGridViewTextBoxColumn1,
            this.salaryDataGridViewTextBoxColumn1,
            this.departmentDataGridViewTextBoxColumn1,
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn});
            this.dgv_Search_Employee_Details_By_Department.DataSource = this.employeeDetailsBindingSource;
            this.dgv_Search_Employee_Details_By_Department.Location = new System.Drawing.Point(12, 129);
            this.dgv_Search_Employee_Details_By_Department.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Search_Employee_Details_By_Department.Name = "dgv_Search_Employee_Details_By_Department";
            this.dgv_Search_Employee_Details_By_Department.ReadOnly = true;
            this.dgv_Search_Employee_Details_By_Department.RowTemplate.Height = 28;
            this.dgv_Search_Employee_Details_By_Department.Size = new System.Drawing.Size(1074, 311);
            this.dgv_Search_Employee_Details_By_Department.TabIndex = 59;
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
            // employee_Management_SystemDataSet1
            // 
            this.employee_Management_SystemDataSet1.DataSetName = "Employee_Management_SystemDataSet1";
            this.employee_Management_SystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeDetailsBindingSource
            // 
            this.employeeDetailsBindingSource.DataMember = "Employee_Details";
            this.employeeDetailsBindingSource.DataSource = this.employee_Management_SystemDataSet1;
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
            // frm_View_Employee_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 560);
            this.Controls.Add(this.dgv_Search_Employee_Details_By_Department);
            this.Controls.Add(this.btn_Search_Employee_Details);
            this.Controls.Add(this.btn_Search_Employee_Details_By_Department);
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.btn_Add_New_Employee);
            this.Controls.Add(this.lbl_Header);
            this.Name = "frm_View_Employee_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Employee Details";
            this.Load += new System.EventHandler(this.frm_View_Employee_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeManagementSystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search_Employee_Details_By_Department)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_SystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Search_Employee_Details;
        private System.Windows.Forms.Button btn_Search_Employee_Details_By_Department;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.Button btn_Add_New_Employee;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.BindingSource employeeManagementSystemDataSetBindingSource;
        private Employee_Management_SystemDataSet employee_Management_SystemDataSet;
        private System.Windows.Forms.DataGridView dgv_Search_Employee_Details_By_Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn1;
        private Employee_Management_SystemDataSet1 employee_Management_SystemDataSet1;
        private System.Windows.Forms.BindingSource employeeDetailsBindingSource;
        private Employee_Management_SystemDataSet1TableAdapters.Employee_DetailsTableAdapter employee_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
    }
}