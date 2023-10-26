using Google.Apis.Auth.OAuth2;
using Newtonsoft.Json;
using OpenAI_API.Moderation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using JOB_FINDER.Login_Forms.Sign_In_Form;
using Guna.UI2.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace JOB_FINDER.Login_Forms.Company_Sign_Up
{
    public partial class Company_SignUp : Form
    {
        const string clientID = "1067203528867-vcvpf7b1i7dolr504tpt8d43lbnrtvb1.apps.googleusercontent.com";
        string redirectURI = string.Format("http://{0}:{1}/", IPAddress.Loopback, GetRandomUnusedPort()); // Replace with your desired redirect URI
        const string clientSecret = "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";
        const string authorizationEndpoint = "https://accounts.google.com/o/oauth2/v2/auth";
        const string tokenEndpoint = "https://www.googleapis.com/oauth2/v4/token";
        const string userInfoEndpoint = "https://www.googleapis.com/oauth2/v3/userinfo";
        private const string SmtpServer = "smtp.elasticemail.com"; // Replace with your Azure SMTP server name
        private const int SmtpPort = 2525; // Replace with your Azure SMTP port number
        private const string SmtpUsername = "ebayhelpdesksl@gmail.com"; // Replace with your Azure SMTP username
        private const string SmtpPassword = "8B91F007187CD8EA5525D79C62BCD4D90ECA"; // Replace with your Azure SMTP password
        public Company_SignUp()
        {
            InitializeComponent();
            btn_signup.Enabled = false;
            btn_verfy.Enabled = false;
        }
        String OTP;
        SqlConnection con;
        SqlCommand cmd;
        public static int GetRandomUnusedPort()
        {
            var listener = new TcpListener(IPAddress.Loopback, 0);
            listener.Start();
            var port = ((IPEndPoint)listener.LocalEndpoint).Port;
            listener.Stop();
            return port;
        }
        private void bunifuGradientPanel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel13_Click(object sender, EventArgs e)
        {
            Sign_In sign_In = new Sign_In();
            sign_In.Show();
            this.Hide();
        }

        private async void btn_google_Click(object sender, EventArgs e)
        {
            // Generates state and PKCE values.
            string state = randomDataBase64url(32);
            string code_verifier = randomDataBase64url(32);
            string code_challenge = base64urlencodeNoPadding(sha256(code_verifier));
            const string code_challenge_method = "S256";

            // Creates a redirect URI using an available port on the loopback address.
            string redirectURI = string.Format("http://{0}:{1}/", IPAddress.Loopback, GetRandomUnusedPort());
            //output("redirect URI: " + redirectURI);

            // Creates an HttpListener to listen for requests on that redirect URI.
            var http = new HttpListener();
            http.Prefixes.Add(redirectURI);
            //output("Listening..");
            http.Start();

            // Creates the OAuth 2.0 authorization request.
            string authorizationRequest = string.Format("{0}?response_type=code&scope=email%20profile&redirect_uri={1}&client_id={2}&state={3}&code_challenge={4}&code_challenge_method={5}",
                authorizationEndpoint,
                System.Uri.EscapeDataString(redirectURI),
                clientID,
                state,
                code_challenge,
                code_challenge_method);

            // Opens request in the browser.
            System.Diagnostics.Process.Start(authorizationRequest);

            // Waits for the OAuth authorization response.
            var context = await http.GetContextAsync();

            // Brings this app back to the foreground.
            this.Activate();

            // Sends an HTTP response to the browser.
            var response = context.Response;
            string responseString = string.Format("<html><head><meta http-equiv='refresh' content='10;url=https://google.com'></head><body>Please return to the app.</body></html>");
            var buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
            response.ContentLength64 = buffer.Length;
            var responseOutput = response.OutputStream;
            Task responseTask = responseOutput.WriteAsync(buffer, 0, buffer.Length).ContinueWith((task) =>
            {
                responseOutput.Close();
                http.Stop();
                //Console.WriteLine("HTTP server stopped.");
            });

            // Checks for errors.
            if (context.Request.QueryString.Get("error") != null)
            {
                MessageBox.Show(String.Format("OAuth authorization error: {0}.", context.Request.QueryString.Get("error")));
                //output(String.Format("OAuth authorization error: {0}.", context.Request.QueryString.Get("error")));
                return;
            }
            if (context.Request.QueryString.Get("code") == null
                || context.Request.QueryString.Get("state") == null)
            {
                MessageBox.Show("Malformed authorization response. " + context.Request.QueryString);
                //output("Malformed authorization response. " + context.Request.QueryString);
                return;
            }

            // extracts the code
            var code = context.Request.QueryString.Get("code");
            var incoming_state = context.Request.QueryString.Get("state");

            // Compares the receieved state to the expected value, to ensure that
            // this app made the request which resulted in authorization.
            if (incoming_state != state)
            {
                MessageBox.Show(String.Format("Received request with invalid state ({0})", incoming_state));
                //output(String.Format("Received request with invalid state ({0})", incoming_state));
                return;
            }

            // Starts the code exchange at the Token Endpoint.
            performCodeExchange(code, code_verifier, redirectURI);
        }
        async void performCodeExchange(string code, string code_verifier, string redirectURI)
        {
            //output("Exchanging code for tokens...");

            // builds the  request
            string tokenRequestURI = "https://www.googleapis.com/oauth2/v4/token";
            string tokenRequestBody = string.Format("code={0}&redirect_uri={1}&client_id={2}&code_verifier={3}&client_secret={4}&scope=&grant_type=authorization_code",
            code,
                System.Uri.EscapeDataString(redirectURI),
                clientID,
                code_verifier,
                clientSecret
                );

            // sends the request
            HttpWebRequest tokenRequest = (HttpWebRequest)WebRequest.Create(tokenRequestURI);
            tokenRequest.Method = "POST";
            tokenRequest.ContentType = "application/x-www-form-urlencoded";
            tokenRequest.Accept = "Accept=text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            byte[] _byteVersion = Encoding.ASCII.GetBytes(tokenRequestBody);
            tokenRequest.ContentLength = _byteVersion.Length;
            Stream stream = tokenRequest.GetRequestStream();
            await stream.WriteAsync(_byteVersion, 0, _byteVersion.Length);
            stream.Close();

            try
            {
                // gets the response
                WebResponse tokenResponse = await tokenRequest.GetResponseAsync();
                using (StreamReader reader = new StreamReader(tokenResponse.GetResponseStream()))
                {
                    // reads response body
                    string responseText = await reader.ReadToEndAsync();
                    //output(responseText);

                    // converts to dictionary
                    Dictionary<string, string> tokenEndpointDecoded = JsonConvert.DeserializeObject<Dictionary<string, string>>(responseText);

                    string access_token = tokenEndpointDecoded["access_token"];
                    userinfoCall(access_token);
                }
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    var response = ex.Response as HttpWebResponse;
                    if (response != null)
                    {
                        MessageBox.Show("HTTP: " + response.StatusCode);
                        //output("HTTP: " + response.StatusCode);
                        using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                        {
                            // reads response body
                            string responseText = await reader.ReadToEndAsync();
                            MessageBox.Show(responseText);
                            //output(responseText);
                        }
                    }
                }
            }
        }
        async void userinfoCall(string access_token)
        {
            //output("Making API Call to Userinfo...");

            // builds the  request
            string userinfoRequestURI = "https://www.googleapis.com/oauth2/v3/userinfo";

            // sends the request
            HttpWebRequest userinfoRequest = (HttpWebRequest)WebRequest.Create(userinfoRequestURI);
            userinfoRequest.Method = "GET";
            userinfoRequest.Headers.Add(string.Format("Authorization: Bearer {0}", access_token));
            userinfoRequest.ContentType = "application/x-www-form-urlencoded";
            userinfoRequest.Accept = "Accept=text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";

            // gets the response
            WebResponse userinfoResponse = await userinfoRequest.GetResponseAsync();
            using (StreamReader userinfoResponseReader = new StreamReader(userinfoResponse.GetResponseStream()))
            {
                // reads response body
                string userinfoResponseText = await userinfoResponseReader.ReadToEndAsync();

                string email = ParseEmailFromResponse(userinfoResponseText);
                string name = ParseNameFromResponse(userinfoResponseText);

                // Generate a random password
                string password = GenerateRandomPassword();

                // Save the details in the SQL database
                SaveDetailsToDatabase(email, password, name);


            }
        }



        private string ParseEmailFromResponse(string responseText)
        {
            try
            {
                dynamic responseJson = JsonConvert.DeserializeObject(responseText);
                string email = responseJson.email;
                return email;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error parsing email from API response: " + ex.Message);
                return string.Empty;
            }
        }
        private string ParseNameFromResponse(string responseText)
        {
            try
            {
                dynamic responseJson = JsonConvert.DeserializeObject(responseText);
                string name = responseJson.name;
                return name;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error parsing name from API response: " + ex.Message);
                return string.Empty;
            }
        }
        private bool IsEmailExists(string email)
        {
            using (con = new SqlConnection("Data Source=projectnibm.database.windows.net;Initial Catalog=jobfinderDB1;Persist Security Info=True;User ID=adm;Password=Dhanuri2003@"))
            {
                con.Open();

                using (cmd = new SqlCommand("SELECT COUNT(*) FROM (" +
                    "SELECT acc_email AS email FROM tbl_acc UNION " +
                    "SELECT com_email AS email FROM tbl_company_acc) AS EmailTable " +
                    "WHERE email = @Email", con))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private string GenerateRandomPassword()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            string password = new string(Enumerable.Repeat(chars, 10)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            return password;
        }

        private void SaveDetailsToDatabase(string email, string password, string name)
        {
            try
            {
                bool emailExists = IsEmailExists(email);
                if (emailExists)
                {
                    MessageBox.Show("An account with this email already exists. Please sign in.", "403 — Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (con = new SqlConnection("Data Source=projectnibm.database.windows.net;Initial Catalog=jobfinderDB1;Persist Security Info=True;User ID=adm;Password=Dhanuri2003@"))
                {
                    con.Open();

                    using (cmd = new SqlCommand("INSERT INTO tbl_company_acc (com_email, com_password , com_name) VALUES (@Email, @Password , @Name)", con))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Name", name);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected == 1)
                        {

                            DialogResult resulti = MessageBox.Show("Sign Up Successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (resulti == DialogResult.OK)
                            {

                                com_number com_Number = new com_number(email);
                                com_Number.Show();
                                this.Hide();
                            }


                            void FirstMethod()
                            {
                                string hiname = name;
                                SecondMethod(hiname); // Call the second method and pass the value of hiname
                            }
                        }
                        else
                        {
                            MessageBox.Show("Oops! Page cannot found.", "404 — Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    con.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Access Denied - Error 403", "403 — Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (TaskCanceledException)
            {
                // Handle timeout exception separately
                MessageBox.Show("408 — Request Timeout.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string SecondMethod(string hiname)
        {
            // Use the value of hiname in this method
            // ... (your code here)

            return hiname; // Return the value if necessary
        }



        /// <summary>
        /// Returns URI-safe data with a given input length.
        /// </summary>
        /// <param name="length">Input length (nb. output will be longer)</param>
        /// <returns></returns>
        public static string randomDataBase64url(uint length)
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] bytes = new byte[length];
            rng.GetBytes(bytes);
            return base64urlencodeNoPadding(bytes);
        }

        /// <summary>
        /// Returns the SHA256 hash of the input string.
        /// </summary>
        /// <param name="inputStirng"></param>
        /// <returns></returns>
        public static byte[] sha256(string inputStirng)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(inputStirng);
            SHA256Managed sha256 = new SHA256Managed();
            return sha256.ComputeHash(bytes);
        }

        /// <summary>
        /// Base64url no-padding encodes the given input buffer.
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public static string base64urlencodeNoPadding(byte[] buffer)
        {
            string base64 = Convert.ToBase64String(buffer);

            // Converts base64 to base64url.
            base64 = base64.Replace("+", "-");
            base64 = base64.Replace("/", "_");
            // Strips padding.
            base64 = base64.Replace("=", "");

            return base64;
        }


        private void btn_get_otp_Click(object sender, EventArgs e)
        {
            //getMobileNumber();
            Regex phonePattern = new Regex(@"^(\+?\d{1,3}[- ]?)?\d{10}$");
            if (txt_number.Text.Length == 0)
            {
                MessageBox.Show("Phone number canot empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_number.Focus();
            }
            else if (!phonePattern.IsMatch(txt_number.Text))
            {
                MessageBox.Show("Enter Valid Phone Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_number.Focus();
            }
            else
            {
                SendMessage();
                btn_verfy.Enabled = true;
            }
        }
        private void SendMessage()
        {
            string result;
            string apiKey = "olmPneTktY6FDnUIJPE2";
            string user_id = "25275";
            string numbers = txt_number.Text;
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
                    btn_verfy.Enabled = true;
                    txt_number.Enabled = false;
                }
                MessageBox.Show("OTP Sent Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending OTP: " + ex.Message);
            }
        }

        private void btn_verfy_Click(object sender, EventArgs e)
        {
            if (txt_otp.Text == OTP)
            {
                btn_signup.Enabled = true;
            }
            else
            {
                MessageBox.Show("Incorrect OTP");
            }
        }

        private void Company_SignUp_Load(object sender, EventArgs e)
        {

        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            {
                Errorlable.Visible = false;


                Regex namePattern = new Regex(@"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z])$");
                Regex regexemail = new Regex(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$");
                Regex passwordregex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$");
                Regex phonePattern = new Regex(@"^(\+?\d{1,3}[- ]?)?\d{10}$");


                if (txt_name.Text.Length == 0)
                {
                    Errorlable.Visible = true;
                    Errorlable.Text = ("Name can not empty");
                    Errorlable.Focus();
                }
                else if (!namePattern.IsMatch(txt_name.Text))
                {
                    Errorlable.Visible = true;
                    Errorlable.Text = ("Wrong Name");
                    Errorlable.Focus();
                }
                else if (txt_email.Text.Length == 0)
                {
                    Errorlable.Visible = true;
                    Errorlable.Text = ("Email cannot be empty");
                    Errorlable.Focus();
                }
                else if (!regexemail.IsMatch(txt_email.Text))
                {
                    Errorlable.Visible = true;
                    Errorlable.Text = ("Wrong email");
                    Errorlable.Focus();
                }
                else if (txt_password.Text.Length == 0)
                {
                    Errorlable.Visible = true;
                    Errorlable.Text = ("Password cannot be empty");
                    Errorlable.Focus();
                }
                else if (!passwordregex.IsMatch(txt_password.Text))
                {
                    Errorlable.Visible = true;
                    Errorlable.Text = ("Enter Valied Password");
                    Errorlable.Focus();
                }
                else if (txt_password.Text != txt_confrom_password.Text)
                {
                    Errorlable.Visible = true;
                    Errorlable.Text = ("Password donnot match");
                    Errorlable.Focus();
                }
                else if (txt_number.Text.Length == 0)
                {
                    Errorlable.Visible = true;
                    Errorlable.Text = ("Phone number canot empty");
                    Errorlable.Focus();
                }
                else if (!phonePattern.IsMatch(txt_number.Text))
                {
                    Errorlable.Visible = true;
                    Errorlable.Text = ("Enter valied Phone");
                    Errorlable.Focus();
                }
                else if (txt_location.Text.Length == 0)
                {
                    Errorlable.Visible = true;
                    Errorlable.Text = ("Location canot empty");
                    Errorlable.Focus();
                }
                else if (rich_txt_discrption.Text.Length == 0)
                {
                    Errorlable.Visible = true;
                    Errorlable.Text = ("Discription canot empty");
                    Errorlable.Focus();
                }
                else
                {
                    try
                    {
                        using (con = new SqlConnection("Data Source=projectnibm.database.windows.net;Initial Catalog=jobfinderDB1;Persist Security Info=True;User ID=adm;Password=Dhanuri2003@"))
                        {
                            con.Open();

                            using (cmd = new SqlCommand("INSERT INTO tbl_company_acc (com_name, com_email, com_tp,com_description,com_location,com_password) VALUES (@name,@email, @telephone_no,@discription,@location,@password)", con))
                            {
                                cmd.Parameters.AddWithValue("@name", txt_name.Text);
                                cmd.Parameters.AddWithValue("@email", txt_email.Text);
                                cmd.Parameters.AddWithValue("@telephone_no", txt_number.Text);
                                cmd.Parameters.AddWithValue("@discription", rich_txt_discrption.Text);
                                cmd.Parameters.AddWithValue("@location", txt_location.Text);
                                cmd.Parameters.AddWithValue("@password", txt_name.Text);

                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected == 1)
                                {

                                    DialogResult resulti = MessageBox.Show("Sign Up Successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    if (resulti == DialogResult.OK)
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
                            con.Close();
                        }
                    }
                    catch (OutOfMemoryException)
                    {
                        MessageBox.Show("Out Of Memory", "Out Of Memory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Wrong Format", "Wrong Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Out Of Memory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            this.txt_password.PasswordChar = '*';
        }

        private void txt_confrom_password_TextChanged(object sender, EventArgs e)
        {
            this.txt_confrom_password.PasswordChar = '*';
        }
    }
}
