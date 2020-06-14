using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailTester
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button_sendEmail_Click(object sender, EventArgs e)
        {
            try
            {
                using (SmtpClient smtpServer = new SmtpClient(textBox_serverDetails_domain.Text))
                {
                    smtpServer.EnableSsl = true;
                    smtpServer.Credentials = new System.Net.NetworkCredential(textBox_serverDetails_username.Text, textBox_serverDetails_password.Text);
                    smtpServer.Port = System.Convert.ToInt32(numericUpDown_serverDetails_port.Value);

                    using (MailMessage email = new MailMessage())
                    {
                        email.Body = textBox_clientDetails_body.Text;
                        email.From = new MailAddress(textBox_serverDetails_sendFromEmail.Text);
                        email.Subject = textBox_clientDetails_subject.Text;
                        email.To.Add(textBox_clientDetails_sendToEmail.Text);

                        smtpServer.Send(email);
                    }
                }

                MessageBox.Show("email has been sent!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
