namespace JOB_FINDER.Employee_Forms
{
    partial class JobSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_search = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txt_search_title = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnl_JobListings_Search = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.txt_search_title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 85);
            this.panel1.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.White;
            this.btn_search.BorderColor = System.Drawing.Color.White;
            this.btn_search.BorderRadius = 15;
            this.btn_search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_search.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_search.FillColor = System.Drawing.Color.RoyalBlue;
            this.btn_search.FillColor2 = System.Drawing.Color.Navy;
            this.btn_search.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(549, 17);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(124, 41);
            this.btn_search.TabIndex = 19;
            this.btn_search.Text = "Search";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search_title
            // 
            this.txt_search_title.AutoRoundedCorners = true;
            this.txt_search_title.BackColor = System.Drawing.Color.Transparent;
            this.txt_search_title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_search_title.BorderRadius = 23;
            this.txt_search_title.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search_title.DefaultText = "";
            this.txt_search_title.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_search_title.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_search_title.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search_title.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search_title.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search_title.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_search_title.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search_title.Location = new System.Drawing.Point(6, 13);
            this.txt_search_title.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_search_title.Name = "txt_search_title";
            this.txt_search_title.PasswordChar = '\0';
            this.txt_search_title.PlaceholderText = "Job Title";
            this.txt_search_title.SelectedText = "";
            this.txt_search_title.Size = new System.Drawing.Size(673, 48);
            this.txt_search_title.TabIndex = 0;
            // 
            // pnl_JobListings_Search
            // 
            this.pnl_JobListings_Search.AutoScroll = true;
            this.pnl_JobListings_Search.BackColor = System.Drawing.Color.Gainsboro;
            this.pnl_JobListings_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_JobListings_Search.Location = new System.Drawing.Point(0, 85);
            this.pnl_JobListings_Search.Name = "pnl_JobListings_Search";
            this.pnl_JobListings_Search.Size = new System.Drawing.Size(921, 528);
            this.pnl_JobListings_Search.TabIndex = 2;
            // 
            // JobSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 613);
            this.Controls.Add(this.pnl_JobListings_Search);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JobSearch";
            this.Text = "JobSearch";
            this.Load += new System.EventHandler(this.JobSearch_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel pnl_JobListings_Search;
        private Guna.UI2.WinForms.Guna2TextBox txt_search_title;
        private Guna.UI2.WinForms.Guna2GradientButton btn_search;
    }
}