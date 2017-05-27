using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace MSCI_445___Lab_2
{
    public partial class Password : Form
    {
        private string PasswordCheck { get; set; }
        private string UserCheck { get; set; }
        private string From { get; set; }
        private string To { get; set; }
        private string Subject { get; set; }
        private string Body { get; set; }
        public Password(string from, string to, string subject, string body)
        {
            // Initializes variables according the field names of the fields used in email form
            InitializeComponent();
            To = to;
            From = from;
            Subject = subject;
            Body = body;
            PasswordCheck = "mscilab2445";
            UserCheck = "shivammsci445@gmail.com";
        }
        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                // Trying to establish a connection if the 'From' email and 'Password' are input correctly
                if (PasswordCheck == SecurityKey.Text)
                {
                    if (From == UserCheck && PasswordCheck == SecurityKey.Text)
                    {
                        SmtpClient client = new SmtpClient("smtp.gmail.com");
                        client.Port = 587;
                        client.EnableSsl = true;
                        client.Timeout = 10000;
                        client.DeliveryMethod = SmtpDeliveryMethod.Network;
                        client.UseDefaultCredentials = false;
                        client.Credentials = new NetworkCredential(From, SecurityKey.Text);
                        MailMessage msg = new MailMessage();
                        msg.To.Add(To);
                        msg.From = new MailAddress(From);
                        msg.Subject = Subject;
                        msg.Body = Body;
                        client.Send(msg);
                        MessageBox.Show("Message Sent!");
                        this.Close();
                    }
                }
                else {
                    MessageBox.Show("Incorrect Password");
                }
            }
            catch (Exception ex)
            {
                // Displaying any error if it occurs
                MessageBox.Show("An error occurred: " + ex);
            }
        }
        // Closing the password box when the "X" button is clicked
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Masking the password text
        private void SecurityKey_TextChanged(object sender, EventArgs e)
        {
            SecurityKey.PasswordChar = '*';
        }
    }
}
