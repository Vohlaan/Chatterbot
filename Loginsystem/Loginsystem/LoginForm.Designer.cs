namespace Loginsystem
{
    partial class LoginForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.statusStripButton = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelTitelTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTimeText = new System.Windows.Forms.ToolStripStatusLabel();
            this.CurrentTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.groupBoxVersion = new System.Windows.Forms.GroupBox();
            this.labelTextVersion = new System.Windows.Forms.Label();
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.groupBoxPassword = new System.Windows.Forms.GroupBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.groupBoxUsername = new System.Windows.Forms.GroupBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.buttonCreateLogin = new System.Windows.Forms.Button();
            this.statusStripButton.SuspendLayout();
            this.groupBoxLogin.SuspendLayout();
            this.groupBoxVersion.SuspendLayout();
            this.groupBoxUser.SuspendLayout();
            this.groupBoxPassword.SuspendLayout();
            this.groupBoxUsername.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStripButton
            // 
            this.statusStripButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelTitelTime,
            this.toolStripStatusLabelTimeText});
            this.statusStripButton.Location = new System.Drawing.Point(0, 239);
            this.statusStripButton.Name = "statusStripButton";
            this.statusStripButton.Size = new System.Drawing.Size(284, 22);
            this.statusStripButton.TabIndex = 0;
            this.statusStripButton.Text = "statusStripButton";
            // 
            // toolStripStatusLabelTitelTime
            // 
            this.toolStripStatusLabelTitelTime.Name = "toolStripStatusLabelTitelTime";
            this.toolStripStatusLabelTitelTime.Size = new System.Drawing.Size(40, 17);
            this.toolStripStatusLabelTitelTime.Text = "Time: ";
            // 
            // toolStripStatusLabelTimeText
            // 
            this.toolStripStatusLabelTimeText.Name = "toolStripStatusLabelTimeText";
            this.toolStripStatusLabelTimeText.Size = new System.Drawing.Size(31, 17);
            this.toolStripStatusLabelTimeText.Text = "time";
            // 
            // CurrentTimeTimer
            // 
            this.CurrentTimeTimer.Tick += new System.EventHandler(this.CurrentTimeTimer_Tick);
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.groupBoxVersion);
            this.groupBoxLogin.Controls.Add(this.groupBoxUser);
            this.groupBoxLogin.Location = new System.Drawing.Point(0, 0);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(284, 236);
            this.groupBoxLogin.TabIndex = 1;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "Login: ";
            // 
            // groupBoxVersion
            // 
            this.groupBoxVersion.Controls.Add(this.labelTextVersion);
            this.groupBoxVersion.Location = new System.Drawing.Point(6, 183);
            this.groupBoxVersion.Name = "groupBoxVersion";
            this.groupBoxVersion.Size = new System.Drawing.Size(266, 42);
            this.groupBoxVersion.TabIndex = 1;
            this.groupBoxVersion.TabStop = false;
            this.groupBoxVersion.Text = "Version:";
            // 
            // labelTextVersion
            // 
            this.labelTextVersion.AutoSize = true;
            this.labelTextVersion.Location = new System.Drawing.Point(9, 16);
            this.labelTextVersion.Name = "labelTextVersion";
            this.labelTextVersion.Size = new System.Drawing.Size(36, 13);
            this.labelTextVersion.TabIndex = 1;
            this.labelTextVersion.Text = "x.x.x.x";
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.Controls.Add(this.buttonCreateLogin);
            this.groupBoxUser.Controls.Add(this.buttonLogin);
            this.groupBoxUser.Controls.Add(this.groupBoxPassword);
            this.groupBoxUser.Controls.Add(this.groupBoxUsername);
            this.groupBoxUser.Location = new System.Drawing.Point(6, 19);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Size = new System.Drawing.Size(266, 158);
            this.groupBoxUser.TabIndex = 0;
            this.groupBoxUser.TabStop = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(6, 129);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(126, 23);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // groupBoxPassword
            // 
            this.groupBoxPassword.Controls.Add(this.textBoxPassword);
            this.groupBoxPassword.Location = new System.Drawing.Point(6, 77);
            this.groupBoxPassword.Name = "groupBoxPassword";
            this.groupBoxPassword.Size = new System.Drawing.Size(254, 47);
            this.groupBoxPassword.TabIndex = 1;
            this.groupBoxPassword.TabStop = false;
            this.groupBoxPassword.Text = "Password:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(6, 19);
            this.textBoxPassword.MaxLength = 32;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(242, 20);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // groupBoxUsername
            // 
            this.groupBoxUsername.Controls.Add(this.textBoxUsername);
            this.groupBoxUsername.Location = new System.Drawing.Point(6, 19);
            this.groupBoxUsername.Name = "groupBoxUsername";
            this.groupBoxUsername.Size = new System.Drawing.Size(254, 52);
            this.groupBoxUsername.TabIndex = 0;
            this.groupBoxUsername.TabStop = false;
            this.groupBoxUsername.Text = "Username:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(6, 19);
            this.textBoxUsername.MaxLength = 16;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(242, 20);
            this.textBoxUsername.TabIndex = 1;
            this.textBoxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonCreateLogin
            // 
            this.buttonCreateLogin.Location = new System.Drawing.Point(132, 129);
            this.buttonCreateLogin.Name = "buttonCreateLogin";
            this.buttonCreateLogin.Size = new System.Drawing.Size(128, 23);
            this.buttonCreateLogin.TabIndex = 4;
            this.buttonCreateLogin.Text = "Konto Erstellen";
            this.buttonCreateLogin.UseVisualStyleBackColor = true;
            this.buttonCreateLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupBoxLogin);
            this.Controls.Add(this.statusStripButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.statusStripButton.ResumeLayout(false);
            this.statusStripButton.PerformLayout();
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxVersion.ResumeLayout(false);
            this.groupBoxVersion.PerformLayout();
            this.groupBoxUser.ResumeLayout(false);
            this.groupBoxPassword.ResumeLayout(false);
            this.groupBoxPassword.PerformLayout();
            this.groupBoxUsername.ResumeLayout(false);
            this.groupBoxUsername.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStripButton;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTitelTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTimeText;
        private System.Windows.Forms.Timer CurrentTimeTimer;
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.GroupBox groupBoxVersion;
        private System.Windows.Forms.GroupBox groupBoxUser;
        private System.Windows.Forms.GroupBox groupBoxPassword;
        private System.Windows.Forms.GroupBox groupBoxUsername;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelTextVersion;
        private System.Windows.Forms.Button buttonCreateLogin;
    }
}

