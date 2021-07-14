namespace Employee_Management_System
{
    partial class frm_MDI_Employee_Management_System
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
            this.lbl_Logged_In_Username = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchEmployeeDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEmployeeDetailsByDeptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEmployeeDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Logged_In_Username
            // 
            this.lbl_Logged_In_Username.AutoSize = true;
            this.lbl_Logged_In_Username.BackColor = System.Drawing.Color.White;
            this.lbl_Logged_In_Username.Font = new System.Drawing.Font("Myanmar Text", 8F, System.Drawing.FontStyle.Bold);
            this.lbl_Logged_In_Username.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Logged_In_Username.Location = new System.Drawing.Point(721, 0);
            this.lbl_Logged_In_Username.Name = "lbl_Logged_In_Username";
            this.lbl_Logged_In_Username.Size = new System.Drawing.Size(157, 25);
            this.lbl_Logged_In_Username.TabIndex = 26;
            this.lbl_Logged_In_Username.Text = "Logged In User Name";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(1109, 28);
            this.menuStrip.TabIndex = 25;
            this.menuStrip.Text = "MenuStrip";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewEmployeeToolStripMenuItem,
            this.searchEmployeeDetailsToolStripMenuItem});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // addNewEmployeeToolStripMenuItem
            // 
            this.addNewEmployeeToolStripMenuItem.Name = "addNewEmployeeToolStripMenuItem";
            this.addNewEmployeeToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.addNewEmployeeToolStripMenuItem.Text = "Add New Employee";
            // 
            // searchEmployeeDetailsToolStripMenuItem
            // 
            this.searchEmployeeDetailsToolStripMenuItem.Name = "searchEmployeeDetailsToolStripMenuItem";
            this.searchEmployeeDetailsToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.searchEmployeeDetailsToolStripMenuItem.Text = "Search Employee Details";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewEmployeeDetailsByDeptToolStripMenuItem,
            this.viewEmployeeDetailsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // viewEmployeeDetailsByDeptToolStripMenuItem
            // 
            this.viewEmployeeDetailsByDeptToolStripMenuItem.Name = "viewEmployeeDetailsByDeptToolStripMenuItem";
            this.viewEmployeeDetailsByDeptToolStripMenuItem.Size = new System.Drawing.Size(299, 24);
            this.viewEmployeeDetailsByDeptToolStripMenuItem.Text = "Search Employee Details by Dept";
            // 
            // viewEmployeeDetailsToolStripMenuItem
            // 
            this.viewEmployeeDetailsToolStripMenuItem.Name = "viewEmployeeDetailsToolStripMenuItem";
            this.viewEmployeeDetailsToolStripMenuItem.Size = new System.Drawing.Size(299, 24);
            this.viewEmployeeDetailsToolStripMenuItem.Text = "View Employee Details";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorToolStripMenuItem,
            this.notepadToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            // 
            // notepadToolStripMenuItem
            // 
            this.notepadToolStripMenuItem.Name = "notepadToolStripMenuItem";
            this.notepadToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.notepadToolStripMenuItem.Text = "Notepad";
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Log_Out.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Log_Out.Location = new System.Drawing.Point(977, 0);
            this.btn_Log_Out.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(132, 28);
            this.btn_Log_Out.TabIndex = 27;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            // 
            // frm_MDI_Employee_Management_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 586);
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.lbl_Logged_In_Username);
            this.Controls.Add(this.menuStrip);
            this.Name = "frm_MDI_Employee_Management_System";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDI Employee Management System";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Logged_In_Username;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchEmployeeDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEmployeeDetailsByDeptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEmployeeDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notepadToolStripMenuItem;
        private System.Windows.Forms.Button btn_Log_Out;
    }
}