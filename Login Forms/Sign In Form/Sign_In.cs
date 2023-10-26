using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using Newtonsoft.Json;
using System.IO;
using System.Security.Cryptography;
using System.Net.Sockets;
using JOB_FINDER.Login_Forms.Sign_Up_Form;
using System.Text.RegularExpressions;
using JOB_FINDER.Employee_Forms;
using JOB_FINDER.Company_Forms;

namespace JOB_FINDER.Login_Forms.Sign_In_Form
{
    public partial class Sign_In : Form
    {
        const string clientID = "1067203528867-vcvpf7b1i7dolr504tpt8d43lbnrtvb1.apps.googleusercontent.com";
        string redirectURI = string.Format("http://{0}:{1}/", IPAddress.Loopback, GetRandomUnusedPort()); // Replace with your desired redirect URI
        const string clientSecret = "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";
        const string authorizationEndpoint = "https://accounts.google.com/o/oauth2/v2/auth";
        const string tokenEndpoint = "https://www.googleapis.com/oauth2/v4/token";
        const string userInfoEndpoint = "https://www.googleapis.com/oauth2/v3/userinfo";
        string connectionString = "Data Source=projectnibm.database.windows.net;Initial Catalog=jobfinderDB1;Persist Security Info=True;User ID=adm;Password=Dhanuri2003@";
        public Sign_In()
        {
            InitializeComponent();
        }
        private string userinfoResponseText = string.Empty;

        SqlConnection con;
        SqlCommand cmd;
        public static String acc_email;
        public string random_number;

        public static int GetRandomUnusedPort()
        {
            var listener = new TcpListener(IPAddress.Loopback, 0);
            listener.Start();
            var port = ((IPEndPoint)listener.LocalEndpoint).Port;
            listener.Stop();
            return port;
        }
   

        private void btn_signin_Click(object sender, EventArgs e)
        {
            lbl_email_error.Visible = false;
            lbl_passowrd_error.Visible = false;
            //Regex namePattern = new Regex(@"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$");
            Regex regexemail = new Regex(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$");
            Regex passwordregex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$");
            //Regex phonePattern = new Regex(@"^(\+?\d{1,3}[- ]?)?\d{10}$");
            string userEmail = txt_email.Text;
            string userPassword = txt_password.Text;
            acc_email = txt_email.Text;
            if(txt_email.Text.Length == 0)
            {
                lbl_email_error.Visible = true;
                lbl_email_error.Text = "Plese Input your Email";   
            }
            else if (!regexemail.IsMatch(txt_email.Text))
            {
                lbl_email_error.Visible = true;
                lbl_email_error.Text = "Plese Input valid Email";
            }
            else if (txt_password.Text.Length == 0)
            {
                lbl_passowrd_error.Visible = true;
                lbl_passowrd_error.Text = "Plese Input your passord";
            }
            else if (!passwordregex.IsMatch(txt_password.Text))
            {
                lbl_passowrd_error.Visible = true;
                lbl_passowrd_error.Text = "Plese Input valid passord";
            }
            // Check if the user input email and password are in tbl_company_acc
           else if (IsUserInCompanyAccountTable(userEmail, userPassword))
            {
                Company_Menu companyForm = new Company_Menu();
                companyForm.Show();
                this.Hide();
            }
            // Check if the user input email and password are in tbl_acc
            else if (IsUserInAccTable(userEmail, userPassword))
            {
                Employee_menu employeeForm = new Employee_menu();
                employeeForm.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Invalid email or password. Please try again.","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        private bool IsUserInCompanyAccountTable(string email, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM tbl_company_acc WHERE com_email = @Email AND com_password = @Password", connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        // Method to check if the user email and password exist in tbl_acc
        private bool IsUserInAccTable(string email, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM tbl_acc WHERE acc_email = @Email AND acc_password = @Password", connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public string getemail()
        {
            return acc_email;
        }

        private async void btn_google_signin_Click(object sender, EventArgs e)
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
            tokenRequest.Accept = "Accept=text/html,application/xhtml+xml,application/xml;q=0.9,/;q=0.8";
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
            userinfoRequest.Accept = "Accept=text/html,application/xhtml+xml,application/xml;q=0.9,/;q=0.8";

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

                using (cmd = new SqlCommand("SELECT COUNT(*) FROM hi WHERE Email = @Email", con))
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
        // Add these methods inside the SignIn class

        private bool IsEmailExistsInCompanyTable(string email)
        {
            using (SqlConnection con = new SqlConnection("Data Source=projectnibm.database.windows.net;Initial Catalog=jobfinderDB1;Persist Security Info=True;User ID=adm;Password=Dhanuri2003@"))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM tbl_company_acc WHERE com_email = @Email", con))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private bool IsNameExistsInCompanyTable(string name)
        {
            using (SqlConnection con = new SqlConnection("Data Source=projectnibm.database.windows.net;Initial Catalog=jobfinderDB1;Persist Security Info=True;User ID=adm;Password=Dhanuri2003@"))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM tbl_company_acc WHERE com_name = @Name", con))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private bool IsEmailExistsInAccTable(string email)
        {
            using (SqlConnection con = new SqlConnection("Data Source=projectnibm.database.windows.net;Initial Catalog=jobfinderDB1;Persist Security Info=True;User ID=adm;Password=Dhanuri2003@"))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM tbl_acc WHERE acc_email = @Email", con))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private bool IsNameExistsInAccTable(string name)
        {
            using (SqlConnection con = new SqlConnection("Data Source=projectnibm.database.windows.net;Initial Catalog=jobfinderDB1;Persist Security Info=True;User ID=adm;Password=Dhanuri2003@"))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM tbl_acc WHERE acc_Name = @Name", con))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }


        private void SaveDetailsToDatabase(string email, string password, string name)
        {
            try
            {
                bool isEmailExistsInCompanyTable = IsEmailExistsInCompanyTable(email);
                bool isNameExistsInCompanyTable = IsNameExistsInCompanyTable(name);

                bool isEmailExistsInAccTable = IsEmailExistsInAccTable(email);
                bool isNameExistsInAccTable = IsNameExistsInAccTable(name);

                if (isEmailExistsInCompanyTable && isNameExistsInCompanyTable)
                {
                    // Show the company form
                    acc_email = email;
                    Company_Menu companyForm = new Company_Menu();
                    companyForm.Show();
                    this.Hide();
                }
                else if (isEmailExistsInAccTable && isNameExistsInAccTable)
                {
                    // Show the home form
                    acc_email = email;
                    Employee_menu homeForm = new Employee_menu();
                    homeForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No user found. Please sign up.", "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void Sign_In_Load(object sender, EventArgs e)
        {
            Connection signinconnection = new Connection();
            con = new SqlConnection(signinconnection.connection.ConnectionString);
            lbl_email_error.Text = string.Empty;
            lbl_passowrd_error.Text = string.Empty;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Select_Sign_Up sign_Up = new Select_Sign_Up();
            sign_Up.Show();
            this.Hide();
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            this.txt_password.PasswordChar = '*';
        }
    }
}
