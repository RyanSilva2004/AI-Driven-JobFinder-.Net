using JOB_FINDER.JobListings_UserControls;
using JOB_FINDER.Login_Forms.Sign_In_Form;
using JOB_FINDER.User_controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JOB_FINDER.Employee_Forms.For_You
{
    public partial class ForYou : Form
    {
        public ForYou()
        {
            InitializeComponent();
        }
        Connection foryoucon = new Connection();
        Sign_In sign = new Sign_In();
        SqlConnection con;
        string jobTitle;
        string JobSKill;
        string JobEducation;
        string JobExperince;

        private void ReadCvDetails()
        {
            con.Open();
            string sqlQuery = "SELECT * FROM tbl_cv WHERE cv_email = @Email";
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            cmd.Parameters.AddWithValue("@Email", sign.getemail());

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    jobTitle = reader["cv_jobtitle"].ToString();
                    JobSKill = reader["cv_jobskill"].ToString();
                    JobEducation = reader["cv_education"].ToString();
                    JobExperince = reader["cv_jobexperience"].ToString();
                }
            }
            con.Close();
        }

        private void UserControlGeneratorForYou()
        {
            pnl_joblistings_foryou.Controls.Clear();
            DataTable dt = GetData();

            if (dt != null && dt.Rows.Count > 0)
            {
                JobListEmployee_ForYou[] listItems = new JobListEmployee_ForYou[dt.Rows.Count];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow row = dt.Rows[i];
                    JobListEmployee_ForYou jobListing = new JobListEmployee_ForYou();

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

                pnl_joblistings_foryou.Controls.AddRange(listItems);
            }
        }
        public DataTable readItems()
        {
            if (ConnectionState.Closed == con.State)
            {
                con.Open();
            }
            string query = "select * from tbl_job join tbl_company_acc on tbl_job.job_vender_email = tbl_company_acc.com_email where job_title like @JobTitle and (job_education like @JobEducation or job_skill like @JobSkill) and job_experience like @JobExperince order by job_salary desc";
            //string query = "select * from tbl_job join tbl_company_acc on tbl_job.job_vender_email = tbl_company_acc.com_email where job_title like @JobTitle and job_experience like @JobExperince or job_education like @JobEducation or job_skill = @JobSkill";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("JobTitle", "%" + jobTitle + "%");
            cmd.Parameters.AddWithValue("JobEducation", "%" + JobEducation + "%");
            cmd.Parameters.AddWithValue("JobSkill", "%" + JobSKill + "%");
            cmd.Parameters.AddWithValue("JobExperince", "%" + JobExperince + "%");
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
        private void ForYou_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(foryoucon.connection.ConnectionString);
            ReadCvDetails();
            UserControlGeneratorForYou();
        }
    }
}
