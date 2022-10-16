
namespace Kukuha
{
    partial class Settings
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
            this.IsAutoRun = new System.Windows.Forms.CheckBox();
            this.AddPhrase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IsAutoRun
            // 
            this.IsAutoRun.AutoSize = true;
            this.IsAutoRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.IsAutoRun.ForeColor = System.Drawing.Color.White;
            this.IsAutoRun.Location = new System.Drawing.Point(13, 13);
            this.IsAutoRun.Name = "IsAutoRun";
            this.IsAutoRun.Size = new System.Drawing.Size(114, 33);
            this.IsAutoRun.TabIndex = 0;
            this.IsAutoRun.Text = "Autorun";
            this.IsAutoRun.UseVisualStyleBackColor = true;
            this.IsAutoRun.CheckedChanged += new System.EventHandler(this.IsAutoRun_CheckedChanged);
            // 
            // AddPhrase
            // 
            this.AddPhrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddPhrase.Location = new System.Drawing.Point(12, 52);
            this.AddPhrase.Name = "AddPhrase";
            this.AddPhrase.Size = new System.Drawing.Size(218, 39);
            this.AddPhrase.TabIndex = 5;
            this.AddPhrase.Text = "Add Phrase";
            this.AddPhrase.UseVisualStyleBackColor = true;
            this.AddPhrase.Click += new System.EventHandler(this.AddPhrase_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(244, 221);
            this.Controls.Add(this.AddPhrase);
            this.Controls.Add(this.IsAutoRun);
            this.Name = "Settings";
            this.Text = "Kukuha Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox IsAutoRun;
        private System.Windows.Forms.Button AddPhrase;
    }
}