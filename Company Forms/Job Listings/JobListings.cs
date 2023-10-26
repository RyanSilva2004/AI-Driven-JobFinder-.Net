using JOB_FINDER.Company_Forms.Job_Listings.Post_Job;
using JOB_FINDER.JobListings_UserControls;
using JOB_FINDER.Login_Forms.Sign_In_Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JOB_FINDER.Company_Forms.Company_ViewApplications
{
    public partial class JobListings : Form
    {
        public JobListings()
        {
            InitializeComponent();
        }
        Connection postjobscon = new Connection();
        Sign_In login = new Sign_In();
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

        public void UserControlGeneratorCompany()
        {
            pnl_listedjobs.Controls.Clear();
            DataTable dt = GetData();

            if (dt != null && dt.Rows.Count > 0)
            {
                JobListCompany_ListedJobscs[] listItems = new JobListCompany_ListedJobscs[dt.Rows.Count];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow row = dt.Rows[i];
                    JobListCompany_ListedJobscs jobListing = new JobListCompany_ListedJobscs();

                    // Fill Data To Job Listings
                    jobListing.JobID = row["job_id"].ToString();
                    jobListing.JobTitle = row["job_title"].ToString();
                    jobListing.JobVendor = row["com_name"].ToString();
                    jobListing.JobDescription = row["job_description"].ToString();
                    jobListing.JobSalary = row["job_salary"].ToString();
                    jobListing.JobType = row["job_type"].ToString();
                    jobListing.JobSkill = row["job_skill"].ToString();
                    jobListing.JobVendorEmail = row["job_vender_email"].ToString();
                    jobListing.JobLocation = row["com_location"].ToString();
                    jobListing.JobEducation = row["job_education"].ToString();
                    jobListing.JobExperince = row["job_experience"].ToString();

                    listItems[i] = jobListing;
                }

                pnl_listedjobs.Controls.AddRange(listItems);
            }
        }
        public DataTable readItems()
        {
            if (ConnectionState.Closed == con.State)
            {
                con.Open();
            }
            string query = "select * from tbl_job join tbl_company_acc on tbl_job.job_vender_email = tbl_company_acc.com_email where com_email=@CompanyEmail";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("CompanyEmail", login.getemail());
            try
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch
            {
                throw;
            }
        }

        public DataTable GetData()
        {
            try
            {
                return readItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void ViewApplications_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(postjobscon.connection.ConnectionString);
            UserControlGeneratorCompany();
        }

        private void btn_postjobs_Click(object sender, EventArgs e)
        {
            PostJob_Listings obj = new PostJob_Listings();
            openChildForm(obj);
        }
    }
}