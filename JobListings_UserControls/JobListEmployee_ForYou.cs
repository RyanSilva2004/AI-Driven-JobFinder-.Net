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
    public partial class JobListEmployee_ForYou : UserControl
    {
        public JobListEmployee_ForYou()
        {
            InitializeComponent();
        }

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

        private void JobListEmployee_ForYou_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(joblistconnection.connection.ConnectionString);
            CheckApplicationStatus();
            lbl_jobid.Visible = false;
            JobSkillLabelFix();
            JobEducationLabelFix();
        }

        private void btn_appl_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("insert into tbl_applicantation (app_companyemail,app_applicantemail,app_applieddate) values (@JobVendorEmail,@EmpEmail,@Date)", con);
            cmd.Parameters.AddWithValue("JobVendorEmail", _JobVendorEmail);
            cmd.Parameters.AddWithValue("EmpEmail", sign.getemail());
            cmd.Parameters.AddWithValue("Date", DateTime.Today.ToString());
            int status = cmd.ExecuteNonQuery();
            con.Close();  
            if (status == 1)
            {
                MessageBox.Show("Applied For Job Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error");
            }
            CheckApplicationStatus();
            
        }

        private void CheckApplicationStatus()
        {
            con.Open();
            cmd = new SqlCommand("select * from tbl_applicantation where app_applicantemail = @ApplicantEmail and app_jobid = @JobID ", con);
            cmd.Parameters.AddWithValue("ApplicantEmail", sign.getemail());
            cmd.Parameters.AddWithValue("JobID", lbl_jobid.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                btn_appl.Text = "Applied";
                btn_appl.Enabled = true;
            }
            else
            {
                btn_appl.Enabled = false;
            }
            con.Close();
        }

        private void JobEducationLabelFix()
        {
            if (lbl_JobSkill.Text != null)
            {
                originalText = lbl_JobEducation.Text;

                if (originalText.Length > 15)
                {
                    lbl_JobEducation.Text = originalText.Substring(0, 15) + "...";
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

                if (originalText.Length > 15)
                {
                    lbl_JobSkill.Text = originalText.Substring(0, 15) + "...";
                }
                else
                {
                    lbl_JobSkill.Text = originalText;
                }
            }
        }
        bool isClicked = false;
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

    }
}
