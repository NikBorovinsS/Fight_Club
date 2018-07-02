namespace Fight_Club
{
    partial class FighterForm
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
            this.HpBar = new System.Windows.Forms.ProgressBar();
            this.HpBox = new System.Windows.Forms.TextBox();
            this.buttonHead = new System.Windows.Forms.Button();
            this.buttonTorso = new System.Windows.Forms.Button();
            this.buttonLegs = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HpBar
            // 
            this.HpBar.Location = new System.Drawing.Point(51, 237);
            this.HpBar.Name = "HpBar";
            this.HpBar.Size = new System.Drawing.Size(176, 23);
            this.HpBar.TabIndex = 0;
            // 
            // HpBox
            // 
            this.HpBox.Enabled = false;
            this.HpBox.Location = new System.Drawing.Point(85, 267);
            this.HpBox.Name = "HpBox";
            this.HpBox.Size = new System.Drawing.Size(100, 20);
            this.HpBox.TabIndex = 1;
            // 
            // buttonHead
            // 
            this.buttonHead.Location = new System.Drawing.Point(51, 12);
            this.buttonHead.Name = "buttonHead";
            this.buttonHead.Size = new System.Drawing.Size(176, 69);
            this.buttonHead.TabIndex = 2;
            this.buttonHead.Text = "buttonHead";
            this.buttonHead.UseVisualStyleBackColor = true;
            this.buttonHead.Click += new System.EventHandler(this.buttonHead_Click);
            // 
            // buttonTorso
            // 
            this.buttonTorso.Location = new System.Drawing.Point(51, 87);
            this.buttonTorso.Name = "buttonTorso";
            this.buttonTorso.Size = new System.Drawing.Size(176, 69);
            this.buttonTorso.TabIndex = 3;
            this.buttonTorso.Text = "buttonTorso";
            this.buttonTorso.UseVisualStyleBackColor = true;
            this.buttonTorso.Click += new System.EventHandler(this.buttonTorso_Click);
            // 
            // buttonLegs
            // 
            this.buttonLegs.Location = new System.Drawing.Point(51, 162);
            this.buttonLegs.Name = "buttonLegs";
            this.buttonLegs.Size = new System.Drawing.Size(176, 69);
            this.buttonLegs.TabIndex = 4;
            this.buttonLegs.Text = "buttonLegs";
            this.buttonLegs.UseVisualStyleBackColor = true;
            this.buttonLegs.Click += new System.EventHandler(this.buttonLegs_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(85, 294);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "label1";
            // 
            // FighterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 313);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.buttonLegs);
            this.Controls.Add(this.buttonTorso);
            this.Controls.Add(this.buttonHead);
            this.Controls.Add(this.HpBox);
            this.Controls.Add(this.HpBar);
            this.Name = "FighterForm";
            this.Text = "FighterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar HpBar;
        private System.Windows.Forms.TextBox HpBox;
        private System.Windows.Forms.Button buttonHead;
        private System.Windows.Forms.Button buttonTorso;
        private System.Windows.Forms.Button buttonLegs;
        private System.Windows.Forms.Label NameLabel;
    }
}