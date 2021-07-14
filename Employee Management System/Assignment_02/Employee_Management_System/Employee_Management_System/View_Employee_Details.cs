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
    public partial class frm_View_Employee_Details : Form
    {
        public frm_View_Employee_Details()
        {
            InitializeComponent();
        }

        private void frm_View_Employee_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employee_Management_SystemDataSet.Employee_Details' table. You can move, or remove it, as needed.
            this.employee_DetailsTableAdapter.Fill(this.employee_Management_SystemDataSet.Employee_Details);

        }

        private void btn_Add_New_Employee_Click(object sender, EventArgs e)
        {
            frm_Add_New_Employee ANE = new frm_Add_New_Employee();

            ANE.Show();

            this.Hide();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are you Sure you want to Log Out?", "Loging Out", MessageBoxButtons.YesNo);

            if (Res == DialogResult.Yes)
            {
                frm_Login_Form Login = new frm_Login_Form();

                Login.Show();

                this.Hide();
            }
        }

        private void btn_Search_Employee_Details_By_Department_Click(object sender, EventArgs e)
        {
            frm_Search_Employee_Details_By_Department SEDBD = new frm_Search_Employee_Details_By_Department();

            SEDBD.Show();

            this.Hide();
        }

        private void btn_Search_Employee_Details_Click(object sender, EventArgs e)
        {
            frm_Search_Employee_Details SED = new frm_Search_Employee_Details();

            SED.Show();

            this.Hide();
        }
    }
}
