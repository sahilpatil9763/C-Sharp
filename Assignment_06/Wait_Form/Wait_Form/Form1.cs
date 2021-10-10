using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace Wait_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Wait_Form_Functions WaitForm = new Wait_Form_Functions();

        private void btn_Click(object sender, EventArgs e)
        {
           
            try
            {
                this.Show();
                Thread.Sleep(5000);
                frm_Second frm = new frm_Second();
                frm.Show();

                this.Close();
            }

            catch 
            {

            }
        }
    }
}
