using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JOB_FINDER.JobListings_UserControls
{
    public partial class emp_days : UserControl
    {
        public DateTime Date { get; set; }
        public bool HasData { get; set; }
        public string CompanyName { get; set; }
        public string JobTitle { get; set; }
        public emp_days()
        {
            InitializeComponent();
            HasData = false;
            CompanyName = string.Empty;
            JobTitle = string.Empty;
        }

        private void emp_days_Load(object sender, EventArgs e)

        {
            if (Date.Date == DateTime.Today.Date)
            {
                this.BackColor = Color.Yellow;
            }
            else if (HasData)
            {
                this.BackColor = Color.LightBlue;
            }
            else
            {
                this.BackColor = Color.White;
            }

            lbl_com.Text = CompanyName;
            lbl_job_title.Text = JobTitle;
        }
        public void days(int numday)
        {
            ibdays.Text = numday + "";
        }
    }
}
