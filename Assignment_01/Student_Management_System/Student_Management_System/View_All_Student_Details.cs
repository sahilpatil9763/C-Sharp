using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class frm_View_All_Student_Details : Form
    {
        public frm_View_All_Student_Details()
        {
            InitializeComponent();
        }

        private void frm_View_All_Student_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kCT_Student_Mgt_System_DBDataSet.Login_Details' table. You can move, or remove it, as needed.
            this.login_DetailsTableAdapter.Fill(this.kCT_Student_Mgt_System_DBDataSet.Login_Details);

        }

        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student ANS = new frm_Add_New_Student();

            ANS.Show();

            this.Hide();
        }

        private void btn_Search_Student_Details_Click(object sender, EventArgs e)
        {
            frm_Search_Student_Details SSD = new frm_Search_Student_Details();

            SSD.Show();

            this.Hide();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Loging Out", "Are You Sure?", MessageBoxButtons.YesNo);

            if (Res == DialogResult.Yes)
            {
                frm_Login Obj = new frm_Login();
                Obj.Show();

                this.Hide();
            }
        }

        
    }
}
