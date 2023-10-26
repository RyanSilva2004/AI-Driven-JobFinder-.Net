using JOB_FINDER.Company_Forms.Company_ViewApplications;
using JOB_FINDER.Company_Forms.View_Applications;
using JOB_FINDER.Company_Forms.View_Interviews;
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

namespace JOB_FINDER.Company_Forms
{
    public partial class Company_Menu : Form
    {
        public Company_Menu()
        {
            InitializeComponent();
        }
        Connection companymenucon = new Connection();
        Sign_In sign = new Sign_In();
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

        public void OpenEditForm(object Form)
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
        private void btn_viewapplication_Click(object sender, EventArgs e)
        {
            ViewApplications obj = new ViewApplications();
            openChildForm(obj);
        }

        public void btn_postjobs_Click(object sender, EventArgs e)
        {
            JobListings obj = new JobListings();
            openChildForm(obj);
        }

        private void btn_interview_Click(object sender, EventArgs e)
        {
            ViewInterviews obj = new ViewInterviews();
            openChildForm(obj);
        }
        private void ShowAccountDetails()
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(pic_pfp.DisplayRectangle);
            pic_pfp.Region = new Region(gp);

            try
            {
                con.Open();
                cmd = new SqlCommand("Select * from tbl_company_acc where com_email=@email", con);
                cmd.Parameters.AddWithValue("@email", sign.getemail());
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    lbl_accname.Text = dr["com_name"].ToString();
                    lbl_accemail.Text = dr["com_email"].ToString();
                    if (dr.IsDBNull(dr.GetOrdinal("com_pfp")))
                    {

                    }
                    else
                    {
                        byte[] imgData = (byte[])dr["com_pfp"];
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
        private void Company_Menu1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(companymenucon.connection.ConnectionString);
            ShowAccountDetails();
            btn_dashboard.Focus();
            Dashboard obj = new Dashboard();
            openChildForm(obj);
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            Company_Update obj = new Company_Update();
            openChildForm(obj);
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            openChildForm(obj);
        }

        private void btn_signout_Click(object sender, EventArgs e)
        {
            Sign_In obj = new Sign_In();
            obj.Show();
            this.Hide();
        }

        private void btn_signout_Click_1(object sender, EventArgs e)
        {
            Sign_In obj = new Sign_In();
            obj.Show();
            this.Hide();
        }
    }
}
