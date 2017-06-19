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
    public partial class EmailForm : Form
    {
        public EmailForm()
        {
            InitializeComponent();
        }

        private void EmailForm_Load(object sender, EventArgs e)
        {

        }

        // Defines the action of the send button; once clicked
        private void Send_Click(object sender, EventArgs e)
        {
            // Checks if the 'To' and 'From' fields are filled out or not
            if (!string.IsNullOrWhiteSpace(To.Text) || !string.IsNullOrWhiteSpace(From.Text))
            {
                // Checks if the 'To' and 'From' contain valid email addresses as defined in the rubric
                if (To.Text.Contains("@") && From.Text.Contains("@gmail.com"))
                {
                    // Checks if the 'Subject' and 'Body' contain fields are filled out or not
                    if (!string.IsNullOrWhiteSpace(Subject.Text) && !string.IsNullOrWhiteSpace(Body.Text))
                    {
                        Password pw = new Password(From.Text, To.Text, Subject.Text, Body.Text);
                        // Displays the password input form
                        pw.Show();
                    }
                    else
                    {
                        // Prompts the user to fill out the 'Subject' and 'Body' fields
                        MessageBox.Show("Please make sure 'Subject' and 'Body' fields are filled.");
                    }
                }
                else
                {
                    //Prompts the user to use valid email addresses
                    MessageBox.Show("Please use valid email addresses");
                }
            }
            else
            {
                // Prompts the user to fill out the 'To' and 'From fields
                MessageBox.Show("Please make sure the 'To' and 'From' fields are filled.");
            }
        }
    }
}
