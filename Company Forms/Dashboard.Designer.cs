namespace JOB_FINDER.Company_Forms
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_shedule = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_nxt = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lbl_month = new System.Windows.Forms.Label();
            this.bunifuGradientPanel3 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.lbl_noofinterviews = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel2 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.lbl_noofapplicants = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.lbl_nojobslisted = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_previous = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.bunifuGradientPanel3.SuspendLayout();
            this.bunifuGradientPanel2.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnl_shedule);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(722, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 743);
            this.panel1.TabIndex = 4;
            // 
            // pnl_shedule
            // 
            this.pnl_shedule.AutoScroll = true;
            this.pnl_shedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_shedule.Location = new System.Drawing.Point(0, 40);
            this.pnl_shedule.Name = "pnl_shedule";
            this.pnl_shedule.Size = new System.Drawing.Size(300, 703);
            this.pnl_shedule.TabIndex = 1;
            this.pnl_shedule.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_shedule_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_nxt);
            this.panel2.Controls.Add(this.btn_previous);
            this.panel2.Controls.Add(this.lbl_month);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 40);
            this.panel2.TabIndex = 0;
            // 
            // btn_nxt
            // 
            this.btn_nxt.AllowAnimations = true;
            this.btn_nxt.AllowMouseEffects = true;
            this.btn_nxt.AllowToggling = false;
            this.btn_nxt.AnimationSpeed = 200;
            this.btn_nxt.AutoGenerateColors = false;
            this.btn_nxt.AutoRoundBorders = false;
            this.btn_nxt.AutoSizeLeftIcon = true;
            this.btn_nxt.AutoSizeRightIcon = true;
            this.btn_nxt.BackColor = System.Drawing.Color.Transparent;
            this.btn_nxt.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btn_nxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_nxt.BackgroundImage")));
            this.btn_nxt.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_nxt.ButtonText = "next";
            this.btn_nxt.ButtonTextMarginLeft = 0;
            this.btn_nxt.ColorContrastOnClick = 45;
            this.btn_nxt.ColorContrastOnHover = 45;
            this.btn_nxt.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_nxt.CustomizableEdges = borderEdges1;
            this.btn_nxt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_nxt.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_nxt.DisabledFillColor = System.Drawing.Color.Empty;
            this.btn_nxt.DisabledForecolor = System.Drawing.Color.Empty;
            this.btn_nxt.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_nxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_nxt.ForeColor = System.Drawing.Color.White;
            this.btn_nxt.IconLeft = null;
            this.btn_nxt.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nxt.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_nxt.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_nxt.IconMarginLeft = 11;
            this.btn_nxt.IconPadding = 10;
            this.btn_nxt.IconRight = null;
            this.btn_nxt.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_nxt.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_nxt.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_nxt.IconSize = 25;
            this.btn_nxt.IdleBorderColor = System.Drawing.Color.Empty;
            this.btn_nxt.IdleBorderRadius = 0;
            this.btn_nxt.IdleBorderThickness = 0;
            this.btn_nxt.IdleFillColor = System.Drawing.Color.Empty;
            this.btn_nxt.IdleIconLeftImage = null;
            this.btn_nxt.IdleIconRightImage = null;
            this.btn_nxt.IndicateFocus = false;
            this.btn_nxt.Location = new System.Drawing.Point(208, 14);
            this.btn_nxt.Name = "btn_nxt";
            this.btn_nxt.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_nxt.OnDisabledState.BorderRadius = 1;
            this.btn_nxt.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_nxt.OnDisabledState.BorderThickness = 1;
            this.btn_nxt.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_nxt.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_nxt.OnDisabledState.IconLeftImage = null;
            this.btn_nxt.OnDisabledState.IconRightImage = null;
            this.btn_nxt.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btn_nxt.onHoverState.BorderRadius = 1;
            this.btn_nxt.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_nxt.onHoverState.BorderThickness = 1;
            this.btn_nxt.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btn_nxt.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_nxt.onHoverState.IconLeftImage = null;
            this.btn_nxt.onHoverState.IconRightImage = null;
            this.btn_nxt.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_nxt.OnIdleState.BorderRadius = 1;
            this.btn_nxt.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_nxt.OnIdleState.BorderThickness = 1;
            this.btn_nxt.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_nxt.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_nxt.OnIdleState.IconLeftImage = null;
            this.btn_nxt.OnIdleState.IconRightImage = null;
            this.btn_nxt.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_nxt.OnPressedState.BorderRadius = 1;
            this.btn_nxt.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_nxt.OnPressedState.BorderThickness = 1;
            this.btn_nxt.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_nxt.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_nxt.OnPressedState.IconLeftImage = null;
            this.btn_nxt.OnPressedState.IconRightImage = null;
            this.btn_nxt.Size = new System.Drawing.Size(80, 18);
            this.btn_nxt.TabIndex = 7;
            this.btn_nxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_nxt.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_nxt.TextMarginLeft = 0;
            this.btn_nxt.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_nxt.UseDefaultRadiusAndThickness = true;
            this.btn_nxt.Click += new System.EventHandler(this.btn_nxt_Click);
            // 
            // lbl_month
            // 
            this.lbl_month.AutoSize = true;
            this.lbl_month.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_month.Location = new System.Drawing.Point(115, 9);
            this.lbl_month.Name = "lbl_month";
            this.lbl_month.Size = new System.Drawing.Size(62, 23);
            this.lbl_month.TabIndex = 5;
            this.lbl_month.Text = "Month";
            // 
            // bunifuGradientPanel3
            // 
            this.bunifuGradientPanel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel3.BackgroundImage")));
            this.bunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel3.BorderRadius = 20;
            this.bunifuGradientPanel3.Controls.Add(this.lbl_noofinterviews);
            this.bunifuGradientPanel3.Controls.Add(this.label5);
            this.bunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.Gold;
            this.bunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.Goldenrod;
            this.bunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.Orange;
            this.bunifuGradientPanel3.GradientTopRight = System.Drawing.Color.DarkOrange;
            this.bunifuGradientPanel3.Location = new System.Drawing.Point(507, 12);
            this.bunifuGradientPanel3.Name = "bunifuGradientPanel3";
            this.bunifuGradientPanel3.Quality = 10;
            this.bunifuGradientPanel3.Size = new System.Drawing.Size(200, 100);
            this.bunifuGradientPanel3.TabIndex = 3;
            // 
            // lbl_noofinterviews
            // 
            this.lbl_noofinterviews.AutoSize = true;
            this.lbl_noofinterviews.Font = new System.Drawing.Font("Pusia-Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noofinterviews.ForeColor = System.Drawing.Color.White;
            this.lbl_noofinterviews.Location = new System.Drawing.Point(69, 14);
            this.lbl_noofinterviews.Name = "lbl_noofinterviews";
            this.lbl_noofinterviews.Size = new System.Drawing.Size(63, 50);
            this.lbl_noofinterviews.TabIndex = 1;
            this.lbl_noofinterviews.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Pusia-Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(53, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Interviews";
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.BorderRadius = 20;
            this.bunifuGradientPanel2.Controls.Add(this.lbl_noofapplicants);
            this.bunifuGradientPanel2.Controls.Add(this.label3);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.DarkRed;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.Red;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.DarkRed;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.DarkRed;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(264, 12);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(200, 100);
            this.bunifuGradientPanel2.TabIndex = 2;
            // 
            // lbl_noofapplicants
            // 
            this.lbl_noofapplicants.AutoSize = true;
            this.lbl_noofapplicants.Font = new System.Drawing.Font("Pusia-Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noofapplicants.ForeColor = System.Drawing.Color.White;
            this.lbl_noofapplicants.Location = new System.Drawing.Point(69, 14);
            this.lbl_noofapplicants.Name = "lbl_noofapplicants";
            this.lbl_noofapplicants.Size = new System.Drawing.Size(63, 50);
            this.lbl_noofapplicants.TabIndex = 1;
            this.lbl_noofapplicants.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Pusia-Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(54, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Applicants";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 20;
            this.bunifuGradientPanel1.Controls.Add(this.lbl_nojobslisted);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Navy;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Blue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Navy;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(12, 12);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(200, 100);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // lbl_nojobslisted
            // 
            this.lbl_nojobslisted.AutoSize = true;
            this.lbl_nojobslisted.Font = new System.Drawing.Font("Pusia-Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nojobslisted.ForeColor = System.Drawing.Color.White;
            this.lbl_nojobslisted.Location = new System.Drawing.Point(65, 14);
            this.lbl_nojobslisted.Name = "lbl_nojobslisted";
            this.lbl_nojobslisted.Size = new System.Drawing.Size(63, 50);
            this.lbl_nojobslisted.TabIndex = 1;
            this.lbl_nojobslisted.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pusia-Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Job Listings";
            // 
            // btn_previous
            // 
            this.btn_previous.AllowAnimations = true;
            this.btn_previous.AllowMouseEffects = true;
            this.btn_previous.AllowToggling = false;
            this.btn_previous.AnimationSpeed = 200;
            this.btn_previous.AutoGenerateColors = false;
            this.btn_previous.AutoRoundBorders = false;
            this.btn_previous.AutoSizeLeftIcon = true;
            this.btn_previous.AutoSizeRightIcon = true;
            this.btn_previous.BackColor = System.Drawing.Color.Transparent;
            this.btn_previous.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btn_previous.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_previous.BackgroundImage")));
            this.btn_previous.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_previous.ButtonText = "btn_prve";
            this.btn_previous.ButtonTextMarginLeft = 0;
            this.btn_previous.ColorContrastOnClick = 45;
            this.btn_previous.ColorContrastOnHover = 45;
            this.btn_previous.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_previous.CustomizableEdges = borderEdges2;
            this.btn_previous.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_previous.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_previous.DisabledFillColor = System.Drawing.Color.Empty;
            this.btn_previous.DisabledForecolor = System.Drawing.Color.Empty;
            this.btn_previous.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_previous.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_previous.ForeColor = System.Drawing.Color.White;
            this.btn_previous.IconLeft = null;
            this.btn_previous.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_previous.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_previous.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_previous.IconMarginLeft = 11;
            this.btn_previous.IconPadding = 10;
            this.btn_previous.IconRight = null;
            this.btn_previous.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_previous.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_previous.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_previous.IconSize = 25;
            this.btn_previous.IdleBorderColor = System.Drawing.Color.Empty;
            this.btn_previous.IdleBorderRadius = 0;
            this.btn_previous.IdleBorderThickness = 0;
            this.btn_previous.IdleFillColor = System.Drawing.Color.Empty;
            this.btn_previous.IdleIconLeftImage = null;
            this.btn_previous.IdleIconRightImage = null;
            this.btn_previous.IndicateFocus = false;
            this.btn_previous.Location = new System.Drawing.Point(15, 13);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_previous.OnDisabledState.BorderRadius = 1;
            this.btn_previous.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_previous.OnDisabledState.BorderThickness = 1;
            this.btn_previous.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_previous.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_previous.OnDisabledState.IconLeftImage = null;
            this.btn_previous.OnDisabledState.IconRightImage = null;
            this.btn_previous.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btn_previous.onHoverState.BorderRadius = 1;
            this.btn_previous.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_previous.onHoverState.BorderThickness = 1;
            this.btn_previous.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btn_previous.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_previous.onHoverState.IconLeftImage = null;
            this.btn_previous.onHoverState.IconRightImage = null;
            this.btn_previous.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_previous.OnIdleState.BorderRadius = 1;
            this.btn_previous.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_previous.OnIdleState.BorderThickness = 1;
            this.btn_previous.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_previous.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_previous.OnIdleState.IconLeftImage = null;
            this.btn_previous.OnIdleState.IconRightImage = null;
            this.btn_previous.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_previous.OnPressedState.BorderRadius = 1;
            this.btn_previous.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_previous.OnPressedState.BorderThickness = 1;
            this.btn_previous.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_previous.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_previous.OnPressedState.IconLeftImage = null;
            this.btn_previous.OnPressedState.IconRightImage = null;
            this.btn_previous.Size = new System.Drawing.Size(80, 18);
            this.btn_previous.TabIndex = 6;
            this.btn_previous.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_previous.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_previous.TextMarginLeft = 0;
            this.btn_previous.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_previous.UseDefaultRadiusAndThickness = true;
            this.btn_previous.Click += new System.EventHandler(this.Preives_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(59, 206);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(618, 307);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 743);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuGradientPanel3);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.bunifuGradientPanel3.ResumeLayout(false);
            this.bunifuGradientPanel3.PerformLayout();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label lbl_nojobslisted;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.Label lbl_noofapplicants;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel3;
        private System.Windows.Forms.Label lbl_noofinterviews;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel pnl_shedule;
        private System.Windows.Forms.Label lbl_month;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_nxt;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_previous;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}