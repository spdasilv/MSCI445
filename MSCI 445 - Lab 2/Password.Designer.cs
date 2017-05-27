namespace MSCI_445___Lab_2
{
    partial class Password
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
            this.EnterPassword = new System.Windows.Forms.Label();
            this.SecurityKey = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnterPassword
            // 
            this.EnterPassword.AutoSize = true;
            this.EnterPassword.Location = new System.Drawing.Point(9, 23);
            this.EnterPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnterPassword.Name = "EnterPassword";
            this.EnterPassword.Size = new System.Drawing.Size(144, 13);
            this.EnterPassword.TabIndex = 0;
            this.EnterPassword.Text = "Please Enter Your Password:";
            // 
            // SecurityKey
            // 
            this.SecurityKey.Location = new System.Drawing.Point(11, 39);
            this.SecurityKey.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SecurityKey.Name = "SecurityKey";
            this.SecurityKey.Size = new System.Drawing.Size(368, 20);
            this.SecurityKey.TabIndex = 1;
            this.SecurityKey.TextChanged += new System.EventHandler(this.SecurityKey_TextChanged);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(51, 93);
            this.Submit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(88, 29);
            this.Submit.TabIndex = 2;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(242, 93);
            this.Cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(88, 29);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 150);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.SecurityKey);
            this.Controls.Add(this.EnterPassword);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Password";
            this.Text = "Please Enter Your Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnterPassword;
        private System.Windows.Forms.TextBox SecurityKey;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button Cancel;
    }
}