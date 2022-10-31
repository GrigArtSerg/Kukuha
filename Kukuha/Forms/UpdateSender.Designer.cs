
namespace Kukuha
{
    partial class Updation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Updation));
            this.label1 = new System.Windows.Forms.Label();
            this.OpenUpdate = new System.Windows.Forms.Button();
            this.CloseUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Обнаружена новая версия";
            // 
            // OpenUpdate
            // 
            this.OpenUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.OpenUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OpenUpdate.Location = new System.Drawing.Point(12, 36);
            this.OpenUpdate.Name = "OpenUpdate";
            this.OpenUpdate.Size = new System.Drawing.Size(247, 39);
            this.OpenUpdate.TabIndex = 1;
            this.OpenUpdate.Text = "Скачать обновление";
            this.OpenUpdate.UseVisualStyleBackColor = true;
            this.OpenUpdate.Click += new System.EventHandler(this.OpenUpdate_Click);
            // 
            // CloseUpdate
            // 
            this.CloseUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CloseUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CloseUpdate.Location = new System.Drawing.Point(12, 81);
            this.CloseUpdate.Name = "CloseUpdate";
            this.CloseUpdate.Size = new System.Drawing.Size(247, 39);
            this.CloseUpdate.TabIndex = 2;
            this.CloseUpdate.Text = "Пропустить обновление";
            this.CloseUpdate.UseVisualStyleBackColor = true;
            this.CloseUpdate.Click += new System.EventHandler(this.CloseUpdate_Click);
            // 
            // Updation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(271, 137);
            this.Controls.Add(this.CloseUpdate);
            this.Controls.Add(this.OpenUpdate);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Updation";
            this.Text = "Kukuha Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OpenUpdate;
        private System.Windows.Forms.Button CloseUpdate;
    }
}