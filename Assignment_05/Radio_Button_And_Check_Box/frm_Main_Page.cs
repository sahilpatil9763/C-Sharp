using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radio_Button_And_Check_Box
{
    public partial class frm_Main_Page : Form
    {
        public frm_Main_Page()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (rb_Male.Checked == true)
            {
                gender = "Male";
            }
            else gender = "Female";

            string Language = "";
            if (cb_C_Sharp.Checked == true)
            {
                Language += "C#";
            }
            if (cb_C.Checked == true)
            {
                Language += "C";
            }
            if (cb_Python.Checked == true)
            {
                Language += "Python";
            }

            MessageBox.Show("  Name =   " + tb_Name.Text + "   Course =   " + cmb_Course.Text + "   Gender =   " + gender + "   Language =   " + Language);
        }
    }
}
