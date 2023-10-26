using JOB_FINDER.JobListings_UserControls;
using JOB_FINDER.Login_Forms.Sign_In_Form;
using JOB_FINDER.User_controls;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace JOB_FINDER.Employee_Forms
{
    public partial class JobSearch : Form
    {
        public JobSearch()
        {
            InitializeComponent();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_search_title.Clear();
    
        }

        Connection searchcon = new Connection();
        Sign_In sign = new Sign_In();
        SqlConnection con;
        string jobTitle;
        string JobSKill;
        string JobEducation;
        string JobExperince;
        
        private void UserControlGeneratorForYou()
        {
            pnl_JobListings_Search.Controls.Clear();
            DataTable dt = GetData();

            if (dt != null && dt.Rows.Count > 0)
            {
                JobListingEmployeeSearch[] listItems = new JobListingEmployeeSearch[dt.Rows.Count];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow row = dt.Rows[i];
                    JobListingEmployeeSearch jobListing = new JobListingEmployeeSearch();

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

                pnl_JobListings_Search.Controls.AddRange(listItems);
            }
        }
        public DataTable readItems()
        {
            if (ConnectionState.Closed == con.State)
            {
                con.Open();
            }
            string query = "SELECT * FROM tbl_job JOIN tbl_company_acc ON tbl_job.job_vender_email = tbl_company_acc.com_email where tbl_job.job_title like @JobTitle";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("JobTitle", "%" + txt_search_title.Text + "%");
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

        private void JobSearch_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(searchcon.connection.ConnectionString);
            UserControlGeneratorForYou();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            UserControlGeneratorForYou();
   
        }
    }
}
