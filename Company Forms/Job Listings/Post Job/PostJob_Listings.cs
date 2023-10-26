using JOB_FINDER.Company_Forms.Company_ViewApplications;
using JOB_FINDER.Login_Forms.Sign_In_Form;
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
    public partial class PostJob_Listings : Form
    {
        public PostJob_Listings()
        {
            InitializeComponent();
        }
        Connection postjobscon = new Connection();
        SqlConnection con;
        SqlCommand cmd;
        Sign_In login = new Sign_In();
        JobListings obj;

        private void btn_post_Click(object sender, EventArgs e)
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
                cmd = new SqlCommand("insert into tbl_job (job_title, job_type, job_education, job_salary, job_skill, job_experience, job_description,job_vender_email) values (@JobTitle, @JobType, @JobEducation, @JobSalary, @JobSkill, @JobExp, @JobDescription,@CompanyEmail)", con);
                cmd.Parameters.AddWithValue("@CompanyEmail", login.getemail());
                cmd.Parameters.AddWithValue("@JobTitle", txt_jobtitle.Text);
                cmd.Parameters.AddWithValue("@JobType", rb_fulltime.Checked ? "Full Time" : "Part Time");
                cmd.Parameters.AddWithValue("@JobEducation", txt_jobeducation.Text);
                cmd.Parameters.AddWithValue("@JobSalary", txt_jobsalary.Text);
                cmd.Parameters.AddWithValue("@JobSkill", txt_jobskill.Text);
                cmd.Parameters.AddWithValue("@JobExp", cmb_jobexperince.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@JobDescription", txt_jobdescription.Text);

                try
                {
                    if (MessageBox.Show("Are you sure you want to post this job?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int status = cmd.ExecuteNonQuery();

                        if (status > 0)
                        {
                            MessageBox.Show("Job Posted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Unable To Post Job Successfully", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void PostJob_Listings_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(postjobscon.connection.ConnectionString);
        }
    }
}
