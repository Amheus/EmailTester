namespace EmailTester
{
    partial class MainMenu
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
            this.groupBox_serverDetails = new System.Windows.Forms.GroupBox();
            this.groupBox_serverDetails_sendFromEmail = new System.Windows.Forms.GroupBox();
            this.textBox_serverDetails_sendFromEmail = new System.Windows.Forms.TextBox();
            this.groupBox_serverDetails_smtpClient = new System.Windows.Forms.GroupBox();
            this.groupBox_serverDetails_domain = new System.Windows.Forms.GroupBox();
            this.textBox_serverDetails_domain = new System.Windows.Forms.TextBox();
            this.groupBox_serverDetails_port = new System.Windows.Forms.GroupBox();
            this.groupBox_serverDetails_credentials = new System.Windows.Forms.GroupBox();
            this.groupBox_serverDetails_password = new System.Windows.Forms.GroupBox();
            this.textBox_serverDetails_password = new System.Windows.Forms.TextBox();
            this.groupBox_serverDetails_username = new System.Windows.Forms.GroupBox();
            this.textBox_serverDetails_username = new System.Windows.Forms.TextBox();
            this.numericUpDown_serverDetails_port = new System.Windows.Forms.NumericUpDown();
            this.groupBox_clientDetails_clientDetails = new System.Windows.Forms.GroupBox();
            this.groupBox_clientDetails_credentials = new System.Windows.Forms.GroupBox();
            this.groupBox_clientDetails_body = new System.Windows.Forms.GroupBox();
            this.textBox_clientDetails_body = new System.Windows.Forms.TextBox();
            this.groupBox_clientDetails_subject = new System.Windows.Forms.GroupBox();
            this.textBox_clientDetails_subject = new System.Windows.Forms.TextBox();
            this.groupBox_clientDetails_sendToEmail = new System.Windows.Forms.GroupBox();
            this.textBox_clientDetails_sendToEmail = new System.Windows.Forms.TextBox();
            this.button_sendEmail = new System.Windows.Forms.Button();
            this.groupBox_serverDetails.SuspendLayout();
            this.groupBox_serverDetails_sendFromEmail.SuspendLayout();
            this.groupBox_serverDetails_smtpClient.SuspendLayout();
            this.groupBox_serverDetails_domain.SuspendLayout();
            this.groupBox_serverDetails_port.SuspendLayout();
            this.groupBox_serverDetails_credentials.SuspendLayout();
            this.groupBox_serverDetails_password.SuspendLayout();
            this.groupBox_serverDetails_username.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_serverDetails_port)).BeginInit();
            this.groupBox_clientDetails_clientDetails.SuspendLayout();
            this.groupBox_clientDetails_credentials.SuspendLayout();
            this.groupBox_clientDetails_body.SuspendLayout();
            this.groupBox_clientDetails_subject.SuspendLayout();
            this.groupBox_clientDetails_sendToEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_serverDetails
            // 
            this.groupBox_serverDetails.Controls.Add(this.groupBox_serverDetails_credentials);
            this.groupBox_serverDetails.Controls.Add(this.groupBox_serverDetails_smtpClient);
            this.groupBox_serverDetails.Controls.Add(this.groupBox_serverDetails_sendFromEmail);
            this.groupBox_serverDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_serverDetails.Location = new System.Drawing.Point(0, 0);
            this.groupBox_serverDetails.Name = "groupBox_serverDetails";
            this.groupBox_serverDetails.Size = new System.Drawing.Size(518, 155);
            this.groupBox_serverDetails.TabIndex = 0;
            this.groupBox_serverDetails.TabStop = false;
            this.groupBox_serverDetails.Text = "Server Details";
            // 
            // groupBox_serverDetails_sendFromEmail
            // 
            this.groupBox_serverDetails_sendFromEmail.Controls.Add(this.textBox_serverDetails_sendFromEmail);
            this.groupBox_serverDetails_sendFromEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_serverDetails_sendFromEmail.Location = new System.Drawing.Point(3, 16);
            this.groupBox_serverDetails_sendFromEmail.Name = "groupBox_serverDetails_sendFromEmail";
            this.groupBox_serverDetails_sendFromEmail.Size = new System.Drawing.Size(512, 39);
            this.groupBox_serverDetails_sendFromEmail.TabIndex = 1;
            this.groupBox_serverDetails_sendFromEmail.TabStop = false;
            this.groupBox_serverDetails_sendFromEmail.Text = "Send From Email";
            // 
            // textBox_serverDetails_sendFromEmail
            // 
            this.textBox_serverDetails_sendFromEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_serverDetails_sendFromEmail.Location = new System.Drawing.Point(3, 16);
            this.textBox_serverDetails_sendFromEmail.Name = "textBox_serverDetails_sendFromEmail";
            this.textBox_serverDetails_sendFromEmail.Size = new System.Drawing.Size(506, 20);
            this.textBox_serverDetails_sendFromEmail.TabIndex = 2;
            // 
            // groupBox_serverDetails_smtpClient
            // 
            this.groupBox_serverDetails_smtpClient.Controls.Add(this.groupBox_serverDetails_port);
            this.groupBox_serverDetails_smtpClient.Controls.Add(this.groupBox_serverDetails_domain);
            this.groupBox_serverDetails_smtpClient.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox_serverDetails_smtpClient.Location = new System.Drawing.Point(3, 55);
            this.groupBox_serverDetails_smtpClient.Name = "groupBox_serverDetails_smtpClient";
            this.groupBox_serverDetails_smtpClient.Size = new System.Drawing.Size(247, 97);
            this.groupBox_serverDetails_smtpClient.TabIndex = 2;
            this.groupBox_serverDetails_smtpClient.TabStop = false;
            this.groupBox_serverDetails_smtpClient.Text = "SMTP Client";
            // 
            // groupBox_serverDetails_domain
            // 
            this.groupBox_serverDetails_domain.Controls.Add(this.textBox_serverDetails_domain);
            this.groupBox_serverDetails_domain.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_serverDetails_domain.Location = new System.Drawing.Point(3, 16);
            this.groupBox_serverDetails_domain.Name = "groupBox_serverDetails_domain";
            this.groupBox_serverDetails_domain.Size = new System.Drawing.Size(241, 39);
            this.groupBox_serverDetails_domain.TabIndex = 2;
            this.groupBox_serverDetails_domain.TabStop = false;
            this.groupBox_serverDetails_domain.Text = "Domain";
            // 
            // textBox_serverDetails_domain
            // 
            this.textBox_serverDetails_domain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_serverDetails_domain.Location = new System.Drawing.Point(3, 16);
            this.textBox_serverDetails_domain.Name = "textBox_serverDetails_domain";
            this.textBox_serverDetails_domain.Size = new System.Drawing.Size(235, 20);
            this.textBox_serverDetails_domain.TabIndex = 2;
            // 
            // groupBox_serverDetails_port
            // 
            this.groupBox_serverDetails_port.Controls.Add(this.numericUpDown_serverDetails_port);
            this.groupBox_serverDetails_port.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_serverDetails_port.Location = new System.Drawing.Point(3, 55);
            this.groupBox_serverDetails_port.Name = "groupBox_serverDetails_port";
            this.groupBox_serverDetails_port.Size = new System.Drawing.Size(241, 39);
            this.groupBox_serverDetails_port.TabIndex = 3;
            this.groupBox_serverDetails_port.TabStop = false;
            this.groupBox_serverDetails_port.Text = "Port";
            // 
            // groupBox_serverDetails_credentials
            // 
            this.groupBox_serverDetails_credentials.Controls.Add(this.groupBox_serverDetails_password);
            this.groupBox_serverDetails_credentials.Controls.Add(this.groupBox_serverDetails_username);
            this.groupBox_serverDetails_credentials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_serverDetails_credentials.Location = new System.Drawing.Point(250, 55);
            this.groupBox_serverDetails_credentials.Name = "groupBox_serverDetails_credentials";
            this.groupBox_serverDetails_credentials.Size = new System.Drawing.Size(265, 97);
            this.groupBox_serverDetails_credentials.TabIndex = 3;
            this.groupBox_serverDetails_credentials.TabStop = false;
            this.groupBox_serverDetails_credentials.Text = "Credentials";
            // 
            // groupBox_serverDetails_password
            // 
            this.groupBox_serverDetails_password.Controls.Add(this.textBox_serverDetails_password);
            this.groupBox_serverDetails_password.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_serverDetails_password.Location = new System.Drawing.Point(3, 55);
            this.groupBox_serverDetails_password.Name = "groupBox_serverDetails_password";
            this.groupBox_serverDetails_password.Size = new System.Drawing.Size(259, 39);
            this.groupBox_serverDetails_password.TabIndex = 3;
            this.groupBox_serverDetails_password.TabStop = false;
            this.groupBox_serverDetails_password.Text = "Password";
            // 
            // textBox_serverDetails_password
            // 
            this.textBox_serverDetails_password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_serverDetails_password.Location = new System.Drawing.Point(3, 16);
            this.textBox_serverDetails_password.Name = "textBox_serverDetails_password";
            this.textBox_serverDetails_password.Size = new System.Drawing.Size(253, 20);
            this.textBox_serverDetails_password.TabIndex = 2;
            // 
            // groupBox_serverDetails_username
            // 
            this.groupBox_serverDetails_username.Controls.Add(this.textBox_serverDetails_username);
            this.groupBox_serverDetails_username.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_serverDetails_username.Location = new System.Drawing.Point(3, 16);
            this.groupBox_serverDetails_username.Name = "groupBox_serverDetails_username";
            this.groupBox_serverDetails_username.Size = new System.Drawing.Size(259, 39);
            this.groupBox_serverDetails_username.TabIndex = 2;
            this.groupBox_serverDetails_username.TabStop = false;
            this.groupBox_serverDetails_username.Text = "Username";
            // 
            // textBox_serverDetails_username
            // 
            this.textBox_serverDetails_username.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_serverDetails_username.Location = new System.Drawing.Point(3, 16);
            this.textBox_serverDetails_username.Name = "textBox_serverDetails_username";
            this.textBox_serverDetails_username.Size = new System.Drawing.Size(253, 20);
            this.textBox_serverDetails_username.TabIndex = 2;
            // 
            // numericUpDown_serverDetails_port
            // 
            this.numericUpDown_serverDetails_port.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown_serverDetails_port.Location = new System.Drawing.Point(3, 16);
            this.numericUpDown_serverDetails_port.Name = "numericUpDown_serverDetails_port";
            this.numericUpDown_serverDetails_port.Size = new System.Drawing.Size(235, 20);
            this.numericUpDown_serverDetails_port.TabIndex = 1;
            // 
            // groupBox_clientDetails_clientDetails
            // 
            this.groupBox_clientDetails_clientDetails.Controls.Add(this.groupBox_clientDetails_credentials);
            this.groupBox_clientDetails_clientDetails.Controls.Add(this.groupBox_clientDetails_sendToEmail);
            this.groupBox_clientDetails_clientDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_clientDetails_clientDetails.Location = new System.Drawing.Point(0, 155);
            this.groupBox_clientDetails_clientDetails.Name = "groupBox_clientDetails_clientDetails";
            this.groupBox_clientDetails_clientDetails.Size = new System.Drawing.Size(518, 235);
            this.groupBox_clientDetails_clientDetails.TabIndex = 1;
            this.groupBox_clientDetails_clientDetails.TabStop = false;
            this.groupBox_clientDetails_clientDetails.Text = "Client Details";
            // 
            // groupBox_clientDetails_credentials
            // 
            this.groupBox_clientDetails_credentials.Controls.Add(this.groupBox_clientDetails_body);
            this.groupBox_clientDetails_credentials.Controls.Add(this.groupBox_clientDetails_subject);
            this.groupBox_clientDetails_credentials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_clientDetails_credentials.Location = new System.Drawing.Point(3, 55);
            this.groupBox_clientDetails_credentials.Name = "groupBox_clientDetails_credentials";
            this.groupBox_clientDetails_credentials.Size = new System.Drawing.Size(512, 177);
            this.groupBox_clientDetails_credentials.TabIndex = 3;
            this.groupBox_clientDetails_credentials.TabStop = false;
            this.groupBox_clientDetails_credentials.Text = "Credentials";
            // 
            // groupBox_clientDetails_body
            // 
            this.groupBox_clientDetails_body.Controls.Add(this.textBox_clientDetails_body);
            this.groupBox_clientDetails_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_clientDetails_body.Location = new System.Drawing.Point(3, 55);
            this.groupBox_clientDetails_body.Name = "groupBox_clientDetails_body";
            this.groupBox_clientDetails_body.Size = new System.Drawing.Size(506, 119);
            this.groupBox_clientDetails_body.TabIndex = 3;
            this.groupBox_clientDetails_body.TabStop = false;
            this.groupBox_clientDetails_body.Text = "Contents";
            // 
            // textBox_clientDetails_body
            // 
            this.textBox_clientDetails_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_clientDetails_body.Location = new System.Drawing.Point(3, 16);
            this.textBox_clientDetails_body.Multiline = true;
            this.textBox_clientDetails_body.Name = "textBox_clientDetails_body";
            this.textBox_clientDetails_body.Size = new System.Drawing.Size(500, 100);
            this.textBox_clientDetails_body.TabIndex = 2;
            // 
            // groupBox_clientDetails_subject
            // 
            this.groupBox_clientDetails_subject.Controls.Add(this.textBox_clientDetails_subject);
            this.groupBox_clientDetails_subject.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_clientDetails_subject.Location = new System.Drawing.Point(3, 16);
            this.groupBox_clientDetails_subject.Name = "groupBox_clientDetails_subject";
            this.groupBox_clientDetails_subject.Size = new System.Drawing.Size(506, 39);
            this.groupBox_clientDetails_subject.TabIndex = 2;
            this.groupBox_clientDetails_subject.TabStop = false;
            this.groupBox_clientDetails_subject.Text = "Subject";
            // 
            // textBox_clientDetails_subject
            // 
            this.textBox_clientDetails_subject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_clientDetails_subject.Location = new System.Drawing.Point(3, 16);
            this.textBox_clientDetails_subject.Name = "textBox_clientDetails_subject";
            this.textBox_clientDetails_subject.Size = new System.Drawing.Size(500, 20);
            this.textBox_clientDetails_subject.TabIndex = 2;
            // 
            // groupBox_clientDetails_sendToEmail
            // 
            this.groupBox_clientDetails_sendToEmail.Controls.Add(this.textBox_clientDetails_sendToEmail);
            this.groupBox_clientDetails_sendToEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_clientDetails_sendToEmail.Location = new System.Drawing.Point(3, 16);
            this.groupBox_clientDetails_sendToEmail.Name = "groupBox_clientDetails_sendToEmail";
            this.groupBox_clientDetails_sendToEmail.Size = new System.Drawing.Size(512, 39);
            this.groupBox_clientDetails_sendToEmail.TabIndex = 1;
            this.groupBox_clientDetails_sendToEmail.TabStop = false;
            this.groupBox_clientDetails_sendToEmail.Text = "Send To Email";
            // 
            // textBox_clientDetails_sendToEmail
            // 
            this.textBox_clientDetails_sendToEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_clientDetails_sendToEmail.Location = new System.Drawing.Point(3, 16);
            this.textBox_clientDetails_sendToEmail.Name = "textBox_clientDetails_sendToEmail";
            this.textBox_clientDetails_sendToEmail.Size = new System.Drawing.Size(506, 20);
            this.textBox_clientDetails_sendToEmail.TabIndex = 2;
            // 
            // button_sendEmail
            // 
            this.button_sendEmail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_sendEmail.Location = new System.Drawing.Point(0, 390);
            this.button_sendEmail.Name = "button_sendEmail";
            this.button_sendEmail.Size = new System.Drawing.Size(518, 23);
            this.button_sendEmail.TabIndex = 2;
            this.button_sendEmail.Text = "send email";
            this.button_sendEmail.UseVisualStyleBackColor = true;
            this.button_sendEmail.Click += new System.EventHandler(this.button_sendEmail_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 413);
            this.Controls.Add(this.groupBox_clientDetails_clientDetails);
            this.Controls.Add(this.groupBox_serverDetails);
            this.Controls.Add(this.button_sendEmail);
            this.MinimumSize = new System.Drawing.Size(534, 452);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.groupBox_serverDetails.ResumeLayout(false);
            this.groupBox_serverDetails_sendFromEmail.ResumeLayout(false);
            this.groupBox_serverDetails_sendFromEmail.PerformLayout();
            this.groupBox_serverDetails_smtpClient.ResumeLayout(false);
            this.groupBox_serverDetails_domain.ResumeLayout(false);
            this.groupBox_serverDetails_domain.PerformLayout();
            this.groupBox_serverDetails_port.ResumeLayout(false);
            this.groupBox_serverDetails_credentials.ResumeLayout(false);
            this.groupBox_serverDetails_password.ResumeLayout(false);
            this.groupBox_serverDetails_password.PerformLayout();
            this.groupBox_serverDetails_username.ResumeLayout(false);
            this.groupBox_serverDetails_username.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_serverDetails_port)).EndInit();
            this.groupBox_clientDetails_clientDetails.ResumeLayout(false);
            this.groupBox_clientDetails_credentials.ResumeLayout(false);
            this.groupBox_clientDetails_body.ResumeLayout(false);
            this.groupBox_clientDetails_body.PerformLayout();
            this.groupBox_clientDetails_subject.ResumeLayout(false);
            this.groupBox_clientDetails_subject.PerformLayout();
            this.groupBox_clientDetails_sendToEmail.ResumeLayout(false);
            this.groupBox_clientDetails_sendToEmail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_serverDetails;
        private System.Windows.Forms.GroupBox groupBox_serverDetails_sendFromEmail;
        private System.Windows.Forms.TextBox textBox_serverDetails_sendFromEmail;
        private System.Windows.Forms.GroupBox groupBox_serverDetails_credentials;
        private System.Windows.Forms.GroupBox groupBox_serverDetails_password;
        private System.Windows.Forms.TextBox textBox_serverDetails_password;
        private System.Windows.Forms.GroupBox groupBox_serverDetails_username;
        private System.Windows.Forms.TextBox textBox_serverDetails_username;
        private System.Windows.Forms.GroupBox groupBox_serverDetails_smtpClient;
        private System.Windows.Forms.GroupBox groupBox_serverDetails_port;
        private System.Windows.Forms.NumericUpDown numericUpDown_serverDetails_port;
        private System.Windows.Forms.GroupBox groupBox_serverDetails_domain;
        private System.Windows.Forms.TextBox textBox_serverDetails_domain;
        private System.Windows.Forms.GroupBox groupBox_clientDetails_clientDetails;
        private System.Windows.Forms.GroupBox groupBox_clientDetails_credentials;
        private System.Windows.Forms.GroupBox groupBox_clientDetails_body;
        private System.Windows.Forms.TextBox textBox_clientDetails_body;
        private System.Windows.Forms.GroupBox groupBox_clientDetails_subject;
        private System.Windows.Forms.TextBox textBox_clientDetails_subject;
        private System.Windows.Forms.GroupBox groupBox_clientDetails_sendToEmail;
        private System.Windows.Forms.TextBox textBox_clientDetails_sendToEmail;
        private System.Windows.Forms.Button button_sendEmail;
    }
}