using JOB_FINDER.Company_Forms.Company_ViewApplications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JOB_FINDER.Company_Forms.Job_Listings.Post_Job
{
    public partial class EditJob_Listings : Form
    {
        string JobID;
        public EditJob_Listings(String job_id)
        {
            InitializeComponent();
            JobID = job_id;
        }
        Connection editjobscon = new Connection();
        SqlConnection con;
        SqlCommand cmd;
        JobListings obj;

        private void showJobData(String JobID) 
        {
            con.Open();
            cmd = new SqlCommand("Select * from tbl_job where job_id = '" + JobID + "'", con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                
                txt_jobtitle.Text = reader["job_title"].ToString();
                txt_jobdescription.Text = reader["job_description"].ToString();
                txt_jobeducation.Text = reader["job_education"].ToString();
                txt_jobskill.Text = reader["job_skill"].ToString();
                txt_jobsalary.Text = reader["job_salary"].ToString();
                string jobtype = reader["job_type"].ToString();
                if (jobtype == "Full Time")
                {
                    rb_fulltime.Checked = true;
                }
                else if (jobtype == "Part Time") 
                {
                    rb_partime.Checked = true;
                }               
            }
            else
            {
                MessageBox.Show("Job Not Found or Username Is Incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void EditJob_Listings_Load(object sender, EventArgs e)
        {
           con = new SqlConnection(editjobscon.connection.ConnectionString);
           showJobData(JobID);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_jobtitle.Text))
            {
                MessageBox.Show("Please enter the job title.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_jobtitle.Focus();
                return;
            }
            if (!txt_jobtitle.Text.Any(Char.IsLetter))
            {
                MessageBox.Show("Please enter a valid job title.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_jobtitle.Focus();
                return;
            }
            if (cmb_jobexperince.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the job experience.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_jobexperince.Focus();
                return;
            }
            decimal salary;
            if (string.IsNullOrEmpty(txt_jobsalary.Text) || !decimal.TryParse(txt_jobsalary.Text, out salary))
            {
                MessageBox.Show("Please enter a valid number for the job salary.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_jobsalary.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_jobeducation.Text))
            {
                MessageBox.Show("Please enter the requierd job education.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_jobskill.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_jobskill.Text))
            {
                MessageBox.Show("Please enter the job skill.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_jobskill.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_jobdescription.Text))
            {
                MessageBox.Show("Please enter the job description.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_jobdescription.Focus();
                return;
            }
            else
            {
                con.Open();
                cmd = new SqlCommand("update tbl_job set job_title = @JobTitle , job_type = @JobType , job_education = @JobEducation , job_salary = @JobSalary , job_skill = @JobSkill ,job_experience = @JobExp , job_description = @JobDescription where  job_id = @JobID", con);
                cmd.Parameters.AddWithValue("@JobTitle", txt_jobtitle.Text);
                cmd.Parameters.AddWithValue("@JobType", rb_fulltime.Checked ? "Full Time" : "Part Time");
                cmd.Parameters.AddWithValue("@JobEducation", txt_jobeducation.Text);
                cmd.Parameters.AddWithValue("@JobSalary", txt_jobsalary.Text);
                cmd.Parameters.AddWithValue("@JobSkill", txt_jobskill.Text);
                cmd.Parameters.AddWithValue("@JobExp", cmb_jobexperince.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@JobDescription", txt_jobdescription.Text);
                cmd.Parameters.AddWithValue("@JobID", JobID);

                try
                {
                    if (MessageBox.Show("Are you sure you want to update this job?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Job updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No job found with the given ID.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                }
                catch (SqlException sqlex)
                {
                    MessageBox.Show(sqlex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (OutOfMemoryException oomex)
                {
                    MessageBox.Show(oomex.Message, "Out of Memory Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    obj = (JobListings)this.ParentForm;
                    obj.UserControlGeneratorCompany();
                    con.Close();
                    this.Hide();                    
                }
            }
        }
    }
}
