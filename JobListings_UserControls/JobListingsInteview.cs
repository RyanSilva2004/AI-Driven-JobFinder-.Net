using JOB_FINDER.Company_Forms.Company_ViewApplications;
using JOB_FINDER.Company_Forms.View_Applications;
using JOB_FINDER.Company_Forms.View_Interviews;
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
    public partial class JobListingsInteview : UserControl
    {
        public JobListingsInteview()
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
        public String JobSalary
        {
            get { return _JobSalary; }
            set { _JobSalary = value; lbl_JobSalary.Text = "$" + value; }
        }
        public String JobType
        {
            get { return _JobType; }
            set { _JobType = value; lbl_jobtype.Text = value; }
        }

        public String JobSkill
        {
            get { return _JobSkill; }
            set { _JobSkill = value; lbl_JobSkill.Text = value; }
        }
        public String JobVendorTP
        {
            get { return _JobVendorTP; }
            set { _JobVendorTP = value; }
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

        private void btn_viewinterviews_Click(object sender, EventArgs e)
        {
            ViewInterviews x = (ViewInterviews)this.ParentForm;
            x.SetJobID(lbl_jobid.Text);
        }
    }
}
