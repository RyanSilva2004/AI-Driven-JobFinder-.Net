using JOB_FINDER.Login_Forms.Sign_In_Form;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JOB_FINDER.Login_Forms.Company_Sign_Up
{
    public partial class com_number : Form
    {
        string email;
        public com_number(string CompanyEmail)
        {
            InitializeComponent();
            email = CompanyEmail;
        }
        String OTP;
        SqlConnection con;
        SqlCommand cmd;
        private void lbl_error_Click(object sender, EventArgs e)
        {

        }

        private void com_number_Load(object sender, EventArgs e)
        {
            Connection signupcon = new Connection();
            con = new SqlConnection(signupcon.connection.ConnectionString);
            btn_verify.Enabled = false;
            btn_save.Enabled = false;
            lbl_error.Visible = false;
        }

        private void btn_sendotp_Click(object sender, EventArgs e)
        {
            Regex phonePattern = new Regex(@"^(\+?\d{1,3}[- ]?)?\d{10}$");
            if (txt_num.Text.Length == 0)
            {
                MessageBox.Show("Phone number canot empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_num.Focus();
            }
            else if (!phonePattern.IsMatch(txt_num.Text))
            {
                MessageBox.Show("Enter Valid Phone Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_num.Focus();
            }
            else
            {
                SendMessage();
            }
        }
        private void SendMessage()
        {
            string result;
            string apiKey = "olmPneTktY6FDnUIJPE2";
            string user_id = "25275";
            string numbers = txt_num.Text;
            string sender_id = "NotifyDEMO";

            Random rand = new Random();
            OTP = rand.Next(100000, 999999).ToString();

            string message = $"Your Verification Code For Huztly " + OTP;

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
                    txt_otp.Enabled = true;
                    btn_verify.Enabled = true;
                    txt_num.Enabled = false;
                }
                MessageBox.Show("OTP Sent Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending OTP: " + ex.Message);
            }
        }

        private void btn_verify_Click(object sender, EventArgs e)
        {
            if (txt_otp.Text == OTP)
            {
                btn_save.Enabled = true;
                btn_sendotp.Enabled = false;
                MessageBox.Show("Verified","Infromation",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Incorrect OTP");
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            lbl_error.Visible = false;
            if(txt_location.Text.Length == 0)
            {
                lbl_error.Text = "Please Enter Location";
                lbl_error.Visible = true;
                txt_location.Focus();
            }
            else if(rich_txt_discrption.Text.Length == 0)
            {
                lbl_error.Text = "Please Enter Company Discription";
                lbl_error.Visible = true;
                rich_txt_discrption.Focus();
            }

            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("UPDATE tbl_company_acc set com_tp = @tp,com_location = @location,com_description = @description where com_email = @email", con);
                    cmd.Parameters.AddWithValue("@tp", txt_num.Text);
                    cmd.Parameters.AddWithValue("@location",txt_location.Text);
                    cmd.Parameters.AddWithValue("@description", rich_txt_discrption.Text);
                    cmd.Parameters.AddWithValue("@email", email);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 1)
                    {
                        DialogResult result = MessageBox.Show("Sign Up Successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                        {
                            Sign_In sign_In = new Sign_In();
                            sign_In.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Oops! Page cannot found.", "404 — Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                /* catch (SqlException)
                 {
                     MessageBox.Show("Access Denied - Error 403", "403 — Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }*/
                catch (SqlException ex)
                {
                    MessageBox.Show($"SQL Exception: {ex.Message}\nStackTrace: {ex.StackTrace}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (TaskCanceledException)
                {
                    MessageBox.Show("408 — Request Timeout.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
                
            
        }
    }
}


