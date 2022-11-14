
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
            this.ReportOrSuggestion = new System.Windows.Forms.Button();
            this.IsUpdateCheck = new System.Windows.Forms.CheckBox();
            this.VoiceChange = new System.Windows.Forms.ComboBox();
            this.IsHideOnLoad = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // IsAutoRun
            // 
            this.IsAutoRun.AutoSize = true;
            this.IsAutoRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.IsAutoRun.ForeColor = System.Drawing.Color.White;
            this.IsAutoRun.Location = new System.Drawing.Point(13, 13);
            this.IsAutoRun.Name = "IsAutoRun";
            this.IsAutoRun.Size = new System.Drawing.Size(168, 30);
            this.IsAutoRun.TabIndex = 0;
            this.IsAutoRun.Text = "Автозагрузка";
            this.IsAutoRun.UseVisualStyleBackColor = true;
            this.IsAutoRun.CheckedChanged += new System.EventHandler(this.IsAutoRun_CheckedChanged);
            // 
            // AddPhrase
            // 
            this.AddPhrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.AddPhrase.Location = new System.Drawing.Point(12, 226);
            this.AddPhrase.Name = "AddPhrase";
            this.AddPhrase.Size = new System.Drawing.Size(269, 39);
            this.AddPhrase.TabIndex = 5;
            this.AddPhrase.Text = "Добавить фразу";
            this.AddPhrase.UseVisualStyleBackColor = true;
            this.AddPhrase.Click += new System.EventHandler(this.AddPhrase_Click);
            // 
            // ReportOrSuggestion
            // 
            this.ReportOrSuggestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ReportOrSuggestion.Location = new System.Drawing.Point(12, 271);
            this.ReportOrSuggestion.Name = "ReportOrSuggestion";
            this.ReportOrSuggestion.Size = new System.Drawing.Size(269, 69);
            this.ReportOrSuggestion.TabIndex = 6;
            this.ReportOrSuggestion.Text = "Сообщить о проблеме Предложить улучшения";
            this.ReportOrSuggestion.UseVisualStyleBackColor = true;
            this.ReportOrSuggestion.Click += new System.EventHandler(this.ReportOrSuggestion_Click);
            // 
            // IsUpdateCheck
            // 
            this.IsUpdateCheck.AutoSize = true;
            this.IsUpdateCheck.Checked = true;
            this.IsUpdateCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IsUpdateCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.IsUpdateCheck.ForeColor = System.Drawing.Color.White;
            this.IsUpdateCheck.Location = new System.Drawing.Point(13, 52);
            this.IsUpdateCheck.Name = "IsUpdateCheck";
            this.IsUpdateCheck.Size = new System.Drawing.Size(269, 30);
            this.IsUpdateCheck.TabIndex = 7;
            this.IsUpdateCheck.Text = "Проверять обновления";
            this.IsUpdateCheck.UseVisualStyleBackColor = true;
            this.IsUpdateCheck.CheckedChanged += new System.EventHandler(this.IsUpdateCheck_CheckedChanged);
            // 
            // VoiceChange
            // 
            this.VoiceChange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VoiceChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.VoiceChange.FormattingEnabled = true;
            this.VoiceChange.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.VoiceChange.Items.AddRange(new object[] {
            "Оригинальная озвучка (Гугл-дядя)",
            "Голос Артаса"});
            this.VoiceChange.Location = new System.Drawing.Point(12, 187);
            this.VoiceChange.Name = "VoiceChange";
            this.VoiceChange.Size = new System.Drawing.Size(269, 33);
            this.VoiceChange.TabIndex = 8;
            this.VoiceChange.SelectedIndexChanged += new System.EventHandler(this.VoiceChange_SelectedIndexChanged);
            // 
            // IsHideOnLoad
            // 
            this.IsHideOnLoad.AutoSize = true;
            this.IsHideOnLoad.Checked = true;
            this.IsHideOnLoad.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IsHideOnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.IsHideOnLoad.ForeColor = System.Drawing.Color.White;
            this.IsHideOnLoad.Location = new System.Drawing.Point(12, 88);
            this.IsHideOnLoad.Name = "IsHideOnLoad";
            this.IsHideOnLoad.Size = new System.Drawing.Size(260, 30);
            this.IsHideOnLoad.TabIndex = 7;
            this.IsHideOnLoad.Text = "Скрывать при запуске";
            this.IsHideOnLoad.UseVisualStyleBackColor = true;
            this.IsHideOnLoad.CheckedChanged += new System.EventHandler(this.IsHideOnLoad_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(295, 357);
            this.Controls.Add(this.VoiceChange);
            this.Controls.Add(this.IsHideOnLoad);
            this.Controls.Add(this.IsUpdateCheck);
            this.Controls.Add(this.ReportOrSuggestion);
            this.Controls.Add(this.AddPhrase);
            this.Controls.Add(this.IsAutoRun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Settings";
            this.Text = "Kukuha Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox IsAutoRun;
        private System.Windows.Forms.Button AddPhrase;
        private System.Windows.Forms.Button ReportOrSuggestion;
        private System.Windows.Forms.CheckBox IsUpdateCheck;
        private System.Windows.Forms.ComboBox VoiceChange;
        private System.Windows.Forms.CheckBox IsHideOnLoad;
    }
}