namespace Fight_Club
{
    partial class SettingsForm
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
            this.DurationRadioShort = new System.Windows.Forms.RadioButton();
            this.DurationRadioNormal = new System.Windows.Forms.RadioButton();
            this.DurationRadioLong = new System.Windows.Forms.RadioButton();
            this.DurationGroupBox = new System.Windows.Forms.GroupBox();
            this.NamesGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SetSecondPlayerName = new System.Windows.Forms.TextBox();
            this.SetFirstPlayerName = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.DurationGroupBox.SuspendLayout();
            this.NamesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DurationRadioShort
            // 
            this.DurationRadioShort.AutoSize = true;
            this.DurationRadioShort.Location = new System.Drawing.Point(6, 21);
            this.DurationRadioShort.Name = "DurationRadioShort";
            this.DurationRadioShort.Size = new System.Drawing.Size(89, 17);
            this.DurationRadioShort.TabIndex = 0;
            this.DurationRadioShort.TabStop = true;
            this.DurationRadioShort.Text = "Short (50 HP)";
            this.DurationRadioShort.UseVisualStyleBackColor = true;
            this.DurationRadioShort.CheckedChanged += new System.EventHandler(this.DurationRadioShort_CheckedChanged);
            // 
            // DurationRadioNormal
            // 
            this.DurationRadioNormal.AutoSize = true;
            this.DurationRadioNormal.Location = new System.Drawing.Point(6, 44);
            this.DurationRadioNormal.Name = "DurationRadioNormal";
            this.DurationRadioNormal.Size = new System.Drawing.Size(103, 17);
            this.DurationRadioNormal.TabIndex = 1;
            this.DurationRadioNormal.TabStop = true;
            this.DurationRadioNormal.Text = "Normal (100 HP)";
            this.DurationRadioNormal.UseVisualStyleBackColor = true;
            this.DurationRadioNormal.CheckedChanged += new System.EventHandler(this.DurationRadioNormal_CheckedChanged);
            // 
            // DurationRadioLong
            // 
            this.DurationRadioLong.AutoSize = true;
            this.DurationRadioLong.Location = new System.Drawing.Point(6, 67);
            this.DurationRadioLong.Name = "DurationRadioLong";
            this.DurationRadioLong.Size = new System.Drawing.Size(94, 17);
            this.DurationRadioLong.TabIndex = 2;
            this.DurationRadioLong.TabStop = true;
            this.DurationRadioLong.Text = "Long (200 HP)";
            this.DurationRadioLong.UseVisualStyleBackColor = true;
            this.DurationRadioLong.CheckedChanged += new System.EventHandler(this.DurationRadioLong_CheckedChanged);
            // 
            // DurationGroupBox
            // 
            this.DurationGroupBox.Controls.Add(this.DurationRadioNormal);
            this.DurationGroupBox.Controls.Add(this.DurationRadioLong);
            this.DurationGroupBox.Controls.Add(this.DurationRadioShort);
            this.DurationGroupBox.Location = new System.Drawing.Point(12, 12);
            this.DurationGroupBox.Name = "DurationGroupBox";
            this.DurationGroupBox.Size = new System.Drawing.Size(111, 100);
            this.DurationGroupBox.TabIndex = 3;
            this.DurationGroupBox.TabStop = false;
            this.DurationGroupBox.Text = "Fight Duration";
            // 
            // NamesGroupBox
            // 
            this.NamesGroupBox.Controls.Add(this.label2);
            this.NamesGroupBox.Controls.Add(this.label1);
            this.NamesGroupBox.Controls.Add(this.SetSecondPlayerName);
            this.NamesGroupBox.Controls.Add(this.SetFirstPlayerName);
            this.NamesGroupBox.Location = new System.Drawing.Point(129, 12);
            this.NamesGroupBox.Name = "NamesGroupBox";
            this.NamesGroupBox.Size = new System.Drawing.Size(237, 125);
            this.NamesGroupBox.TabIndex = 4;
            this.NamesGroupBox.TabStop = false;
            this.NamesGroupBox.Text = "Player names";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "First player name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Second player name";
            // 
            // SetSecondPlayerName
            // 
            this.SetSecondPlayerName.Location = new System.Drawing.Point(7, 93);
            this.SetSecondPlayerName.Name = "SetSecondPlayerName";
            this.SetSecondPlayerName.Size = new System.Drawing.Size(224, 20);
            this.SetSecondPlayerName.TabIndex = 1;
            // 
            // SetFirstPlayerName
            // 
            this.SetFirstPlayerName.Location = new System.Drawing.Point(7, 44);
            this.SetFirstPlayerName.Name = "SetFirstPlayerName";
            this.SetFirstPlayerName.Size = new System.Drawing.Size(224, 20);
            this.SetFirstPlayerName.TabIndex = 0;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(108, 166);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(86, 44);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(238, 166);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(86, 44);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 239);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.NamesGroupBox);
            this.Controls.Add(this.DurationGroupBox);
            this.Name = "SettingsForm";
            this.Text = "Game Settings";
            this.DurationGroupBox.ResumeLayout(false);
            this.DurationGroupBox.PerformLayout();
            this.NamesGroupBox.ResumeLayout(false);
            this.NamesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton DurationRadioShort;
        private System.Windows.Forms.RadioButton DurationRadioNormal;
        private System.Windows.Forms.RadioButton DurationRadioLong;
        private System.Windows.Forms.GroupBox DurationGroupBox;
        private System.Windows.Forms.GroupBox NamesGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SetSecondPlayerName;
        private System.Windows.Forms.TextBox SetFirstPlayerName;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}