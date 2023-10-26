namespace JOB_FINDER.Employee_Forms.Career_Guidance
{
    partial class AI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AI));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.btn_search = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txt_chat = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btn_hi = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_new_jobs = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.show_txt = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_search
            // 
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
            this.btn_search.Image = global::JOB_FINDER.Properties.Resources.icons8_apply_25;
            this.btn_search.Location = new System.Drawing.Point(839, 621);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(150, 45);
            this.btn_search.TabIndex = 19;
            this.btn_search.Text = "Send";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_chat
            // 
            this.txt_chat.AcceptsReturn = false;
            this.txt_chat.AcceptsTab = false;
            this.txt_chat.AnimationSpeed = 200;
            this.txt_chat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_chat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_chat.AutoSizeHeight = true;
            this.txt_chat.BackColor = System.Drawing.Color.Transparent;
            this.txt_chat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_chat.BackgroundImage")));
            this.txt_chat.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_chat.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_chat.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_chat.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_chat.BorderRadius = 1;
            this.txt_chat.BorderThickness = 1;
            this.txt_chat.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txt_chat.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_chat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_chat.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txt_chat.DefaultText = "";
            this.txt_chat.FillColor = System.Drawing.Color.White;
            this.txt_chat.HideSelection = true;
            this.txt_chat.IconLeft = null;
            this.txt_chat.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_chat.IconPadding = 10;
            this.txt_chat.IconRight = null;
            this.txt_chat.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_chat.Lines = new string[0];
            this.txt_chat.Location = new System.Drawing.Point(64, 623);
            this.txt_chat.MaxLength = 32767;
            this.txt_chat.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_chat.Modified = false;
            this.txt_chat.Multiline = false;
            this.txt_chat.Name = "txt_chat";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_chat.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_chat.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_chat.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_chat.OnIdleState = stateProperties4;
            this.txt_chat.Padding = new System.Windows.Forms.Padding(3);
            this.txt_chat.PasswordChar = '\0';
            this.txt_chat.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_chat.PlaceholderText = "Enter text";
            this.txt_chat.ReadOnly = false;
            this.txt_chat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_chat.SelectedText = "";
            this.txt_chat.SelectionLength = 0;
            this.txt_chat.SelectionStart = 0;
            this.txt_chat.ShortcutsEnabled = true;
            this.txt_chat.Size = new System.Drawing.Size(769, 43);
            this.txt_chat.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_chat.TabIndex = 20;
            this.txt_chat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_chat.TextMarginBottom = 0;
            this.txt_chat.TextMarginLeft = 3;
            this.txt_chat.TextMarginTop = 1;
            this.txt_chat.TextPlaceholder = "Enter text";
            this.txt_chat.UseSystemPasswordChar = false;
            this.txt_chat.WordWrap = true;
            // 
            // btn_hi
            // 
            this.btn_hi.AllowAnimations = true;
            this.btn_hi.AllowMouseEffects = true;
            this.btn_hi.AllowToggling = false;
            this.btn_hi.AnimationSpeed = 200;
            this.btn_hi.AutoGenerateColors = false;
            this.btn_hi.AutoRoundBorders = false;
            this.btn_hi.AutoSizeLeftIcon = true;
            this.btn_hi.AutoSizeRightIcon = true;
            this.btn_hi.BackColor = System.Drawing.Color.Transparent;
            this.btn_hi.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btn_hi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_hi.BackgroundImage")));
            this.btn_hi.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_hi.ButtonText = "Hi";
            this.btn_hi.ButtonTextMarginLeft = 0;
            this.btn_hi.ColorContrastOnClick = 45;
            this.btn_hi.ColorContrastOnHover = 45;
            this.btn_hi.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_hi.CustomizableEdges = borderEdges1;
            this.btn_hi.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_hi.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_hi.DisabledFillColor = System.Drawing.Color.Empty;
            this.btn_hi.DisabledForecolor = System.Drawing.Color.Empty;
            this.btn_hi.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_hi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hi.ForeColor = System.Drawing.Color.White;
            this.btn_hi.IconLeft = null;
            this.btn_hi.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hi.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_hi.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_hi.IconMarginLeft = 11;
            this.btn_hi.IconPadding = 10;
            this.btn_hi.IconRight = null;
            this.btn_hi.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_hi.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_hi.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_hi.IconSize = 25;
            this.btn_hi.IdleBorderColor = System.Drawing.Color.Empty;
            this.btn_hi.IdleBorderRadius = 0;
            this.btn_hi.IdleBorderThickness = 0;
            this.btn_hi.IdleFillColor = System.Drawing.Color.Empty;
            this.btn_hi.IdleIconLeftImage = null;
            this.btn_hi.IdleIconRightImage = null;
            this.btn_hi.IndicateFocus = false;
            this.btn_hi.Location = new System.Drawing.Point(64, 567);
            this.btn_hi.Name = "btn_hi";
            this.btn_hi.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_hi.OnDisabledState.BorderRadius = 1;
            this.btn_hi.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_hi.OnDisabledState.BorderThickness = 1;
            this.btn_hi.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_hi.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_hi.OnDisabledState.IconLeftImage = null;
            this.btn_hi.OnDisabledState.IconRightImage = null;
            this.btn_hi.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btn_hi.onHoverState.BorderRadius = 1;
            this.btn_hi.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_hi.onHoverState.BorderThickness = 1;
            this.btn_hi.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btn_hi.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_hi.onHoverState.IconLeftImage = null;
            this.btn_hi.onHoverState.IconRightImage = null;
            this.btn_hi.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_hi.OnIdleState.BorderRadius = 1;
            this.btn_hi.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_hi.OnIdleState.BorderThickness = 1;
            this.btn_hi.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_hi.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_hi.OnIdleState.IconLeftImage = null;
            this.btn_hi.OnIdleState.IconRightImage = null;
            this.btn_hi.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_hi.OnPressedState.BorderRadius = 1;
            this.btn_hi.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_hi.OnPressedState.BorderThickness = 1;
            this.btn_hi.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_hi.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_hi.OnPressedState.IconLeftImage = null;
            this.btn_hi.OnPressedState.IconRightImage = null;
            this.btn_hi.Size = new System.Drawing.Size(150, 39);
            this.btn_hi.TabIndex = 21;
            this.btn_hi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_hi.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_hi.TextMarginLeft = 0;
            this.btn_hi.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_hi.UseDefaultRadiusAndThickness = true;
            this.btn_hi.Click += new System.EventHandler(this.btn_hi_Click);
            // 
            // btn_new_jobs
            // 
            this.btn_new_jobs.AllowAnimations = true;
            this.btn_new_jobs.AllowMouseEffects = true;
            this.btn_new_jobs.AllowToggling = false;
            this.btn_new_jobs.AnimationSpeed = 200;
            this.btn_new_jobs.AutoGenerateColors = false;
            this.btn_new_jobs.AutoRoundBorders = false;
            this.btn_new_jobs.AutoSizeLeftIcon = true;
            this.btn_new_jobs.AutoSizeRightIcon = true;
            this.btn_new_jobs.BackColor = System.Drawing.Color.Transparent;
            this.btn_new_jobs.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btn_new_jobs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_new_jobs.BackgroundImage")));
            this.btn_new_jobs.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_new_jobs.ButtonText = "New Jobs";
            this.btn_new_jobs.ButtonTextMarginLeft = 0;
            this.btn_new_jobs.ColorContrastOnClick = 45;
            this.btn_new_jobs.ColorContrastOnHover = 45;
            this.btn_new_jobs.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_new_jobs.CustomizableEdges = borderEdges2;
            this.btn_new_jobs.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_new_jobs.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_new_jobs.DisabledFillColor = System.Drawing.Color.Empty;
            this.btn_new_jobs.DisabledForecolor = System.Drawing.Color.Empty;
            this.btn_new_jobs.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_new_jobs.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new_jobs.ForeColor = System.Drawing.Color.White;
            this.btn_new_jobs.IconLeft = null;
            this.btn_new_jobs.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_new_jobs.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_new_jobs.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_new_jobs.IconMarginLeft = 11;
            this.btn_new_jobs.IconPadding = 10;
            this.btn_new_jobs.IconRight = null;
            this.btn_new_jobs.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_new_jobs.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_new_jobs.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_new_jobs.IconSize = 25;
            this.btn_new_jobs.IdleBorderColor = System.Drawing.Color.Empty;
            this.btn_new_jobs.IdleBorderRadius = 0;
            this.btn_new_jobs.IdleBorderThickness = 0;
            this.btn_new_jobs.IdleFillColor = System.Drawing.Color.Empty;
            this.btn_new_jobs.IdleIconLeftImage = null;
            this.btn_new_jobs.IdleIconRightImage = null;
            this.btn_new_jobs.IndicateFocus = false;
            this.btn_new_jobs.Location = new System.Drawing.Point(220, 567);
            this.btn_new_jobs.Name = "btn_new_jobs";
            this.btn_new_jobs.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_new_jobs.OnDisabledState.BorderRadius = 1;
            this.btn_new_jobs.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_new_jobs.OnDisabledState.BorderThickness = 1;
            this.btn_new_jobs.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_new_jobs.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_new_jobs.OnDisabledState.IconLeftImage = null;
            this.btn_new_jobs.OnDisabledState.IconRightImage = null;
            this.btn_new_jobs.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btn_new_jobs.onHoverState.BorderRadius = 1;
            this.btn_new_jobs.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_new_jobs.onHoverState.BorderThickness = 1;
            this.btn_new_jobs.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btn_new_jobs.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_new_jobs.onHoverState.IconLeftImage = null;
            this.btn_new_jobs.onHoverState.IconRightImage = null;
            this.btn_new_jobs.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_new_jobs.OnIdleState.BorderRadius = 1;
            this.btn_new_jobs.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_new_jobs.OnIdleState.BorderThickness = 1;
            this.btn_new_jobs.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_new_jobs.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_new_jobs.OnIdleState.IconLeftImage = null;
            this.btn_new_jobs.OnIdleState.IconRightImage = null;
            this.btn_new_jobs.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_new_jobs.OnPressedState.BorderRadius = 1;
            this.btn_new_jobs.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_new_jobs.OnPressedState.BorderThickness = 1;
            this.btn_new_jobs.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_new_jobs.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_new_jobs.OnPressedState.IconLeftImage = null;
            this.btn_new_jobs.OnPressedState.IconRightImage = null;
            this.btn_new_jobs.Size = new System.Drawing.Size(150, 39);
            this.btn_new_jobs.TabIndex = 22;
            this.btn_new_jobs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_new_jobs.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_new_jobs.TextMarginLeft = 0;
            this.btn_new_jobs.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_new_jobs.UseDefaultRadiusAndThickness = true;
            this.btn_new_jobs.Click += new System.EventHandler(this.btn_new_jobs_Click);
            // 
            // show_txt
            // 
            this.show_txt.Location = new System.Drawing.Point(64, 12);
            this.show_txt.MaximumSize = new System.Drawing.Size(906, 544);
            this.show_txt.Name = "show_txt";
            this.show_txt.Size = new System.Drawing.Size(906, 544);
            this.show_txt.TabIndex = 23;
            this.show_txt.Text = "";
            // 
            // AI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1000, 720);
            this.Controls.Add(this.show_txt);
            this.Controls.Add(this.btn_new_jobs);
            this.Controls.Add(this.btn_hi);
            this.Controls.Add(this.txt_chat);
            this.Controls.Add(this.btn_search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AI";
            this.Text = "AI";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btn_search;
        private Bunifu.UI.WinForms.BunifuTextBox txt_chat;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_hi;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_new_jobs;
        private System.Windows.Forms.RichTextBox show_txt;
    }
}