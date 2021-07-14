using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class frm_Login_Form : Form
    {
        public frm_Login_Form()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if ((tb_Username.Text == "admin" && tb_Password.Text == "a123") ||  (tb_Username.Text == "a" && tb_Password.Text == "a"))
            {
                Global_Var.Uname = tb_Username.Text;

                MessageBox.Show("Login Successfull !!", "Working", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                frm_Add_New_Employee AED = new frm_Add_New_Employee();

                AED.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Enter Valid Username & Password", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            tb_Username.Clear();
            tb_Password.Clear();
            tb_Username.Focus();
        }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Submit.Enabled = true;
        }
    }
}
