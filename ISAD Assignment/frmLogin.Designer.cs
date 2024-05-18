namespace ISAD_Assignment
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            Guna.UI.WinForms.GunaLabel lbLogin;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties17 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties18 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties19 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties20 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties21 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties22 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties23 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties24 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.frmLoginDrag = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.loginBG = new Guna.UI.WinForms.GunaPictureBox();
            this.frmLoginDrag1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.siticoneCheckBox1 = new Siticone.UI.WinForms.SiticoneCheckBox();
            this.bunifuTextBox1 = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuTextBox2 = new Bunifu.UI.WinForms.BunifuTextBox();
            lbLogin = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.loginBG)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.BackColor = System.Drawing.Color.Transparent;
            lbLogin.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            lbLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(221)))));
            lbLogin.Location = new System.Drawing.Point(814, 113);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new System.Drawing.Size(236, 45);
            lbLogin.TabIndex = 1;
            lbLogin.Text = "Login Account";
            // 
            // frmLoginDrag
            // 
            this.frmLoginDrag.TargetControl = this;
            // 
            // loginBG
            // 
            this.loginBG.BackColor = System.Drawing.Color.Transparent;
            this.loginBG.BaseColor = System.Drawing.Color.White;
            this.loginBG.Image = ((System.Drawing.Image)(resources.GetObject("loginBG.Image")));
            this.loginBG.Location = new System.Drawing.Point(0, 0);
            this.loginBG.MaximumSize = new System.Drawing.Size(620, 700);
            this.loginBG.MinimumSize = new System.Drawing.Size(620, 700);
            this.loginBG.Name = "loginBG";
            this.loginBG.Size = new System.Drawing.Size(620, 700);
            this.loginBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loginBG.TabIndex = 0;
            this.loginBG.TabStop = false;
            // 
            // frmLoginDrag1
            // 
            this.frmLoginDrag1.TargetControl = this.loginBG;
            // 
            // siticoneCheckBox1
            // 
            this.siticoneCheckBox1.AutoSize = true;
            this.siticoneCheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneCheckBox1.CheckedState.BorderRadius = 2;
            this.siticoneCheckBox1.CheckedState.BorderThickness = 0;
            this.siticoneCheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneCheckBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.siticoneCheckBox1.ForeColor = System.Drawing.Color.Gray;
            this.siticoneCheckBox1.Location = new System.Drawing.Point(690, 383);
            this.siticoneCheckBox1.Name = "siticoneCheckBox1";
            this.siticoneCheckBox1.Size = new System.Drawing.Size(123, 23);
            this.siticoneCheckBox1.TabIndex = 2;
            this.siticoneCheckBox1.Text = "Show Password";
            this.siticoneCheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCheckBox1.UncheckedState.BorderRadius = 2;
            this.siticoneCheckBox1.UncheckedState.BorderThickness = 0;
            this.siticoneCheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCheckBox1.UseVisualStyleBackColor = true;
            // 
            // bunifuTextBox1
            // 
            this.bunifuTextBox1.AcceptsReturn = false;
            this.bunifuTextBox1.AcceptsTab = false;
            this.bunifuTextBox1.AnimationSpeed = 200;
            this.bunifuTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox1.BackColor = System.Drawing.Color.White;
            this.bunifuTextBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox1.BackgroundImage")));
            this.bunifuTextBox1.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(221)))));
            this.bunifuTextBox1.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuTextBox1.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.bunifuTextBox1.BorderColorIdle = System.Drawing.Color.Silver;
            this.bunifuTextBox1.BorderRadius = 1;
            this.bunifuTextBox1.BorderThickness = 1;
            this.bunifuTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.DefaultFont = new System.Drawing.Font("Segoe UI", 16F);
            this.bunifuTextBox1.DefaultText = "";
            this.bunifuTextBox1.FillColor = System.Drawing.Color.White;
            this.bunifuTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuTextBox1.HideSelection = true;
            this.bunifuTextBox1.IconLeft = null;
            this.bunifuTextBox1.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.IconPadding = 10;
            this.bunifuTextBox1.IconRight = null;
            this.bunifuTextBox1.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.Lines = new string[0];
            this.bunifuTextBox1.Location = new System.Drawing.Point(690, 211);
            this.bunifuTextBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.bunifuTextBox1.MaximumSize = new System.Drawing.Size(485, 55);
            this.bunifuTextBox1.MaxLength = 32767;
            this.bunifuTextBox1.MinimumSize = new System.Drawing.Size(485, 55);
            this.bunifuTextBox1.Modified = false;
            this.bunifuTextBox1.Multiline = false;
            this.bunifuTextBox1.Name = "bunifuTextBox1";
            stateProperties17.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(221)))));
            stateProperties17.FillColor = System.Drawing.Color.Empty;
            stateProperties17.ForeColor = System.Drawing.Color.Empty;
            stateProperties17.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnActiveState = stateProperties17;
            stateProperties18.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties18.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties18.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.bunifuTextBox1.OnDisabledState = stateProperties18;
            stateProperties19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            stateProperties19.FillColor = System.Drawing.Color.Empty;
            stateProperties19.ForeColor = System.Drawing.Color.Empty;
            stateProperties19.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnHoverState = stateProperties19;
            stateProperties20.BorderColor = System.Drawing.Color.Silver;
            stateProperties20.FillColor = System.Drawing.Color.White;
            stateProperties20.ForeColor = System.Drawing.Color.DimGray;
            stateProperties20.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnIdleState = stateProperties20;
            this.bunifuTextBox1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.bunifuTextBox1.PasswordChar = '\0';
            this.bunifuTextBox1.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.bunifuTextBox1.PlaceholderText = "Enter username";
            this.bunifuTextBox1.ReadOnly = false;
            this.bunifuTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bunifuTextBox1.SelectedText = "";
            this.bunifuTextBox1.SelectionLength = 0;
            this.bunifuTextBox1.SelectionStart = 0;
            this.bunifuTextBox1.ShortcutsEnabled = true;
            this.bunifuTextBox1.Size = new System.Drawing.Size(485, 55);
            this.bunifuTextBox1.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.bunifuTextBox1.TabIndex = 6;
            this.bunifuTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBox1.TextMarginBottom = 0;
            this.bunifuTextBox1.TextMarginLeft = 3;
            this.bunifuTextBox1.TextMarginTop = 0;
            this.bunifuTextBox1.TextPlaceholder = "Enter username";
            this.bunifuTextBox1.UseSystemPasswordChar = false;
            this.bunifuTextBox1.WordWrap = true;
            // 
            // bunifuTextBox2
            // 
            this.bunifuTextBox2.AcceptsReturn = false;
            this.bunifuTextBox2.AcceptsTab = false;
            this.bunifuTextBox2.AnimationSpeed = 200;
            this.bunifuTextBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox2.BackColor = System.Drawing.Color.White;
            this.bunifuTextBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox2.BackgroundImage")));
            this.bunifuTextBox2.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(221)))));
            this.bunifuTextBox2.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuTextBox2.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.bunifuTextBox2.BorderColorIdle = System.Drawing.Color.Silver;
            this.bunifuTextBox2.BorderRadius = 1;
            this.bunifuTextBox2.BorderThickness = 1;
            this.bunifuTextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox2.DefaultFont = new System.Drawing.Font("Segoe UI", 16F);
            this.bunifuTextBox2.DefaultText = "";
            this.bunifuTextBox2.FillColor = System.Drawing.Color.White;
            this.bunifuTextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuTextBox2.HideSelection = true;
            this.bunifuTextBox2.IconLeft = null;
            this.bunifuTextBox2.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox2.IconPadding = 10;
            this.bunifuTextBox2.IconRight = null;
            this.bunifuTextBox2.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox2.Lines = new string[0];
            this.bunifuTextBox2.Location = new System.Drawing.Point(690, 307);
            this.bunifuTextBox2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.bunifuTextBox2.MaximumSize = new System.Drawing.Size(485, 55);
            this.bunifuTextBox2.MaxLength = 32767;
            this.bunifuTextBox2.MinimumSize = new System.Drawing.Size(485, 55);
            this.bunifuTextBox2.Modified = false;
            this.bunifuTextBox2.Multiline = false;
            this.bunifuTextBox2.Name = "bunifuTextBox2";
            stateProperties21.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(221)))));
            stateProperties21.FillColor = System.Drawing.Color.Empty;
            stateProperties21.ForeColor = System.Drawing.Color.Empty;
            stateProperties21.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox2.OnActiveState = stateProperties21;
            stateProperties22.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties22.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties22.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.bunifuTextBox2.OnDisabledState = stateProperties22;
            stateProperties23.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            stateProperties23.FillColor = System.Drawing.Color.Empty;
            stateProperties23.ForeColor = System.Drawing.Color.Empty;
            stateProperties23.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox2.OnHoverState = stateProperties23;
            stateProperties24.BorderColor = System.Drawing.Color.Silver;
            stateProperties24.FillColor = System.Drawing.Color.White;
            stateProperties24.ForeColor = System.Drawing.Color.DimGray;
            stateProperties24.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox2.OnIdleState = stateProperties24;
            this.bunifuTextBox2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.bunifuTextBox2.PasswordChar = '●';
            this.bunifuTextBox2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.bunifuTextBox2.PlaceholderText = "Enter password";
            this.bunifuTextBox2.ReadOnly = false;
            this.bunifuTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bunifuTextBox2.SelectedText = "";
            this.bunifuTextBox2.SelectionLength = 0;
            this.bunifuTextBox2.SelectionStart = 0;
            this.bunifuTextBox2.ShortcutsEnabled = true;
            this.bunifuTextBox2.Size = new System.Drawing.Size(485, 55);
            this.bunifuTextBox2.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.bunifuTextBox2.TabIndex = 7;
            this.bunifuTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBox2.TextMarginBottom = 0;
            this.bunifuTextBox2.TextMarginLeft = 3;
            this.bunifuTextBox2.TextMarginTop = 0;
            this.bunifuTextBox2.TextPlaceholder = "Enter password";
            this.bunifuTextBox2.UseSystemPasswordChar = true;
            this.bunifuTextBox2.WordWrap = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1240, 700);
            this.Controls.Add(this.bunifuTextBox2);
            this.Controls.Add(this.bunifuTextBox1);
            this.Controls.Add(this.siticoneCheckBox1);
            this.Controls.Add(lbLogin);
            this.Controls.Add(this.loginBG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1240, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1240, 700);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaDragControl frmLoginDrag;
        private Guna.UI.WinForms.GunaPictureBox loginBG;
        private Guna.UI.WinForms.GunaDragControl frmLoginDrag1;
        private Siticone.UI.WinForms.SiticoneCheckBox siticoneCheckBox1;
        private Bunifu.UI.WinForms.BunifuTextBox bunifuTextBox1;
        private Bunifu.UI.WinForms.BunifuTextBox bunifuTextBox2;
    }
}

