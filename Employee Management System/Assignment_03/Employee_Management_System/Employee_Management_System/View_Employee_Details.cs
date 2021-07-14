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
            // TODO: This line of code loads data into the 'employee_Management_SystemDataSet1.Employee_Details' table. You can move, or remove it, as needed.
            this.employee_DetailsTableAdapter.Fill(this.employee_Management_SystemDataSet1.Employee_Details);

        }

        

        
    }
}
