using JOB_FINDER.Login_Forms.Company_Sign_Up;
using JOB_FINDER.Login_Forms.Sign_In_Form;
using JOB_FINDER.Login_Forms.Sign_Up_Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JOB_FINDER.Login_Forms
{
    public partial class Select_Sign_Up : Form
    {
        public Select_Sign_Up()
        {
            InitializeComponent();
        }

        private void btn_selectempacc_Click(object sender, EventArgs e)
        {
            Employee_SignUp obj = new Employee_SignUp();
            obj.Show();
            this.Hide();
        }

        private void btn_selectomacc_Click(object sender, EventArgs e)
        {
            Company_SignUp obj = new Company_SignUp();
            obj.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Sign_In sign_In = new Sign_In();
            sign_In.Show();
            this.Hide();
        }
    }
}
