
namespace Kukuha
{
    partial class Mail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mail));
            this.MessageText = new System.Windows.Forms.RichTextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.SubjectText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MessageText
            // 
            this.MessageText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MessageText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MessageText.ForeColor = System.Drawing.Color.White;
            this.MessageText.Location = new System.Drawing.Point(13, 41);
            this.MessageText.Name = "MessageText";
            this.MessageText.Size = new System.Drawing.Size(775, 361);
            this.MessageText.TabIndex = 0;
            this.MessageText.Text = "";
            // 
            // SendButton
            // 
            this.SendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SendButton.Location = new System.Drawing.Point(681, 408);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(106, 30);
            this.SendButton.TabIndex = 1;
            this.SendButton.Text = "Отправить";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // SubjectText
            // 
            this.SubjectText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SubjectText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SubjectText.ForeColor = System.Drawing.Color.White;
            this.SubjectText.Location = new System.Drawing.Point(13, 12);
            this.SubjectText.Name = "SubjectText";
            this.SubjectText.Size = new System.Drawing.Size(775, 23);
            this.SubjectText.TabIndex = 3;
            this.SubjectText.Text = "Тема письма";
            // 
            // Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SubjectText);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.MessageText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mail";
            this.Text = "Kukuha Mail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox MessageText;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox SubjectText;
    }
}