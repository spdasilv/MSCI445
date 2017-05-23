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
            this.Passcode = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Passcode
            // 
            this.Passcode.AutoSize = true;
            this.Passcode.Location = new System.Drawing.Point(12, 28);
            this.Passcode.Name = "Passcode";
            this.Passcode.Size = new System.Drawing.Size(192, 17);
            this.Passcode.TabIndex = 0;
            this.Passcode.Text = "Please Enter Your Password:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(489, 22);
            this.textBox1.TabIndex = 1;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(68, 114);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(117, 36);
            this.Submit.TabIndex = 2;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(323, 114);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(117, 36);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 184);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Passcode);
            this.Name = "Password";
            this.Text = "Please Enter Your Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Passcode;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button Cancel;
    }
}