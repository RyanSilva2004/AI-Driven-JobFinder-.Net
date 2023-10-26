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
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace JOB_FINDER.Company_Forms.View_Applications
{
    public partial class ViewApplications : Form
    {
        public ViewApplications()
        {
            InitializeComponent();
        }
        Connection viewapplication= new Connection();
        Sign_In login = new Sign_In();
        SqlConnection con;
        SqlCommand cmd;
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
                    jobListing.HideButtons();
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

        public DataTable ReadItemsApplications(string JobID)
        {
            con = new SqlConnection(viewapplication.connection.ConnectionString);
            if (ConnectionState.Closed == con.State)
            {
                con.Open();
            }

            String query = "SELECT * FROM tbl_applicantation JOIN tbl_acc ON tbl_applicantation.app_applicantemail = tbl_acc.acc_email JOIN tbl_cv ON tbl_cv.cv_email = tbl_acc.acc_email WHERE tbl_applicantation.app_jobid =@JobID";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("JobID", JobID);
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

        public DataTable GetDataApplications(string JobID)
        {
            try
            {
                return ReadItemsApplications(JobID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public void UserControlGeneratorApplications(string JobID)
        {
            pnl_applications.Controls.Clear();
            DataTable dt = GetDataApplications(JobID);

            if (dt != null && dt.Rows.Count > 0)
            {
                JobApplicants[] listItems = new JobApplicants[dt.Rows.Count];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow row = dt.Rows[i];
                    JobApplicants jobListing = new JobApplicants();
                    // Fill Data To Job Listings
                    jobListing.Name = row["acc_name"].ToString();
                    jobListing.Title = row["cv_jobtitle"].ToString();
                    jobListing.Skill = row["cv_jobskill"].ToString();
                    jobListing.Education = row["cv_education"].ToString();
                    jobListing.Experince = row["cv_jobexperience"].ToString();
                    jobListing.Email = row["cv_email"].ToString();
                    jobListing.GetJobID(JobID);
                    jobListing.getTP(row["acc_tp"].ToString());
                    listItems[i] = jobListing;
                }
                pnl_applications.Controls.AddRange(listItems);
            }
        }
        public void SetJobID(String JobID)
        {
            UserControlGeneratorApplications(JobID);
        }
        private void ViewApplications_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(viewapplication.connection.ConnectionString);
            UserControlGeneratorCompany();
        }
    }
}
