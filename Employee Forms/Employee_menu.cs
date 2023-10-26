using JOB_FINDER.Employee_Forms.Career_Guidance;
using JOB_FINDER.Employee_Forms.For_You;
using JOB_FINDER.Employee_Forms.Interviews;
using JOB_FINDER.Employee_Forms.PDF_Reader;
using JOB_FINDER.Login_Forms.Sign_In_Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace JOB_FINDER.Employee_Forms
{
    public partial class Employee_menu : Form
    {
        public Employee_menu()
        {
            InitializeComponent();
        }
        Connection employeemenucon = new Connection();
        Sign_In signin = new Sign_In();
        SqlConnection con;
        SqlCommand cmd;

        public void openChildForm(object Form)
        {
            if (this.pnl_childform.Controls.Count > 0)
                this.pnl_childform.Controls.RemoveAt(0);
            Form x = Form as Form;
            x.TopLevel = false;
            x.Dock = DockStyle.Fill;
            this.pnl_childform.Controls.Add(x);
            this.pnl_childform.Tag = x;
            x.Show();
        }
        private void ShowAccountDetails()
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(pic_pfp.DisplayRectangle);
            pic_pfp.Region = new Region(gp);

            try
            {
                con.Open();
                cmd = new SqlCommand("Select acc_pfp, acc_Name, acc_email from tbl_acc where acc_email=@email", con);
                cmd.Parameters.AddWithValue("@email", signin.getemail());
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    lbl_accname.Text = dr["acc_name"].ToString();
                    lbl_accemail.Text = dr["acc_email"].ToString();
                    if (dr.IsDBNull(dr.GetOrdinal("acc_pfp")))
                    {

                    }
                    else
                    {
                        byte[] imgData = (byte[])dr["acc_pfp"];
                        using (MemoryStream ms = new MemoryStream(imgData))
                        {
                            pic_pfp.Image = Image.FromStream(ms);
                        }
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CheckCV()
        {
            con.Open();
            cmd = new SqlCommand("select * from tbl_cv where cv_email = @email", con);
            cmd.Parameters.AddWithValue("email", signin.getemail());
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                openChildForm(new ForYou());
            }
            else
            {
                openChildForm(new PDF_reader());
            }
            con.Close();
        }
       

        
       
        private void Menu_Employee_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(employeemenucon.connection.ConnectionString);
            ShowAccountDetails();
            Dashboard_Employee x = new Dashboard_Employee();
            openChildForm(x);
        }

        private void btn_foryou_Click(object sender, EventArgs e)
        {
            CheckCV();
        }

        private void btn_searchjobs_Click_1(object sender, EventArgs e)
        {
            JobSearch obj = new JobSearch();
            openChildForm(obj);
        }

        private void btn_careerguidance_Click(object sender, EventArgs e)
        {
            AI aI = new AI();
            openChildForm(aI);
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            Employee_Update userUpdate = new Employee_Update();
            openChildForm(userUpdate);
        }

        private void btn_interview_Click(object sender, EventArgs e)
        {
            Employee_Interviews obj = new Employee_Interviews();
            openChildForm(obj);
        }
        


        private void btn_signout_Click(object sender, EventArgs e)
        {
            Sign_In obj = new Sign_In();
            obj.Show();
            this.Hide();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            Dashboard_Employee obj = new Dashboard_Employee();
            openChildForm(obj);
        }
    }
}
