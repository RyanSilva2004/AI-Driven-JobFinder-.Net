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
using JOB_FINDER.Login_Forms.Sign_In_Form;

namespace JOB_FINDER.Company_Forms
{
    public partial class Company_Update : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        Sign_In login = new Sign_In();
        public Company_Update()
        {
            InitializeComponent();
            lbl_error.Visible = false;
            con = new SqlConnection("Data Source=projectnibm.database.windows.net;Initial Catalog=jobfinderDB1;Persist Security Info=True;User ID=adm;Password=Dhanuri2003@");
            LoadDataFromDB(); // Fetch data from the database and display it
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            {
                // Check if a profile picture is selected
                if (pic_pro.Image != null)
                {
                    try
                    {
                        // Get the image bytes
                        byte[] imageBytes;
                        using (var ms = new System.IO.MemoryStream())
                        {
                            pic_pro.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            imageBytes = ms.ToArray();
                        }

                        // Get other data from textboxes and rich text box
                        string password = txt_password.Text;
                        string description = rich_txt_discription.Text;
                        string location = txt_location.Text;
                        string telephone = txt_telephone.Text;
                        string name = txt_name.Text;

                        // Update the database with the new information
                        string connectionString = "Data Source=projectnibm.database.windows.net;Initial Catalog=jobfinderDB1;Persist Security Info=True;User ID=adm;Password=Dhanuri2003@"; // Replace with your database connection string
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            string query = "UPDATE tbl_company_acc SET com_pfp = @ImageData, com_password = @password, com_description = @description, com_location = @location, com_tp = @tp ,com_name = @name  WHERE com_email = '@ApplicantEmail'";
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@ImageData", imageBytes);
                                command.Parameters.AddWithValue("@password", password);
                                command.Parameters.AddWithValue("@description", description);
                                command.Parameters.AddWithValue("@location", location);
                                command.Parameters.AddWithValue("@tp", telephone);
                                command.Parameters.AddWithValue("@name", name);
                                command.Parameters.AddWithValue("@ApplicantEmail",login.getemail());

                                connection.Open();
                                command.ExecuteNonQuery();
                                connection.Close();
                            }
                        }

                        MessageBox.Show("Company account updated successfully.","Infromation",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to update company account. Error message: " + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a profile picture first.","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }
        public void LoadDataFromDB()
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM tbl_company_acc WHERE com_email = @ApplicantEmail1";              
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("ApplicantEmail1", login.getemail());
                    SqlDataReader reader = command.ExecuteReader();                   
                    if (reader.Read())
                    {
                        txt_password.Text = reader["com_password"].ToString();
                        rich_txt_discription.Text = reader["com_description"].ToString();
                        txt_location.Text = reader["com_location"].ToString();
                        txt_telephone.Text = reader["com_tp"].ToString();
                        txt_name.Text = reader["com_name"].ToString();
                        
                    }                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            {
                // Open file dialog to select picture
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files (.jpg; .png; .bmp)|.jpg;.png;.bmp|All files (.)|.";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Load the selected image into the PictureBox control
                    pic_pro.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void company_update_Load(object sender, EventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            this.txt_password.PasswordChar = '*';
        }
    }
}
