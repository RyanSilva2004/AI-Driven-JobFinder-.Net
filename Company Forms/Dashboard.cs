using JOB_FINDER.JobListings_UserControls;
using JOB_FINDER.Login_Forms.Sign_In_Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace JOB_FINDER.Company_Forms
{
    public partial class Dashboard : Form
    {
        int month,year;
        int days;
        public static int static_month,static_year;
        public Dashboard()
        {
            InitializeComponent();
        }
        Connection dashboardcon = new Connection();
        SqlConnection con;
        SqlCommand cmd;
        Sign_In login = new Sign_In();

        private void Dashboard_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(dashboardcon.connection.ConnectionString);
            LoadApplicantsCount();
            LoadInterviewCount();
            LoadJobListedCount();
            Display();
            barchart();
        }

        private void LoadJobListedCount()
        {
            con.Open();
            cmd = new SqlCommand("SELECT COUNT(*) AS job_count FROM tbl_job WHERE  job_vender_email = @CompanyEmail", con);
            cmd.Parameters.AddWithValue("@CompanyEmail",login.getemail());
            int x = Convert.ToInt32(((SqlCommand)cmd).ExecuteScalar());
            con.Close();
            lbl_nojobslisted.Text = x.ToString();
        }
        private void LoadApplicantsCount()
        {
            con.Open();
            cmd = new SqlCommand("SELECT count (app_applicantemail) FROM tbl_applicantation where app_companyemail = @CompanyEmail", con);
            cmd.Parameters.AddWithValue("@CompanyEmail", login.getemail());
            int x = Convert.ToInt32(((SqlCommand)cmd).ExecuteScalar());
            con.Close();
            lbl_noofapplicants.Text = x.ToString();
        }

        private void Preives_Click(object sender, EventArgs e)
        {
            pnl_shedule.Controls.Clear();
            month--;
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbl_month.Text = monthname + " " + year;

            DateTime startofmonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int daysofweek = (int)startofmonth.DayOfWeek;

            static_month = month;
            static_year = year;

            for (int i = 0; i < daysofweek; i++)
            {

            }
            for (int i = 1; i <= days; i++)
            {
                emp_days ucdays = new emp_days();
                DateTime currentDay = new DateTime(year, month, i);
                ucdays.Date = currentDay;
                ucdays.days(i);
                pnl_shedule.Controls.Add(ucdays);
            }
        }

        private void btn_nxt_Click(object sender, EventArgs e)
        {
            pnl_shedule.Controls.Clear();
            month++;

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbl_month.Text = monthname + " " + year;
            DateTime startofmonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int daysofweek = (int)startofmonth.DayOfWeek;

            static_month = month;
            static_year = year;

            for (int i = 0; i < daysofweek; i++)
            {

            }
            for (int i = 1; i <= days; i++)
            {
                emp_days ucdays = new emp_days();
                DateTime currentDay = new DateTime(year, month, i);
                ucdays.Date = currentDay;
                ucdays.days(i);
                pnl_shedule.Controls.Add(ucdays);
            }
        }

        private void LoadInterviewCount()
        {
            con.Open();
            cmd = new SqlCommand("SELECT count (app_id) FROM tbl_applicantation where app_companyemail = @CompanyEmail and app_status = 'Selected'", con);
            cmd.Parameters.AddWithValue("@CompanyEmail", login.getemail());
            int x = Convert.ToInt32(((SqlCommand)cmd).ExecuteScalar());
            con.Close();
            lbl_noofinterviews.Text = x.ToString();
        }
        private void barchart()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(dashboardcon.connection.ConnectionString))
                {
                    connection.Open();

                    DataTable dataTable = GetDataFromDatabase(connection);

                    // Create and configure the bar chart
                    chart1.Series.Clear();
                    chart1.ChartAreas.Clear();

                    ChartArea chartArea = new ChartArea();
                    chart1.ChartAreas.Add(chartArea);

                    Series series = new Series();
                    series.ChartType = SeriesChartType.Column;
                    series.IsValueShownAsLabel = true;

                    // Loop through the DataTable to add data points to the series
                    foreach (DataRow row in dataTable.Rows)
                    {
                        string columnName = row["job_title"].ToString();
                        int jobCount = Convert.ToInt32(row["JobCount"]);
                        series.Points.AddXY(columnName, jobCount);
                    }

                    // Add the series to the chart
                    chart1.Series.Add(series);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private DataTable GetDataFromDatabase(SqlConnection connection)
        {
            string query = "SELECT COUNT(*) AS JobCount, job_title FROM tbl_job GROUP BY job_title;";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        private void pnl_shedule_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Display()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbl_month.Text = monthname + " " + year;
            static_month = month;
            static_year = year;

            DateTime startofmonth = new DateTime(year, month, 1);
            days = DateTime.DaysInMonth(year, month);
            int daysofweek = (int)startofmonth.DayOfWeek;

            for (int i = 1; i < daysofweek; i++)
            {

            }

            string connectionString = "Data Source=projectnibm.database.windows.net;Initial Catalog=jobfinderDB1;Persist Security Info=True;User ID=adm;Password=Dhanuri2003@";
            string query = "SELECT app.app_interviewdate, acc.acc_name, job.job_title FROM  tbl_applicantation app JOIN  tbl_acc acc ON app.app_applicantemail = acc.acc_email JOIN tbl_job job ON app.app_companyemail = job.job_vender_email WHERE app.app_applicantemail = @email;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("email", login.getemail());
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    DateTime dateFromDB = reader.GetDateTime(0).Date;
                    string companyName = reader.GetString(1);
                    string jobTitle = reader.GetString(2);

                    for (int i = 1; i <= days; i++)
                    {
                        emp_days ucdays = new emp_days();
                        DateTime currentDay = new DateTime(year, month, i);

                        if (currentDay.Date == dateFromDB.Date)
                        {
                            ucdays.HasData = true;
                            ucdays.CompanyName = companyName;
                            ucdays.JobTitle = jobTitle;
                        }

                        if (currentDay.Date == DateTime.Today.Date)
                        {
                            ucdays.BackColor = Color.LightBlue;
                        }
                        else if (ucdays.HasData)
                        {
                            ucdays.BackColor = Color.Yellow;
                        }
                        else
                        {
                            ucdays.BackColor = Color.White;
                        }

                        ucdays.Date = currentDay;
                        ucdays.days(i);
                        pnl_shedule.Controls.Add(ucdays);
                    }
                }

                reader.Close();
            }
        }
    }
}
