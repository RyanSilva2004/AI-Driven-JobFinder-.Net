using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace JOB_FINDER.Company_Forms.View_Applications
{
    public partial class SheduleInterview : Form
    {
        string JobID;
        string ApplicantEmail;
        string ApplicantName;
        string ApplicantPhone;
        public SheduleInterview(string JobID,string ApplicantEmail,string ApplicantName,string Telephone)
        {
            InitializeComponent();
            this.JobID = JobID;
            this.ApplicantEmail = ApplicantEmail;
            this.ApplicantName = ApplicantName;
            this.ApplicantPhone = Telephone;
        }
        Connection sheduleinterviewcon = new Connection();
        SqlConnection con;
        SqlCommand cmd;

        private void SheduleInterview_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(sheduleinterviewcon.connection.ConnectionString);
        }

        private void btn_sheduleinterview_Click(object sender, EventArgs e)
        {
            // Combine the date and time values from both controls
            DateTime date = datepicker.Value.Date + timepicker.Value.TimeOfDay;
            DateTime today = DateTime.Today;
            DateTime fiveMonths = today.AddMonths(5);
            if (date < today || date > fiveMonths)
            {
                MessageBox.Show("The date must be within five months and not older than today.");
                return;
            }
            try
            {
                con.Open();
                cmd = new SqlCommand("update tbl_applicantation set app_status = 'Selected' , app_interviewdate = @InterviewDate where  app_jobid = @JobID and app_applicantemail = @ApplicantEmail", con);
                cmd.Parameters.AddWithValue("@InterviewDate", date);
                cmd.Parameters.AddWithValue("@JobID", JobID);
                cmd.Parameters.AddWithValue("@ApplicantEmail", ApplicantEmail);
                int status = cmd.ExecuteNonQuery();
                if (status == 1)
                {
                    MessageBox.Show("Interview Sheduled Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SendMessage(ApplicantName, ApplicantPhone);
                    this.Hide();
                }
                con.Close();
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show("A SQL error occurred: " + sqlex.Message);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                con.Close();
            }
        }


        private void SendMessage(string ApplicantName, string Telephone)
        {
            string result;
            string apiKey = "olmPneTktY6FDnUIJPE2";
            string user_id = "25275";
            string numbers = Telephone;
            string sender_id = "NotifyDEMO";

            string message = $"Hi "+ApplicantName+" New Interview Is Sheduled Check The Huztly Application";

            string url = $"https://app.notify.lk/api/v1/send?user_id={user_id}&api_key={apiKey}&sender_id={sender_id}&to={numbers}&message={message}";
            HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url);
            objRequest.Method = "POST";

            try
            {
                HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();
                using (StreamReader sr = new StreamReader(objResponse.GetResponseStream()))
                {
                    result = sr.ReadToEnd();
                    sr.Close();                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending Notify Message To Applicant : " + ex.Message);
            }
        }

    }
}
