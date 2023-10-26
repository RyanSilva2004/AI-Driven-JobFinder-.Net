using OpenAI_API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.IO;

namespace JOB_FINDER.Employee_Forms.Career_Guidance
{
    public partial class AI : Form
    {
        private readonly OpenAIAPI openai;
        private List<string> dataset;
        private string connectionString; // Connection string for your SQL database
        public AI()
        {
            InitializeComponent();
            // Initialize the OpenAI API client with your API key
            string apiKey = "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";
            openai = new OpenAIAPI(apiKey);

            // Load the dataset file
            string datasetPath = "New Text Document (6).ttml";
            dataset = File.ReadAllLines(datasetPath).ToList();

            // Set up the connection string for your SQL database
            connectionString = "Data Source=projectnibm.database.windows.net;Initial Catalog=jobfinderDB1;User ID=adm;Password=Dhanuri2003@";
        }

        private async void btn_search_Click(object sender, EventArgs e)
        {
            string userInput = show_txt.Text;
            show_txt.SelectionStart = show_txt.TextLength;
            show_txt.ScrollToCaret();

            // Display user input on the right side of the rich textbox
            show_txt.SelectionAlignment = HorizontalAlignment.Right;
            show_txt.AppendText(userInput + Environment.NewLine);

            string aiResponse = await GetAIResponse(userInput);

            // Display AI response on the left side of the rich textbox
            show_txt.SelectionAlignment = HorizontalAlignment.Left;
            show_txt.AppendText(Environment.NewLine + aiResponse + Environment.NewLine + Environment.NewLine);

            show_txt.Clear();
        }
        private async Task<string> GetAIResponse(string userInput)
        {
            string aiResponse = "";

            // Convert user input to lowercase for case-insensitive matching
            userInput = userInput.ToLower();

            // Check if the user input is a greeting
            if (userInput.Equals("hi") || userInput.Equals("hey"))
            {
                aiResponse = "Hello! How can I assist you today?";
            }
            else
            {
                // Find matching words between user input and dataset
                var words = userInput.Split(' ');
                var matchingWords = words.Intersect(dataset.SelectMany(line => line.Split(' ')));

                if (matchingWords.Any())
                {
                    string matchingWord = matchingWords.First();

                    // Check if the user input specifically asks for "new jobs"
                    if (matchingWord.Equals("new", StringComparison.OrdinalIgnoreCase) &&
                        userInput.IndexOf("jobs", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        // Retrieve the names of available jobs from the database
                        List<string> jobNames = GetJobNamesFromDatabase();

                        if (jobNames.Count > 0)
                        {
                            // Display the available jobs as a list
                            aiResponse = "The available jobs are:" + Environment.NewLine;
                            for (int i = 0; i < jobNames.Count; i++)
                            {
                                aiResponse += $"{i + 1}. {jobNames[i]}" + Environment.NewLine;
                            }
                            aiResponse += Environment.NewLine + "If you are interested in any of the above jobs, you can apply through our search page.";
                        }
                        else
                        {
                            aiResponse = "There are no available jobs at the moment.";
                        }
                    }
                    // Check if the user input asks for help
                    else if (matchingWord.Equals("help", StringComparison.OrdinalIgnoreCase))
                    {
                        // Provide the help desk information
                        aiResponse = "If you need any assistance, please contact our help desk at help@company.com";
                    }
                    else
                    {
                        // Send matching word and user input to OpenAI for response
                        var prompt = $"User: {userInput}\nMatched Word: {matchingWord}\nAI:";
                        var response = await openai.Completions.CreateCompletionAsync(model: "text-davinci-003",
                            prompt: prompt,
                            temperature: 0.6,
                            max_tokens: 100);

                        aiResponse = response.ToString().Trim();
                    }
                }
                else
                {
                    // Default response if no matching word found in the dataset
                    aiResponse = "I cannot answer that";
                }
            }

            return aiResponse;
        }

        private List<string> GetJobNamesFromDatabase()
        {
            List<string> jobNames = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Execute a query to retrieve the distinct non-null job names from the database
                string query = "SELECT DISTINCT Job_title FROM tbl_job WHERE Job_title IS NOT NULL";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string jobName = reader["Job_title"].ToString();
                    jobNames.Add(jobName);
                }

                reader.Close();
            }

            return jobNames;
        }

        private void IncreaseTextSize()
        {
            // Get the current font from the RichTextBox control
            Font currentFont = show_txt.Font;

            // Create a new Font with an increased size
            Font newFont = new Font(currentFont.FontFamily, currentFont.Size + 2, currentFont.Style);

            // Assign the new Font to the RichTextBox control
            show_txt.Font = newFont;
        }

        private async void btn_hi_Click(object sender, EventArgs e)
        {
            string userInput = "hi";
            show_txt.SelectionStart = show_txt.TextLength;
            show_txt.ScrollToCaret();

            // Display user input on the right side of the rich textbox
            show_txt.SelectionAlignment = HorizontalAlignment.Right;
            show_txt.AppendText(userInput + Environment.NewLine);

            string aiResponse = await GetAIResponse(userInput);

            // Display AI response on the left side of the rich textbox
            show_txt.SelectionAlignment = HorizontalAlignment.Left;
            show_txt.AppendText(Environment.NewLine + aiResponse + Environment.NewLine + Environment.NewLine);
        }

        private async void btn_new_jobs_Click(object sender, EventArgs e)
        {
            string userInput = "new jobs";
            show_txt.SelectionStart = show_txt.TextLength;
            show_txt.ScrollToCaret();

            // Display user input on the right side of the rich textbox
            show_txt.SelectionAlignment = HorizontalAlignment.Right;
            show_txt.AppendText(userInput + Environment.NewLine);

            string aiResponse = await GetAIResponse(userInput);

            // Display AI response on the left side of the rich textbox
            show_txt.SelectionAlignment = HorizontalAlignment.Left;
            show_txt.AppendText(Environment.NewLine + aiResponse + Environment.NewLine + Environment.NewLine);
        }
    }
}
