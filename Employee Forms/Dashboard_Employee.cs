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
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace JOB_FINDER.Employee_Forms
{
    public partial class Dashboard_Employee : Form
    {
        public Dashboard_Employee()
        {
            InitializeComponent();
        }
        Connection companymenucon = new Connection();
        Sign_In sign = new Sign_In();
        SqlConnection con;
        SqlCommand cmd;
        private void LoadJobListedCount()
        {
            con.Open();
            cmd = new SqlCommand("SELECT COUNT(*) AS job_count FROM tbl_job ", con);
            int x = Convert.ToInt32(((SqlCommand)cmd).ExecuteScalar());
            con.Close();
            lbl_nojobslisted.Text = x.ToString();
        }
        private void LoadCompanyCount()
        {
            con.Open();
            cmd = new SqlCommand("SELECT COUNT(*) AS job_count FROM tbl_company_acc ", con);
            int x = Convert.ToInt32(((SqlCommand)cmd).ExecuteScalar());
            con.Close();
            lbl_noofcompanies.Text = x.ToString();
        }

        private void LoadAccountCount()
        {
            con.Open();
            cmd = new SqlCommand("SELECT COUNT(*) AS job_count FROM tbl_acc ", con);
            int x = Convert.ToInt32(((SqlCommand)cmd).ExecuteScalar());
            con.Close();
            lbl_noofusers.Text = x.ToString();
        }
        private void BindPieChart()
        {
            // Create a connection to the SQL Server database
            string connectionString = "Data Source=projectnibm.database.windows.net;Initial Catalog=jobfinderDB1;Persist Security Info=True;User ID=adm;Password=Dhanuri2003@";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Your SQL query to retrieve job titles and their counts
                string sqlQuery = "SELECT job_title, COUNT(*) AS job_count FROM tbl_job GROUP BY job_title";

                // Prepare the data table to hold the results
                DataTable dataTable = new DataTable();

                // Open the database connection
                connection.Open();

                // Create a data adapter and execute the query
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connection))
                {
                    // Fill the data table with the results from the database
                    dataAdapter.Fill(dataTable);
                }

                // Close the database connection
                connection.Close();

                // Clear any existing series and points from the chart
                chart1.Series.Clear();

                // Add a new series for the pie chart
                Series series = new Series("PieChart");
                series.ChartType = SeriesChartType.Pie;

                // Add data points to the series
                foreach (DataRow row in dataTable.Rows)
                {
                    string jobTitle = row["job_title"].ToString();
                    double jobCount = Convert.ToDouble(row["job_count"]);
                    series.Points.AddXY(jobTitle, jobCount);
                }

                // Add the series to the chart
                chart1.Series.Add(series);

                // Set chart title and other properties (optional)
                chart1.Titles.Add("Job Titles Pie Chart");
                chart1.ChartAreas[0].Area3DStyle.Enable3D = true; // Enable 3D effect (optional)
            }
        }

        private void Dashboard_Employee_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(companymenucon.connection.ConnectionString);
            BindPieChart();
            LoadJobListedCount();
            LoadAccountCount();
            LoadCompanyCount();
        }
    }
}
