using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Book_Management_System
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Book_Management_System;Integrated Security=True");



        private void frm_Login_Load(object sender, EventArgs e)
        {
            tb_Username.Focus();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if ((tb_Username.Text == "admin") && (tb_Password.Text == "a123") || (tb_Username.Text == "a") && (tb_Password.Text == "a"))
            {
                MessageBox.Show("Login Successful!!!", "Working", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frm_Add_New_Book Obj = new frm_Add_New_Book();
               
                Obj.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Check Username Or Password", "Login Failed  ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            tb_Username.Clear();
            tb_Password.Clear();
            tb_Username.Focus();

            tb_Password.Enabled = false;
            btn_Submit.Enabled = true;
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
