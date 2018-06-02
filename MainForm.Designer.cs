namespace Fight_Club
{
    partial class FightClubMainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.GameLogs = new System.Windows.Forms.ListBox();
            this.FightButton = new System.Windows.Forms.Button();
            this.Player2HPBar = new System.Windows.Forms.ProgressBar();
            this.Player1HPBar = new System.Windows.Forms.ProgressBar();
            this.Player1NameLabel = new System.Windows.Forms.Label();
            this.Player2NameLabel = new System.Windows.Forms.Label();
            this.Player1HPBox = new System.Windows.Forms.TextBox();
            this.Player2HPBox = new System.Windows.Forms.TextBox();
            this.LegsOpp = new System.Windows.Forms.Button();
            this.TorsoOpp = new System.Windows.Forms.Button();
            this.HeadOpp = new System.Windows.Forms.Button();
            this.ButtonSettings = new System.Windows.Forms.Button();
            this.ButtonLegs = new System.Windows.Forms.Button();
            this.ButtonTorso = new System.Windows.Forms.Button();
            this.ButtonHead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GameLogs
            // 
            this.GameLogs.FormattingEnabled = true;
            this.GameLogs.Location = new System.Drawing.Point(12, 12);
            this.GameLogs.Name = "GameLogs";
            this.GameLogs.Size = new System.Drawing.Size(247, 381);
            this.GameLogs.TabIndex = 0;
            // 
            // FightButton
            // 
            this.FightButton.Location = new System.Drawing.Point(423, 12);
            this.FightButton.Name = "FightButton";
            this.FightButton.Size = new System.Drawing.Size(102, 43);
            this.FightButton.TabIndex = 1;
            this.FightButton.Text = "Fight!";
            this.FightButton.UseVisualStyleBackColor = true;
            this.FightButton.Click += new System.EventHandler(this.Start_Fight);
            // 
            // Player2HPBar
            // 
            this.Player2HPBar.Location = new System.Drawing.Point(511, 370);
            this.Player2HPBar.Name = "Player2HPBar";
            this.Player2HPBar.Size = new System.Drawing.Size(167, 23);
            this.Player2HPBar.TabIndex = 2;
            // 
            // Player1HPBar
            // 
            this.Player1HPBar.Location = new System.Drawing.Point(280, 370);
            this.Player1HPBar.Name = "Player1HPBar";
            this.Player1HPBar.Size = new System.Drawing.Size(167, 23);
            this.Player1HPBar.TabIndex = 3;
            // 
            // Player1NameLabel
            // 
            this.Player1NameLabel.AutoSize = true;
            this.Player1NameLabel.Location = new System.Drawing.Point(342, 354);
            this.Player1NameLabel.Name = "Player1NameLabel";
            this.Player1NameLabel.Size = new System.Drawing.Size(0, 13);
            this.Player1NameLabel.TabIndex = 4;
            // 
            // Player2NameLabel
            // 
            this.Player2NameLabel.AutoSize = true;
            this.Player2NameLabel.Location = new System.Drawing.Point(579, 354);
            this.Player2NameLabel.Name = "Player2NameLabel";
            this.Player2NameLabel.Size = new System.Drawing.Size(0, 13);
            this.Player2NameLabel.TabIndex = 5;
            // 
            // Player1HPBox
            // 
            this.Player1HPBox.Location = new System.Drawing.Point(280, 400);
            this.Player1HPBox.Name = "Player1HPBox";
            this.Player1HPBox.ReadOnly = true;
            this.Player1HPBox.Size = new System.Drawing.Size(45, 20);
            this.Player1HPBox.TabIndex = 6;
            this.Player1HPBox.TextChanged += new System.EventHandler(this.Player1HPBox_TextChanged);
            // 
            // Player2HPBox
            // 
            this.Player2HPBox.Location = new System.Drawing.Point(511, 400);
            this.Player2HPBox.Name = "Player2HPBox";
            this.Player2HPBox.ReadOnly = true;
            this.Player2HPBox.Size = new System.Drawing.Size(45, 20);
            this.Player2HPBox.TabIndex = 7;
            this.Player2HPBox.TextChanged += new System.EventHandler(this.Player2HPBox_TextChanged);
            // 
            // LegsOpp
            // 
            this.LegsOpp.BackgroundImage = global::Fight_Club.Properties.Resources.narrator_legs;
            this.LegsOpp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LegsOpp.Enabled = false;
            this.LegsOpp.Location = new System.Drawing.Point(511, 201);
            this.LegsOpp.Name = "LegsOpp";
            this.LegsOpp.Size = new System.Drawing.Size(167, 150);
            this.LegsOpp.TabIndex = 14;
            this.LegsOpp.UseVisualStyleBackColor = true;
            this.LegsOpp.Visible = false;
            // 
            // TorsoOpp
            // 
            this.TorsoOpp.BackgroundImage = global::Fight_Club.Properties.Resources.Narrator_torso;
            this.TorsoOpp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TorsoOpp.Enabled = false;
            this.TorsoOpp.Location = new System.Drawing.Point(511, 124);
            this.TorsoOpp.Name = "TorsoOpp";
            this.TorsoOpp.Size = new System.Drawing.Size(167, 83);
            this.TorsoOpp.TabIndex = 13;
            this.TorsoOpp.UseVisualStyleBackColor = true;
            this.TorsoOpp.Visible = false;
            // 
            // HeadOpp
            // 
            this.HeadOpp.BackgroundImage = global::Fight_Club.Properties.Resources.narrator_head;
            this.HeadOpp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HeadOpp.Enabled = false;
            this.HeadOpp.Location = new System.Drawing.Point(511, 61);
            this.HeadOpp.Name = "HeadOpp";
            this.HeadOpp.Size = new System.Drawing.Size(167, 70);
            this.HeadOpp.TabIndex = 12;
            this.HeadOpp.UseVisualStyleBackColor = true;
            this.HeadOpp.Visible = false;
            // 
            // ButtonSettings
            // 
            this.ButtonSettings.BackgroundImage = global::Fight_Club.Properties.Resources.w512h5121377940132185095settingsstreamline;
            this.ButtonSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonSettings.Location = new System.Drawing.Point(782, 12);
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.Size = new System.Drawing.Size(25, 25);
            this.ButtonSettings.TabIndex = 11;
            this.ButtonSettings.UseVisualStyleBackColor = true;
            this.ButtonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // ButtonLegs
            // 
            this.ButtonLegs.BackgroundImage = global::Fight_Club.Properties.Resources.tyler_legs;
            this.ButtonLegs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonLegs.Location = new System.Drawing.Point(280, 201);
            this.ButtonLegs.Name = "ButtonLegs";
            this.ButtonLegs.Size = new System.Drawing.Size(167, 150);
            this.ButtonLegs.TabIndex = 10;
            this.ButtonLegs.UseVisualStyleBackColor = true;
            this.ButtonLegs.Visible = false;
            this.ButtonLegs.Click += new System.EventHandler(this.ButtonLegs_Click);
            // 
            // ButtonTorso
            // 
            this.ButtonTorso.BackgroundImage = global::Fight_Club.Properties.Resources.tyler_torso;
            this.ButtonTorso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonTorso.Location = new System.Drawing.Point(280, 124);
            this.ButtonTorso.Name = "ButtonTorso";
            this.ButtonTorso.Size = new System.Drawing.Size(167, 83);
            this.ButtonTorso.TabIndex = 9;
            this.ButtonTorso.UseVisualStyleBackColor = true;
            this.ButtonTorso.Visible = false;
            this.ButtonTorso.Click += new System.EventHandler(this.ButtonTorso_Click);
            // 
            // ButtonHead
            // 
            this.ButtonHead.BackgroundImage = global::Fight_Club.Properties.Resources.tyler_head;
            this.ButtonHead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonHead.Location = new System.Drawing.Point(280, 61);
            this.ButtonHead.Name = "ButtonHead";
            this.ButtonHead.Size = new System.Drawing.Size(167, 70);
            this.ButtonHead.TabIndex = 8;
            this.ButtonHead.UseVisualStyleBackColor = true;
            this.ButtonHead.Visible = false;
            this.ButtonHead.Click += new System.EventHandler(this.ButtonHead_Click);
            // 
            // FightClubMainForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(819, 464);
            this.Controls.Add(this.LegsOpp);
            this.Controls.Add(this.TorsoOpp);
            this.Controls.Add(this.HeadOpp);
            this.Controls.Add(this.ButtonSettings);
            this.Controls.Add(this.ButtonLegs);
            this.Controls.Add(this.ButtonTorso);
            this.Controls.Add(this.ButtonHead);
            this.Controls.Add(this.Player2HPBox);
            this.Controls.Add(this.Player1HPBox);
            this.Controls.Add(this.Player2NameLabel);
            this.Controls.Add(this.Player1NameLabel);
            this.Controls.Add(this.Player1HPBar);
            this.Controls.Add(this.Player2HPBar);
            this.Controls.Add(this.FightButton);
            this.Controls.Add(this.GameLogs);
            this.Name = "FightClubMainForm";
            this.Text = "Fight Club";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox GameLogs;
        private System.Windows.Forms.Button FightButton;
        private System.Windows.Forms.ProgressBar Player2HPBar;
        private System.Windows.Forms.ProgressBar Player1HPBar;
        private System.Windows.Forms.Label Player1NameLabel;
        private System.Windows.Forms.Label Player2NameLabel;
        private System.Windows.Forms.TextBox Player1HPBox;
        private System.Windows.Forms.TextBox Player2HPBox;
        private System.Windows.Forms.Button ButtonHead;
        private System.Windows.Forms.Button ButtonTorso;
        private System.Windows.Forms.Button ButtonLegs;
        private System.Windows.Forms.Button ButtonSettings;
        private System.Windows.Forms.Button HeadOpp;
        private System.Windows.Forms.Button TorsoOpp;
        private System.Windows.Forms.Button LegsOpp;
    }
}

