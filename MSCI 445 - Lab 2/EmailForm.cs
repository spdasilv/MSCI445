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

        private void Send_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(To.Text) || !string.IsNullOrWhiteSpace(From.Text))
            {
                if (To.Text.Contains("@") && From.Text.Contains("@gmail.com"))
                {
                    Password pw = new Password(From.Text, To.Text, Subject.Text, Body.Text);
                    pw.Show();
                }
                else
                {
                    MessageBox.Show("Please use valid email addresses");
                }
            }
            else
            {
                MessageBox.Show("Please make sure the 'To' and 'From' field are filled");
            }
        }
    }
}
