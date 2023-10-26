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

namespace JOB_FINDER.Employee_Forms
{
    public partial class Employee_Update : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        Sign_In login = new Sign_In();
        Connection userupdatecon =new  Connection();
        public Employee_Update()
        {
            InitializeComponent();         
        }

        private void userUpdate_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(userupdatecon.connection.ConnectionString);
            lbl_error.Visible = false;
            LoadDataFromDB();
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
                        string telephone = txt_telephone.Text;
                        string name = txt_name.Text;

                        // Update the database with the new information
                        
                        {
                            con.Open();
                            string query = "UPDATE tbl_acc SET acc_pfp = @ImageData, acc_password = @password, acc_tp = @tp ,acc_name = @name  WHERE acc_email = '@ApplicantEmail'";
                            cmd = new SqlCommand(query, con);
                            
                                cmd.Parameters.AddWithValue("@ImageData", imageBytes);
                                cmd.Parameters.AddWithValue("@password", password);
                                cmd.Parameters.AddWithValue("@tp", telephone);
                                cmd.Parameters.AddWithValue("@name", name);
                                cmd.Parameters.AddWithValue("@ApplicantEmail", login.getemail());

                                
                                cmd.ExecuteNonQuery();
                                
                            
                            con.Close();
                        }

                        MessageBox.Show("User account updated successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to update company account. Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a profile picture first.");
                }
            }
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (.jpg; *.png; *.bmp)|.jpg;.png;.bmp|All files (.)|.";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Load the selected image into the PictureBox control
                    pic_pro.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }
         public void LoadDataFromDB()
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM tbl_acc WHERE acc_email = @ApplicantEmail1";

                cmd = new SqlCommand(query, con);
                
                    cmd.Parameters.AddWithValue("ApplicantEmail1", login.getemail());
                    SqlDataReader reader = cmd.ExecuteReader();
                    
                    if (reader.Read())
                    {
                        txt_password.Text = reader["acc_password"].ToString();
                        
                        txt_telephone.Text = reader["acc_tp"].ToString();
                        txt_name.Text = reader["acc_name"].ToString();
                        
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

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            this.txt_password.PasswordChar = '*';
        }
    }
}
