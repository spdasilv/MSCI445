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
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 370);
            this.panel1.TabIndex = 0;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(310, 32);
            this.Send.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(94, 39);
            this.Send.TabIndex = 8;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // BodyLabel
            // 
            this.BodyLabel.AutoSize = true;
            this.BodyLabel.Location = new System.Drawing.Point(19, 141);
            this.BodyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BodyLabel.Name = "BodyLabel";
            this.BodyLabel.Size = new System.Drawing.Size(34, 13);
            this.BodyLabel.TabIndex = 7;
            this.BodyLabel.Text = "Body:";
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.Location = new System.Drawing.Point(8, 96);
            this.SubjectLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(46, 13);
            this.SubjectLabel.TabIndex = 6;
            this.SubjectLabel.Text = "Subject:";
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Location = new System.Drawing.Point(19, 57);
            this.FromLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(33, 13);
            this.FromLabel.TabIndex = 5;
            this.FromLabel.Text = "From:";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(30, 19);
            this.ToLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(23, 13);
            this.ToLabel.TabIndex = 4;
            this.ToLabel.Text = "To:";
            // 
            // Body
            // 
            this.Body.Location = new System.Drawing.Point(56, 141);
            this.Body.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(368, 210);
            this.Body.TabIndex = 3;
            this.Body.Text = "";
            // 
            // Subject
            // 
            this.Subject.Location = new System.Drawing.Point(56, 96);
            this.Subject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(368, 20);
            this.Subject.TabIndex = 2;
            this.Subject.TextChanged += new System.EventHandler(this.Subject_TextChanged);
            // 
            // From
            // 
            this.From.Location = new System.Drawing.Point(56, 57);
            this.From.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(216, 20);
            this.From.TabIndex = 1;
            // 
            // To
            // 
            this.To.Location = new System.Drawing.Point(56, 19);
            this.To.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(216, 20);
            this.To.TabIndex = 0;
            this.To.TextChanged += new System.EventHandler(this.To_TextChanged);
            // 
            // EmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 390);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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

