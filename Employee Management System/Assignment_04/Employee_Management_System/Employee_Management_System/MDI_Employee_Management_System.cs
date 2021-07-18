﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class frm_MDI_Employee_Management_System : Form
    {
        public frm_MDI_Employee_Management_System()
        {
            InitializeComponent();
        }

        private void frm_MDI_Employee_Management_System_Load(object sender, EventArgs e)
        {
            lbl_Logged_In_Username.Text = Global_Var.Uname;

            if (Global_Var.User_Role == 1)
            {
                updateEmployeeDetailsToolStripMenuItem.Visible = true;
                viewEmployeeDetailsByDeptToolStripMenuItem.Visible = true;
                reportToolStripMenuItem.Visible = true;
            }
        }

        private void addNewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_New_Employee ANE = new frm_Add_New_Employee();

            ANE.MdiParent = this;
            ANE.WindowState = FormWindowState.Maximized;
            ANE.Show();
        }

        private void viewEmployeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_View_Employee_Details VED = new frm_View_Employee_Details();

            VED.MdiParent = this;
            VED.WindowState = FormWindowState.Maximized;
            VED.Show();
        }

        private void viewEmployeeDetailsByDeptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Search_Employee_Details_By_Department SEDBD = new frm_Search_Employee_Details_By_Department();

            SEDBD.MdiParent = this;
            SEDBD.WindowState = FormWindowState.Maximized;
            SEDBD.Show();
        }

        private void searchEmployeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Search_Employee_Details SED = new frm_Search_Employee_Details();

            SED.MdiParent = this;
            SED.WindowState = FormWindowState.Maximized;
            SED.Show();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Loging out", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            frm_Login L = new frm_Login();

            L.Show();
            this.Hide();
        }

        private void updateEmployeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Update_Employee_Details UED = new frm_Update_Employee_Details();

            UED.MdiParent = this;
            UED.WindowState = FormWindowState.Maximized;
            UED.Show();
        }
    }
}
