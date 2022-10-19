
namespace Kukuha
{
    partial class FormRepSug
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
            this.MessageText = new System.Windows.Forms.RichTextBox();
            this.Send = new System.Windows.Forms.Button();
            this.Ans = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MessageText
            // 
            this.MessageText.Location = new System.Drawing.Point(13, 12);
            this.MessageText.Name = "MessageText";
            this.MessageText.Size = new System.Drawing.Size(775, 388);
            this.MessageText.TabIndex = 1;
            this.MessageText.Text = "";
            // 
            // Send
            // 
            this.Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Send.Location = new System.Drawing.Point(13, 406);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(136, 32);
            this.Send.TabIndex = 2;
            this.Send.Text = "Отправить";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Ans
            // 
            this.Ans.AutoSize = true;
            this.Ans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Ans.Location = new System.Drawing.Point(155, 412);
            this.Ans.Name = "Ans";
            this.Ans.Size = new System.Drawing.Size(0, 20);
            this.Ans.TabIndex = 3;
            // 
            // FormRepSug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ans);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.MessageText);
            this.Name = "FormRepSug";
            this.Text = "Kukuha FormRepSug";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox MessageText;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Label Ans;
    }
}