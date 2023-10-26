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

namespace JOB_FINDER.Employee_Forms.Interviews
{
    public partial class Employee_Interviews : Form
    {
        public Employee_Interviews()
        {
            InitializeComponent();
        }
        Connection appliedjobscon = new Connection();
        Sign_In login = new Sign_In();
        SqlConnection con;
        SqlCommand cmd;
 
        // Interviews
        public DataTable GetDataInterviews()
        {
            try
            {
                return ReadItemsInterviews();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public void UserControlGeneratorInterviews()
        {
            pnl_appliedjobs.Controls.Clear();
            DataTable dt = GetDataInterviews();

            if (dt != null && dt.Rows.Count > 0)
            {
               Interview_Employee[] listItems = new Interview_Employee[dt.Rows.Count];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow row = dt.Rows[i];
                    Interview_Employee jobListing = new Interview_Employee();
                    // Fill Data To Job Listings
                    jobListing.Name = row["acc_name"].ToString();
                    jobListing.JobVendorEmail = row["app_companyemail"].ToString();
                    jobListing.JobType = row["job_type"].ToString();
                    jobListing.JobEducation = row["job_education"].ToString();
                    jobListing.JobExperince = row["job_experience"].ToString();
                    jobListing.JobInterviewDate = row["app_interviewdate"].ToString();
                    jobListing.JobDescription = row["job_description"].ToString();
                    jobListing.JobSalary = row["job_salary"].ToString();
                    jobListing.JobType = row["job_type"].ToString();
                    jobListing.JobSkill = row["job_skill"].ToString();
                    listItems[i] = jobListing;
                }
                pnl_appliedjobs.Controls.AddRange(listItems);
            }
        }

        public DataTable ReadItemsInterviews()
        {
            con = new SqlConnection(appliedjobscon.connection.ConnectionString);
            if (ConnectionState.Closed == con.State)
            {
                con.Open();
            }

            String query = "SELECT * FROM tbl_applicantation JOIN tbl_acc ON tbl_applicantation.app_applicantemail = tbl_acc.acc_email JOIN tbl_job ON tbl_job.job_id = tbl_applicantation.app_jobid WHERE tbl_applicantation.app_applicantemail = @email ";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("email",login.getemail());
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
        private void Employee_Interviews_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(appliedjobscon.connection.ConnectionString);
            UserControlGeneratorInterviews();
        }
    }
}
