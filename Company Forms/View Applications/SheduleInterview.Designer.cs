namespace JOB_FINDER.Company_Forms.View_Applications
{
    partial class SheduleInterview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SheduleInterview));
            this.lbl_applicantname = new Bunifu.UI.WinForms.BunifuLabel();
            this.btn_sheduleinterview = new Guna.UI2.WinForms.Guna2GradientButton();
            this.timepicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.datepicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.SuspendLayout();
            // 
            // lbl_applicantname
            // 
            this.lbl_applicantname.AllowParentOverrides = false;
            this.lbl_applicantname.AutoEllipsis = false;
            this.lbl_applicantname.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_applicantname.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_applicantname.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_applicantname.Location = new System.Drawing.Point(103, 12);
            this.lbl_applicantname.Name = "lbl_applicantname";
            this.lbl_applicantname.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_applicantname.Size = new System.Drawing.Size(344, 28);
            this.lbl_applicantname.TabIndex = 3;
            this.lbl_applicantname.Text = "Select a date to shedule the interview";
            this.lbl_applicantname.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_applicantname.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btn_sheduleinterview
            // 
            this.btn_sheduleinterview.Animated = true;
            this.btn_sheduleinterview.BorderRadius = 15;
            this.btn_sheduleinterview.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_sheduleinterview.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_sheduleinterview.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_sheduleinterview.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_sheduleinterview.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_sheduleinterview.FillColor = System.Drawing.Color.RoyalBlue;
            this.btn_sheduleinterview.FillColor2 = System.Drawing.Color.Navy;
            this.btn_sheduleinterview.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_sheduleinterview.ForeColor = System.Drawing.Color.White;
            this.btn_sheduleinterview.Image = global::JOB_FINDER.Properties.Resources.icons8_meeting_25;
            this.btn_sheduleinterview.Location = new System.Drawing.Point(166, 109);
            this.btn_sheduleinterview.Name = "btn_sheduleinterview";
            this.btn_sheduleinterview.Size = new System.Drawing.Size(216, 42);
            this.btn_sheduleinterview.TabIndex = 50;
            this.btn_sheduleinterview.Text = "Shedule Interview";
            this.btn_sheduleinterview.Click += new System.EventHandler(this.btn_sheduleinterview_Click);
            // 
            // timepicker
            // 
            this.timepicker.Checked = true;
            this.timepicker.FillColor = System.Drawing.Color.White;
            this.timepicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.timepicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timepicker.Location = new System.Drawing.Point(308, 59);
            this.timepicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.timepicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.timepicker.Name = "timepicker";
            this.timepicker.ShowUpDown = true;
            this.timepicker.Size = new System.Drawing.Size(139, 36);
            this.timepicker.TabIndex = 52;
            this.timepicker.Value = new System.DateTime(2023, 7, 25, 22, 31, 6, 586);
            // 
            // datepicker
            // 
            this.datepicker.AllowDrop = true;
            this.datepicker.BackColor = System.Drawing.Color.White;
            this.datepicker.Checked = true;
            this.datepicker.FillColor = System.Drawing.Color.White;
            this.datepicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepicker.Location = new System.Drawing.Point(103, 59);
            this.datepicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datepicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datepicker.Name = "datepicker";
            this.datepicker.Size = new System.Drawing.Size(199, 36);
            this.datepicker.TabIndex = 51;
            this.datepicker.Value = new System.DateTime(2023, 7, 25, 22, 6, 23, 92);
            // 
            // SheduleInterview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 177);
            this.Controls.Add(this.timepicker);
            this.Controls.Add(this.datepicker);
            this.Controls.Add(this.btn_sheduleinterview);
            this.Controls.Add(this.lbl_applicantname);
            this.Name = "SheduleInterview";
            this.Text = "Shedule Interview";
            this.Load += new System.EventHandler(this.SheduleInterview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel lbl_applicantname;
        private Guna.UI2.WinForms.Guna2GradientButton btn_sheduleinterview;
        private Guna.UI2.WinForms.Guna2DateTimePicker timepicker;
        private Guna.UI2.WinForms.Guna2DateTimePicker datepicker;
    }
}