using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenAI_API;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using OpenAI_API.Completions;
using System.Runtime.CompilerServices;
using System.Data.SqlClient;
using JOB_FINDER.Employee_Forms.For_You;
using System.Runtime.Remoting.Contexts;
using System.Web.UI.WebControls;
using JOB_FINDER.Login_Forms.Sign_In_Form;
using JOB_FINDER.Company_Forms.Company_ViewApplications;
using System.IO;
using IOPath = System.IO.Path; // Adding an alias for System.IO.Path
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace JOB_FINDER.Employee_Forms.PDF_Reader
{
    public partial class PDF_reader : Form
    {
        public PDF_reader()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        Connection pdfreadcon = new Connection();
        public string OpenAIText;
        private PdfReader reader;
        private string JobTitle;
        private string JobSkill;
        private string JobEducation;
        private string JobExperience;
        private string cv_text;
        Sign_In login = new Sign_In();
        Employee_menu obj;
        private OpenFileDialog dialog;
        private string status = null;
        private async Task RunOpenAI()
        {
            var authentication = new APIAuthentication("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");
            var api = new OpenAIAPI(authentication);
            var conversation = api.Chat.CreateConversation();
            conversation.AppendUserInput("Given the following text from a CV, extract the following information of the candidate in this order: job title, programming language, education level, and experience level (Entry-level, Intermediate, Mid-level, Senior or executive-level)." + cv_text);
            var response = await conversation.GetResponseFromChatbotAsync();
            StringSplit(response.ToString());
        }

        private void StringSplit(String Response)
        {
            string input = Response;
            char[] separators = { ':', '\n' };

            string[] parts = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            JobTitle = parts[1].Trim();
            JobSkill = parts[3].Trim();
            JobEducation = parts[5].Trim();
            JobExperience = parts[7].Trim();
        }


        
        private void readpdf()
        {
        using (dialog = new OpenFileDialog() { Filter = "PDF files (*.pdf)|*.pdf", ValidateNames = true, Multiselect = false })
        {
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Checking if the file exists and is a valid PDF file
                    if (File.Exists(dialog.FileName) && IOPath.GetExtension(dialog.FileName).Equals(".pdf", StringComparison.OrdinalIgnoreCase)) // Using the alias for System.IO.Path
                    {
                        // Dispose of the previous PdfReader, if any
                        reader?.Close();
                        reader?.Dispose();

                        reader = new PdfReader(dialog.FileName);
                        StringBuilder text = new StringBuilder();

                        for (int i = 1; i <= reader.NumberOfPages; i++)
                        {
                            text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                        }

                        cv_text = text.ToString();
                        status = "1";
                    }
                    else
                    {
                        throw new InvalidDataException("The file is not a valid PDF file.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception Error: " + ex.Message);
                }
            }
            else
            {
                
                MessageBox.Show("Please select a PDF file to upload.");
            }
        }
    }


        private void InserDataDB()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("insert into tbl_cv (cv_email,cv_jobtitle,cv_education,cv_jobskill,cv_jobexperience,cv_pdf) values (@email,@jobtitle,@education,@skill,@experience,@pdf)", con);
                cmd.Parameters.AddWithValue("email", login.getemail());
                cmd.Parameters.AddWithValue("jobtitle", JobTitle);
                cmd.Parameters.AddWithValue("skill", JobSkill);
                cmd.Parameters.AddWithValue("education", JobEducation);
                cmd.Parameters.AddWithValue("experience", JobExperience);
                byte[] pdfBytes = File.ReadAllBytes(dialog.FileName);
                cmd.Parameters.Add("@pdf", SqlDbType.Binary, pdfBytes.Length).Value = pdfBytes;
                int status = cmd.ExecuteNonQuery();
                if (status == 1)
                {
                    MessageBox.Show("Pdf Upload was successfull");
                }
                else
                {
                    MessageBox.Show("Error inserting PDF file.");
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("A SQL exception occurred: " + ex.Message);
            }
            catch (OutOfMemoryException ex)
            {
                MessageBox.Show("An out of memory exception occurred: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An exception occurred: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }



        private async void btn_upload_Click(object sender, EventArgs e)
        {
            readpdf();
            if (status != null) 
            {
                await RunOpenAI();
                InserDataDB();
                obj = (Employee_menu)this.ParentForm;
                obj.CheckCV();
            }
            
        }

        private void PDF_reader_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(pdfreadcon.connection.ConnectionString);
        }
    }
}
