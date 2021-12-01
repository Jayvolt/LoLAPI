
namespace LoLAPIForm
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.enterSummonerNameLabel = new System.Windows.Forms.Label();
            this.enterSummonerNameTextBox = new System.Windows.Forms.TextBox();
            this.enterAPIKeyLabel = new System.Windows.Forms.Label();
            this.apiKeyTextBox = new System.Windows.Forms.TextBox();
            this.summonerInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.summonerLevelTextBox = new System.Windows.Forms.TextBox();
            this.summonerNameTextBox = new System.Windows.Forms.TextBox();
            this.summonerLevelLabel = new System.Windows.Forms.Label();
            this.summonerNameLabel = new System.Windows.Forms.Label();
            this.launchButton = new System.Windows.Forms.Button();
            this.summonerInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // enterSummonerNameLabel
            // 
            this.enterSummonerNameLabel.AutoSize = true;
            this.enterSummonerNameLabel.Location = new System.Drawing.Point(13, 13);
            this.enterSummonerNameLabel.Name = "enterSummonerNameLabel";
            this.enterSummonerNameLabel.Size = new System.Drawing.Size(142, 15);
            this.enterSummonerNameLabel.TabIndex = 0;
            this.enterSummonerNameLabel.Text = "Enter Summoner\'s Name:";
            // 
            // enterSummonerNameTextBox
            // 
            this.enterSummonerNameTextBox.Location = new System.Drawing.Point(13, 31);
            this.enterSummonerNameTextBox.Name = "enterSummonerNameTextBox";
            this.enterSummonerNameTextBox.Size = new System.Drawing.Size(181, 23);
            this.enterSummonerNameTextBox.TabIndex = 1;
            this.enterSummonerNameTextBox.TextChanged += new System.EventHandler(this.enterSummonerNameTextBox_TextChanged);
            // 
            // enterAPIKeyLabel
            // 
            this.enterAPIKeyLabel.AutoSize = true;
            this.enterAPIKeyLabel.Location = new System.Drawing.Point(246, 13);
            this.enterAPIKeyLabel.Name = "enterAPIKeyLabel";
            this.enterAPIKeyLabel.Size = new System.Drawing.Size(80, 15);
            this.enterAPIKeyLabel.TabIndex = 4;
            this.enterAPIKeyLabel.Text = "Enter API Key:";
            // 
            // apiKeyTextBox
            // 
            this.apiKeyTextBox.Location = new System.Drawing.Point(246, 31);
            this.apiKeyTextBox.Name = "apiKeyTextBox";
            this.apiKeyTextBox.Size = new System.Drawing.Size(541, 23);
            this.apiKeyTextBox.TabIndex = 5;
            this.apiKeyTextBox.TextChanged += new System.EventHandler(this.apiKeyTextBox_TextChanged);
            // 
            // summonerInfoGroupBox
            // 
            this.summonerInfoGroupBox.Controls.Add(this.summonerLevelTextBox);
            this.summonerInfoGroupBox.Controls.Add(this.summonerNameTextBox);
            this.summonerInfoGroupBox.Controls.Add(this.summonerLevelLabel);
            this.summonerInfoGroupBox.Controls.Add(this.summonerNameLabel);
            this.summonerInfoGroupBox.Location = new System.Drawing.Point(12, 84);
            this.summonerInfoGroupBox.Name = "summonerInfoGroupBox";
            this.summonerInfoGroupBox.Size = new System.Drawing.Size(775, 324);
            this.summonerInfoGroupBox.TabIndex = 6;
            this.summonerInfoGroupBox.TabStop = false;
            this.summonerInfoGroupBox.Text = "Summoner Information";
            // 
            // summonerLevelTextBox
            // 
            this.summonerLevelTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.summonerLevelTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.summonerLevelTextBox.Location = new System.Drawing.Point(234, 38);
            this.summonerLevelTextBox.Name = "summonerLevelTextBox";
            this.summonerLevelTextBox.ReadOnly = true;
            this.summonerLevelTextBox.Size = new System.Drawing.Size(175, 23);
            this.summonerLevelTextBox.TabIndex = 7;
            // 
            // summonerNameTextBox
            // 
            this.summonerNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.summonerNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.summonerNameTextBox.Location = new System.Drawing.Point(7, 38);
            this.summonerNameTextBox.Name = "summonerNameTextBox";
            this.summonerNameTextBox.ReadOnly = true;
            this.summonerNameTextBox.Size = new System.Drawing.Size(175, 23);
            this.summonerNameTextBox.TabIndex = 6;
            // 
            // summonerLevelLabel
            // 
            this.summonerLevelLabel.AutoSize = true;
            this.summonerLevelLabel.Location = new System.Drawing.Point(234, 19);
            this.summonerLevelLabel.Name = "summonerLevelLabel";
            this.summonerLevelLabel.Size = new System.Drawing.Size(107, 15);
            this.summonerLevelLabel.TabIndex = 5;
            this.summonerLevelLabel.Text = "Summoner\'s Level:";
            // 
            // summonerNameLabel
            // 
            this.summonerNameLabel.AutoSize = true;
            this.summonerNameLabel.Location = new System.Drawing.Point(6, 19);
            this.summonerNameLabel.Name = "summonerNameLabel";
            this.summonerNameLabel.Size = new System.Drawing.Size(112, 15);
            this.summonerNameLabel.TabIndex = 4;
            this.summonerNameLabel.Text = "Summoner\'s Name:";
            // 
            // launchButton
            // 
            this.launchButton.Location = new System.Drawing.Point(712, 60);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(75, 23);
            this.launchButton.TabIndex = 7;
            this.launchButton.Text = "Launch";
            this.launchButton.UseVisualStyleBackColor = true;
            this.launchButton.Click += new System.EventHandler(this.launchButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.launchButton);
            this.Controls.Add(this.summonerInfoGroupBox);
            this.Controls.Add(this.apiKeyTextBox);
            this.Controls.Add(this.enterAPIKeyLabel);
            this.Controls.Add(this.enterSummonerNameTextBox);
            this.Controls.Add(this.enterSummonerNameLabel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.summonerInfoGroupBox.ResumeLayout(false);
            this.summonerInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterSummonerNameLabel;
        private System.Windows.Forms.TextBox enterSummonerNameTextBox;
        private System.Windows.Forms.Label enterAPIKeyLabel;
        private System.Windows.Forms.TextBox apiKeyTextBox;
        private System.Windows.Forms.GroupBox summonerInfoGroupBox;
        private System.Windows.Forms.Label summonerLevelLabel;
        private System.Windows.Forms.Label summonerNameLabel;
        private System.Windows.Forms.TextBox summonerNameTextBox;
        private System.Windows.Forms.TextBox summonerLevelTextBox;
        private System.Windows.Forms.Button launchButton;
    }
}

