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

namespace JOB_FINDER.JobListings_UserControls
{
    public partial class Interview_Compnay : UserControl
    {
        public Interview_Compnay()
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
        private string _InterviewDate;

        public void GetJobID(string ID)
        {
            JobID = ID;
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; lbl_name.Text = value; }
        }

        public string Email
        {
            get { return _Email; }
            set { _Email = value; lbl_email.Text = value; }
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

        public string InterviewDate
        {
            get { return _InterviewDate; }
            set { _InterviewDate = value; lbl_InterviewDate.Text = value; }
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
    }
}
