
namespace Kukuha
{
    partial class Test
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
            this.testRandomBtn = new System.Windows.Forms.Button();
            this.testTimeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testRandomBtn
            // 
            this.testRandomBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.testRandomBtn.Location = new System.Drawing.Point(12, 57);
            this.testRandomBtn.Name = "testRandomBtn";
            this.testRandomBtn.Size = new System.Drawing.Size(218, 39);
            this.testRandomBtn.TabIndex = 5;
            this.testRandomBtn.Text = "Play random ►";
            this.testRandomBtn.UseVisualStyleBackColor = true;
            this.testRandomBtn.Click += new System.EventHandler(this.testRandomBtn_Click);
            // 
            // testTimeBtn
            // 
            this.testTimeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.testTimeBtn.Location = new System.Drawing.Point(12, 12);
            this.testTimeBtn.Name = "testTimeBtn";
            this.testTimeBtn.Size = new System.Drawing.Size(218, 39);
            this.testTimeBtn.TabIndex = 4;
            this.testTimeBtn.Text = "Play time ►";
            this.testTimeBtn.UseVisualStyleBackColor = true;
            this.testTimeBtn.Click += new System.EventHandler(this.testTimeBtn_Click);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(244, 221);
            this.Controls.Add(this.testRandomBtn);
            this.Controls.Add(this.testTimeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Test";
            this.Text = "Kukuha Test";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button testRandomBtn;
        private System.Windows.Forms.Button testTimeBtn;
    }
}