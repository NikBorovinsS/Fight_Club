namespace Fight_Club
{
    partial class FightClubMainForm
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.LogsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(367, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(156, 58);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Fight!";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackgroundImage = global::Fight_Club.Properties.Resources.w512h5121377940132185095settingsstreamline;
            this.SettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SettingsButton.Location = new System.Drawing.Point(860, 12);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(34, 33);
            this.SettingsButton.TabIndex = 2;
            this.SettingsButton.UseVisualStyleBackColor = true;
            // 
            // LogsButton
            // 
            this.LogsButton.Location = new System.Drawing.Point(860, 51);
            this.LogsButton.Name = "LogsButton";
            this.LogsButton.Size = new System.Drawing.Size(34, 33);
            this.LogsButton.TabIndex = 3;
            this.LogsButton.Text = "Log";
            this.LogsButton.UseVisualStyleBackColor = true;
            // 
            // FightClubMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 418);
            this.Controls.Add(this.LogsButton);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.buttonStart);
            this.IsMdiContainer = true;
            this.Name = "FightClubMainForm";
            this.Text = "FightClubMainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button LogsButton;
    }
}