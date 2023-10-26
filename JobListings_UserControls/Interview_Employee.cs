using JOB_FINDER.Company_Forms.Company_ViewApplications;
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
    public partial class Interview_Employee : UserControl
    {
        public Interview_Employee()
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
        private string _JobInterviewDate;
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

        string Date;
        public String JobInterviewDate 
        {           
            get { return _JobInterviewDate; }
            set { _JobInterviewDate = value; Date = value; }
        }

        private void CheckDate() 
        {
            if(Date.Length == 0) 
            {
                lbl_InterviewDate.Text = "Not Assigned";
                pic_pending.Visible = true;
                pic_verified.Visible = false;
                lbl_status.Text = "Pending";
            }
            else 
            {
                lbl_InterviewDate.Text = Date;
                pic_verified.Visible = true;
                pic_pending.Visible = false;
                lbl_status.Text = "Selected";
            }
        }

        private void Interview_Employee_Load(object sender, EventArgs e)
        {
            CheckDate();
            JobEducationLabelFix();
            JobSkillLabelFix();
        }

        private void JobEducationLabelFix()
        {
            if (lbl_JobSkill.Text != null)
            {
                originalText = lbl_JobEducation.Text;

                if (originalText.Length > 20)
                {
                    lbl_JobEducation.Text = originalText.Substring(0, 20) + "...";
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

                if (originalText.Length > 20)
                {
                    lbl_JobSkill.Text = originalText.Substring(0, 20) + "...";
                }
                else
                {
                    lbl_JobSkill.Text = originalText;
                }
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
    }
}
