using JOB_FINDER.Company_Forms.Company_ViewApplications;
using JOB_FINDER.Company_Forms.Job_Listings.Post_Job;
using JOB_FINDER.Company_Forms.View_Applications;
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

namespace JOB_FINDER.JobListings_UserControls
{
    public partial class JobListCompany_ListedJobscs : UserControl
    {
        public JobListCompany_ListedJobscs()
        {
            InitializeComponent();
        }
        bool isClicked = false;
        SqlConnection con;
        SqlCommand cmd;
        Connection joblistconnection = new Connection();
        Sign_In sign = new Sign_In();
        private string _JobID;
        private string _JobTitle;
        private string _JobVendor;
        private string _JobSalary;
        private string _JobType;
        private string _JobSkill;
        private string _JobVendorEmail;
        private string _JobVendorTP;
        private string _JobDescription;
        private string _JobLocation;
        private string _JobEducation;
        private string _JobExperince;
        string originalText;
        JobListings obj;
        public string JobID
        {
            get { return _JobID; }
            set { _JobID = value; lbl_jobid.Text = value; }
        }
        public String JobTitle
        {
            get { return _JobTitle; }
            set { _JobTitle = value; lbl_JobTitle.Text = value; }
        }

        public string JobVendor
        {
            get { return _JobVendor; }
            set { _JobVendor = value; lbl_JobVendorName.Text = value; }
        }

        public String JobSalary
        {
            get { return _JobSalary; }
            set { _JobSalary = value; lbl_JobSalary.Text = "$" + value; }
        }

        public String JobType
        {
            get { return _JobType; }
            set { _JobType = value; lbl_JobType.Text = value; }
        }

        public String JobSkill
        {
            get { return _JobSkill; }
            set { _JobSkill = value; lbl_JobSkill.Text = value; }
        }

        public String JobVendorEmail
        {
            get { return _JobVendorEmail; }
            set { _JobVendorEmail = value; lbl_JobVendorEmail.Text = value; }
        }

        public String JobVendorTP
        {
            get { return _JobVendorTP; }
            set { _JobVendorTP = value; }
        }

        public String JobDescription
        {
            get { return _JobDescription; }
            set { _JobDescription = value; txt_JobDescription.Text = value; }
        }

        public String JobLocation
        {
            get { return _JobLocation; }
            set { _JobLocation = value; lbl_JobLocation.Text = value; }
        }

        public String JobEducation
        {
            get { return _JobEducation; }
            set { _JobEducation = value; lbl_JobEducation.Text = value; }
        }

        public String JobExperince
        {
            get { return _JobExperince; }
            set { _JobExperince = value; lbl_JobExperince.Text = value; }
        }

        private void JobListCompany_ListedJobscs_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(joblistconnection.connection.ConnectionString);
            lbl_jobid.Visible = false;
            JobSkillLabelFix();
            JobEducationLabelFix();
            lbl_fix.Text = "";
        }

        public void HideButtons() 
        {
            btn_delete.Visible = false;
            btn_edit.Visible = false;
        }
        private void lbl_JobSkill_Click(object sender, EventArgs e)
        {
            isClicked = !isClicked;
            if (isClicked)
            {
                lbl_fix.Text = "Job Skill " + originalText;
                lbl_fix.Visible = true;
            }
            else
            {
                lbl_fix.Visible = false;
            }
        }

        private void lbl_JobEducation_Click(object sender, EventArgs e)
        {
            isClicked = !isClicked;
            if (isClicked)
            {
                lbl_fix.Text = "Job Education " + originalText;
                lbl_fix.Visible = true;
            }
            else
            {
                lbl_fix.Visible = false;
            }
        }

        private void JobEducationLabelFix()
        {
            if (lbl_JobSkill.Text != null)
            {
                originalText = lbl_JobEducation.Text;

                if (originalText.Length > 25)
                {
                    lbl_JobEducation.Text = originalText.Substring(0, 25) + "...";
                }
                else
                {
                    lbl_JobEducation.Text = originalText;
                }
            }
        }

        private void JobSkillLabelFix()
        {
            if (lbl_JobSkill.Text != null)
            {
                originalText = lbl_JobSkill.Text;

                if (originalText.Length > 25)
                {
                    lbl_JobSkill.Text = originalText.Substring(0, 25) + "...";
                }
                else
                {
                    lbl_JobSkill.Text = originalText;
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this job listing?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("delete tbl_job where job_id = '" + lbl_jobid.Text + "'",con);
                    int status = cmd.ExecuteNonQuery();
                    if (status == 1)
                    {
                        MessageBox.Show("Job Listing Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Unable To Delete Job Listing", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                    obj = (JobListings)this.ParentForm;
                    obj.UserControlGeneratorCompany();
                }
            }

        }
        private void btn_viewapplications_Click(object sender, EventArgs e)
        {
            ViewApplications x = (ViewApplications)this.ParentForm;
            x.SetJobID(lbl_jobid.Text);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            EditJob_Listings x = new EditJob_Listings(lbl_jobid.Text);
            obj = (JobListings)this.ParentForm;
            obj.openChildForm(x);
        }

        
    }
}
