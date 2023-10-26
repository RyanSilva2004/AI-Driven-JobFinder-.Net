using iTextSharp.text.pdf;
using OpenAI_API.Moderation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using JOB_FINDER.Company_Forms.View_Applications;

namespace JOB_FINDER.JobListings_UserControls
{
    public partial class JobApplicants : UserControl
    {
        public JobApplicants()
        {
            InitializeComponent();
        }
        Connection applicantshowcon = new Connection();
        SqlConnection con;
        SqlCommand cmd;

        private string JobID;
        private string _Name;
        private string _Email;
        private string _Title;
        private string _Skill;
        private string _Education;
        private string _Experince;

        public void GetJobID(string ID)
        {
           JobID = ID;
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; lbl_applicantname.Text = value; }
        }

        public string Email
        {
            get { return _Email; }
            set { _Email = value; lbl_applicantemail.Text = value; }
        }

        public string Title
        {
            get { return _Title; }
            set { _Title = value; lbl_applicanttitle.Text = value; }
        }

        public string Skill
        {
            get { return _Skill; }
            set { _Skill = value; lbl_applicantskill.Text = value; }
        }

        public string Education
        {
            get { return _Education; }
            set { _Education = value; lbl_applicanteducation.Text = value; }
        }

        public string Experince
        {
            get { return _Experince; }
            set { _Experince = value; lbl_applicantexp.Text = value; }
        }

        string TP;
        public void getTP(string TP) 
        {
            this.TP = TP;
        }

        private void btn_viewpdf_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("select cv_pdf from tbl_cv where cv_email = @applicantemail", con);
                cmd.Parameters.AddWithValue("applicantemail", lbl_applicantemail.Text);
                object pdf = cmd.ExecuteScalar();
                byte[] pdfData = null; 
                if (pdf != null && pdf is byte[])
                {
                    pdfData = (byte[])pdf;
                }
                if (pdfData != null && pdfData.Length > 0)
                {
                    string tempFileName = Path.GetTempFileName() + ".pdf";
                    File.WriteAllBytes(tempFileName, pdfData);
                    Process.Start(tempFileName);
                }
                else
                {
                    MessageBox.Show("No PDF found for " + lbl_applicantemail.Text);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void JobApplicants_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(applicantshowcon.connection.ConnectionString);
            CheckApplicationStatus();
        }

        private void btn_sheduleinterview_Click(object sender, EventArgs e)
        {
            SheduleInterview obj = new SheduleInterview(JobID,lbl_applicantemail.Text,lbl_applicantname.Text,TP);
            obj.Show();
            CheckApplicationStatus();
        }

        private void CheckApplicationStatus()
        {
            con.Open();
            cmd = new SqlCommand("select app_interviewdate from tbl_applicantation where app_applicantemail = @ApplicantEmail and app_jobid = @JobID ", con);
            cmd.Parameters.AddWithValue("ApplicantEmail",lbl_applicantemail.Text);
            cmd.Parameters.AddWithValue("JobID", JobID);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                DateTime? interviewDate = reader["app_interviewdate"] as DateTime?;
                if (interviewDate != null)
                {
                    btn_sheduleinterview.Text = "Interview Sheduled";
                    btn_sheduleinterview.Enabled = false;
                }
            }
            con.Close();
            CheckApplicationStatus();
        }
    }
}
