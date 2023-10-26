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
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace JOB_FINDER.Login_Forms
{
    public partial class GetMobileNumber : Form
    {
        string email;
        public GetMobileNumber(String AccountEmail)
        {
            InitializeComponent();
            email = AccountEmail;
        }
        String OTP;
        SqlConnection con;
        SqlCommand cmd;
        private void GetMobileNumber_Load(object sender, EventArgs e)
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
            }
            else
            {
                MessageBox.Show("Incorrect OTP");
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(txt_nic.Text.Length == 0)
            {
                lbl_error.Visible = true;
                lbl_error.Text = "Please Input NIC";
            }
            else if(combo_gender.SelectedIndex == -1)
            {
                lbl_error.Visible = true;
                lbl_error.Text = "Please Select Gender";
            }
            else if (txt_nic.Text.Length < 9 || txt_nic.Text.Length > 12 || txt_nic.Text.Any(c => !char.IsDigit(c) && !(c == 'V' || c == 'v')))
            {
                throw new FormatException("NIC number should contain between 9 and 12 characters with or without the letter 'V' at the end (uppercase or lowercase).");
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("UPDATE tbl_acc set acc_tp = @tp, acc_nic = @nic,acc_gender = @gender  where acc_email = @email", con);
                    cmd.Parameters.AddWithValue("@tp", txt_num.Text);
                    cmd.Parameters.AddWithValue("@nic", txt_nic.Text);
                    cmd.Parameters.AddWithValue("@gender",combo_gender.SelectedItem.ToString());
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
                catch (SqlException)
                {
                    MessageBox.Show("Access Denied - Error 403", "403 — Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
