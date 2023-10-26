namespace JOB_FINDER.JobListings_UserControls
{
    partial class emp_days
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ibdays = new System.Windows.Forms.Label();
            this.lbl_com = new System.Windows.Forms.Label();
            this.lbl_job_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ibdays
            // 
            this.ibdays.AutoSize = true;
            this.ibdays.Location = new System.Drawing.Point(13, 12);
            this.ibdays.Name = "ibdays";
            this.ibdays.Size = new System.Drawing.Size(21, 16);
            this.ibdays.TabIndex = 0;
            this.ibdays.Text = "00";
            // 
            // lbl_com
            // 
            this.lbl_com.AutoSize = true;
            this.lbl_com.Location = new System.Drawing.Point(173, 12);
            this.lbl_com.Name = "lbl_com";
            this.lbl_com.Size = new System.Drawing.Size(44, 16);
            this.lbl_com.TabIndex = 1;
            this.lbl_com.Text = "label1";
            // 
            // lbl_job_title
            // 
            this.lbl_job_title.AutoSize = true;
            this.lbl_job_title.Location = new System.Drawing.Point(13, 41);
            this.lbl_job_title.Name = "lbl_job_title";
            this.lbl_job_title.Size = new System.Drawing.Size(44, 16);
            this.lbl_job_title.TabIndex = 2;
            this.lbl_job_title.Text = "label1";
            // 
            // emp_days
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_job_title);
            this.Controls.Add(this.lbl_com);
            this.Controls.Add(this.ibdays);
            this.Name = "emp_days";
            this.Size = new System.Drawing.Size(292, 57);
            this.Load += new System.EventHandler(this.emp_days_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ibdays;
        private System.Windows.Forms.Label lbl_com;
        private System.Windows.Forms.Label lbl_job_title;
    }
}
