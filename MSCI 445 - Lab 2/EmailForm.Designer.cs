namespace MSCI_445___Lab_2
{
    partial class EmailForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Send = new System.Windows.Forms.Button();
            this.BodyLabel = new System.Windows.Forms.Label();
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.FromLabel = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.Body = new System.Windows.Forms.RichTextBox();
            this.Subject = new System.Windows.Forms.TextBox();
            this.From = new System.Windows.Forms.TextBox();
            this.To = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Send);
            this.panel1.Controls.Add(this.BodyLabel);
            this.panel1.Controls.Add(this.SubjectLabel);
            this.panel1.Controls.Add(this.FromLabel);
            this.panel1.Controls.Add(this.ToLabel);
            this.panel1.Controls.Add(this.Body);
            this.panel1.Controls.Add(this.Subject);
            this.panel1.Controls.Add(this.From);
            this.panel1.Controls.Add(this.To);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 456);
            this.panel1.TabIndex = 0;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(414, 39);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(126, 48);
            this.Send.TabIndex = 8;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // BodyLabel
            // 
            this.BodyLabel.AutoSize = true;
            this.BodyLabel.Location = new System.Drawing.Point(25, 173);
            this.BodyLabel.Name = "BodyLabel";
            this.BodyLabel.Size = new System.Drawing.Size(44, 17);
            this.BodyLabel.TabIndex = 7;
            this.BodyLabel.Text = "Body:";
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.Location = new System.Drawing.Point(10, 118);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(59, 17);
            this.SubjectLabel.TabIndex = 6;
            this.SubjectLabel.Text = "Subject:";
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Location = new System.Drawing.Point(25, 70);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(44, 17);
            this.FromLabel.TabIndex = 5;
            this.FromLabel.Text = "From:";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(40, 23);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(29, 17);
            this.ToLabel.TabIndex = 4;
            this.ToLabel.Text = "To:";
            // 
            // Body
            // 
            this.Body.Location = new System.Drawing.Point(75, 173);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(490, 258);
            this.Body.TabIndex = 3;
            this.Body.Text = "";
            // 
            // Subject
            // 
            this.Subject.Location = new System.Drawing.Point(75, 118);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(490, 22);
            this.Subject.TabIndex = 2;
            // 
            // From
            // 
            this.From.Location = new System.Drawing.Point(75, 70);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(287, 22);
            this.From.TabIndex = 1;
            // 
            // To
            // 
            this.To.Location = new System.Drawing.Point(75, 23);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(287, 22);
            this.To.TabIndex = 0;
            // 
            // EmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 480);
            this.Controls.Add(this.panel1);
            this.Name = "EmailForm";
            this.Text = "Email Form";
            this.Load += new System.EventHandler(this.EmailForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.RichTextBox Body;
        private System.Windows.Forms.TextBox Subject;
        private System.Windows.Forms.TextBox From;
        private System.Windows.Forms.TextBox To;
        private System.Windows.Forms.Label SubjectLabel;
        private System.Windows.Forms.Label BodyLabel;
        private System.Windows.Forms.Button Send;
    }
}

