
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
            this.summonerMatchesListBox = new System.Windows.Forms.ListBox();
            this.recentMatchesLabel = new System.Windows.Forms.Label();
            this.summonerLevelTextBox = new System.Windows.Forms.TextBox();
            this.summonerNameTextBox = new System.Windows.Forms.TextBox();
            this.summonerLevelLabel = new System.Windows.Forms.Label();
            this.summonerNameLabel = new System.Windows.Forms.Label();
            this.launchButton = new System.Windows.Forms.Button();
            this.matchGroupBox = new System.Windows.Forms.GroupBox();
            this.losingTeamGroupBox = new System.Windows.Forms.GroupBox();
            this.losingTeamMemberDeathsLabel = new System.Windows.Forms.Label();
            this.losingTeamMemberTeamPositionLabel = new System.Windows.Forms.Label();
            this.losingTeamMemberDamageDealtLabel = new System.Windows.Forms.Label();
            this.losingTeamMemberKillsLabel = new System.Windows.Forms.Label();
            this.losingTeamMemberChampionNameLabel = new System.Windows.Forms.Label();
            this.losingTeamMemberSummonerLevelLabel = new System.Windows.Forms.Label();
            this.losingTeamMemberSummonerNameLabel = new System.Windows.Forms.Label();
            this.losingTeamMemberTeamPosition = new System.Windows.Forms.TextBox();
            this.losingTeamMemberDeaths = new System.Windows.Forms.TextBox();
            this.losingTeamMemberKills = new System.Windows.Forms.TextBox();
            this.losingTeamMemberTotalDamageDealt = new System.Windows.Forms.TextBox();
            this.losingTeamMemberChampionName = new System.Windows.Forms.TextBox();
            this.losingTeamMemberSummonerLevel = new System.Windows.Forms.TextBox();
            this.losingTeamMemberSummonerName = new System.Windows.Forms.TextBox();
            this.losingTeamMembersLabel = new System.Windows.Forms.Label();
            this.losingTeamListBox = new System.Windows.Forms.ListBox();
            this.winningTeamGroupBox = new System.Windows.Forms.GroupBox();
            this.winningTeamMemberDeathsLabel = new System.Windows.Forms.Label();
            this.winningTeamMemberTeamPositionLabel = new System.Windows.Forms.Label();
            this.winningTeamMemberDamageDealtLabel = new System.Windows.Forms.Label();
            this.winningTeamMemberKillsLabel = new System.Windows.Forms.Label();
            this.winningTeamMemberChampionNameLabel = new System.Windows.Forms.Label();
            this.winningTeamMemberSummonerLevelLabel = new System.Windows.Forms.Label();
            this.winningTeamMemberSummonerNameLabel = new System.Windows.Forms.Label();
            this.winningTeamMemberTeamPosition = new System.Windows.Forms.TextBox();
            this.winningTeamMemberDeaths = new System.Windows.Forms.TextBox();
            this.winningTeamMemberKills = new System.Windows.Forms.TextBox();
            this.winningTeamMemberTotalDamageDealt = new System.Windows.Forms.TextBox();
            this.winningTeamMemberChampionName = new System.Windows.Forms.TextBox();
            this.winningTeamMemberSummonerLevel = new System.Windows.Forms.TextBox();
            this.winningTeamMemberSummonerName = new System.Windows.Forms.TextBox();
            this.winningTeamMembersLabel = new System.Windows.Forms.Label();
            this.winningTeamListBox = new System.Windows.Forms.ListBox();
            this.summonerInfoGroupBox.SuspendLayout();
            this.matchGroupBox.SuspendLayout();
            this.losingTeamGroupBox.SuspendLayout();
            this.winningTeamGroupBox.SuspendLayout();
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
            this.enterAPIKeyLabel.Location = new System.Drawing.Point(225, 13);
            this.enterAPIKeyLabel.Name = "enterAPIKeyLabel";
            this.enterAPIKeyLabel.Size = new System.Drawing.Size(80, 15);
            this.enterAPIKeyLabel.TabIndex = 4;
            this.enterAPIKeyLabel.Text = "Enter API Key:";
            // 
            // apiKeyTextBox
            // 
            this.apiKeyTextBox.Location = new System.Drawing.Point(225, 31);
            this.apiKeyTextBox.Name = "apiKeyTextBox";
            this.apiKeyTextBox.Size = new System.Drawing.Size(456, 23);
            this.apiKeyTextBox.TabIndex = 5;
            this.apiKeyTextBox.TextChanged += new System.EventHandler(this.apiKeyTextBox_TextChanged);
            // 
            // summonerInfoGroupBox
            // 
            this.summonerInfoGroupBox.Controls.Add(this.summonerMatchesListBox);
            this.summonerInfoGroupBox.Controls.Add(this.recentMatchesLabel);
            this.summonerInfoGroupBox.Controls.Add(this.summonerLevelTextBox);
            this.summonerInfoGroupBox.Controls.Add(this.summonerNameTextBox);
            this.summonerInfoGroupBox.Controls.Add(this.summonerLevelLabel);
            this.summonerInfoGroupBox.Controls.Add(this.summonerNameLabel);
            this.summonerInfoGroupBox.Location = new System.Drawing.Point(12, 60);
            this.summonerInfoGroupBox.Name = "summonerInfoGroupBox";
            this.summonerInfoGroupBox.Size = new System.Drawing.Size(201, 418);
            this.summonerInfoGroupBox.TabIndex = 6;
            this.summonerInfoGroupBox.TabStop = false;
            this.summonerInfoGroupBox.Text = "Summoner Information";
            // 
            // summonerMatchesListBox
            // 
            this.summonerMatchesListBox.FormattingEnabled = true;
            this.summonerMatchesListBox.ItemHeight = 15;
            this.summonerMatchesListBox.Location = new System.Drawing.Point(7, 142);
            this.summonerMatchesListBox.Name = "summonerMatchesListBox";
            this.summonerMatchesListBox.Size = new System.Drawing.Size(175, 259);
            this.summonerMatchesListBox.TabIndex = 9;
            this.summonerMatchesListBox.SelectedIndexChanged += new System.EventHandler(this.summonerMatchesListBox_SelectedIndexChanged);
            // 
            // recentMatchesLabel
            // 
            this.recentMatchesLabel.AutoSize = true;
            this.recentMatchesLabel.Location = new System.Drawing.Point(7, 124);
            this.recentMatchesLabel.Name = "recentMatchesLabel";
            this.recentMatchesLabel.Size = new System.Drawing.Size(187, 15);
            this.recentMatchesLabel.TabIndex = 8;
            this.recentMatchesLabel.Text = "Summoner\'s Recent Matches (20):";
            // 
            // summonerLevelTextBox
            // 
            this.summonerLevelTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.summonerLevelTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.summonerLevelTextBox.Location = new System.Drawing.Point(6, 87);
            this.summonerLevelTextBox.Name = "summonerLevelTextBox";
            this.summonerLevelTextBox.ReadOnly = true;
            this.summonerLevelTextBox.Size = new System.Drawing.Size(107, 23);
            this.summonerLevelTextBox.TabIndex = 7;
            // 
            // summonerNameTextBox
            // 
            this.summonerNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.summonerNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.summonerNameTextBox.Location = new System.Drawing.Point(6, 37);
            this.summonerNameTextBox.Name = "summonerNameTextBox";
            this.summonerNameTextBox.ReadOnly = true;
            this.summonerNameTextBox.Size = new System.Drawing.Size(175, 23);
            this.summonerNameTextBox.TabIndex = 6;
            // 
            // summonerLevelLabel
            // 
            this.summonerLevelLabel.AutoSize = true;
            this.summonerLevelLabel.Location = new System.Drawing.Point(7, 69);
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
            this.launchButton.Location = new System.Drawing.Point(713, 31);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(75, 23);
            this.launchButton.TabIndex = 7;
            this.launchButton.Text = "Launch";
            this.launchButton.UseVisualStyleBackColor = true;
            this.launchButton.Click += new System.EventHandler(this.launchButton_Click);
            // 
            // matchGroupBox
            // 
            this.matchGroupBox.Controls.Add(this.losingTeamGroupBox);
            this.matchGroupBox.Controls.Add(this.winningTeamGroupBox);
            this.matchGroupBox.Location = new System.Drawing.Point(225, 60);
            this.matchGroupBox.Name = "matchGroupBox";
            this.matchGroupBox.Size = new System.Drawing.Size(700, 418);
            this.matchGroupBox.TabIndex = 8;
            this.matchGroupBox.TabStop = false;
            this.matchGroupBox.Text = "Match Information";
            // 
            // losingTeamGroupBox
            // 
            this.losingTeamGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.losingTeamGroupBox.Controls.Add(this.losingTeamMemberDeathsLabel);
            this.losingTeamGroupBox.Controls.Add(this.losingTeamMemberTeamPositionLabel);
            this.losingTeamGroupBox.Controls.Add(this.losingTeamMemberDamageDealtLabel);
            this.losingTeamGroupBox.Controls.Add(this.losingTeamMemberKillsLabel);
            this.losingTeamGroupBox.Controls.Add(this.losingTeamMemberChampionNameLabel);
            this.losingTeamGroupBox.Controls.Add(this.losingTeamMemberSummonerLevelLabel);
            this.losingTeamGroupBox.Controls.Add(this.losingTeamMemberSummonerNameLabel);
            this.losingTeamGroupBox.Controls.Add(this.losingTeamMemberTeamPosition);
            this.losingTeamGroupBox.Controls.Add(this.losingTeamMemberDeaths);
            this.losingTeamGroupBox.Controls.Add(this.losingTeamMemberKills);
            this.losingTeamGroupBox.Controls.Add(this.losingTeamMemberTotalDamageDealt);
            this.losingTeamGroupBox.Controls.Add(this.losingTeamMemberChampionName);
            this.losingTeamGroupBox.Controls.Add(this.losingTeamMemberSummonerLevel);
            this.losingTeamGroupBox.Controls.Add(this.losingTeamMemberSummonerName);
            this.losingTeamGroupBox.Controls.Add(this.losingTeamMembersLabel);
            this.losingTeamGroupBox.Controls.Add(this.losingTeamListBox);
            this.losingTeamGroupBox.Location = new System.Drawing.Point(352, 124);
            this.losingTeamGroupBox.Name = "losingTeamGroupBox";
            this.losingTeamGroupBox.Size = new System.Drawing.Size(340, 285);
            this.losingTeamGroupBox.TabIndex = 6;
            this.losingTeamGroupBox.TabStop = false;
            this.losingTeamGroupBox.Text = "Losing Team";
            // 
            // losingTeamMemberDeathsLabel
            // 
            this.losingTeamMemberDeathsLabel.AutoSize = true;
            this.losingTeamMemberDeathsLabel.Location = new System.Drawing.Point(185, 233);
            this.losingTeamMemberDeathsLabel.Name = "losingTeamMemberDeathsLabel";
            this.losingTeamMemberDeathsLabel.Size = new System.Drawing.Size(46, 15);
            this.losingTeamMemberDeathsLabel.TabIndex = 21;
            this.losingTeamMemberDeathsLabel.Text = "Deaths:";
            // 
            // losingTeamMemberTeamPositionLabel
            // 
            this.losingTeamMemberTeamPositionLabel.AutoSize = true;
            this.losingTeamMemberTeamPositionLabel.Location = new System.Drawing.Point(6, 233);
            this.losingTeamMemberTeamPositionLabel.Name = "losingTeamMemberTeamPositionLabel";
            this.losingTeamMemberTeamPositionLabel.Size = new System.Drawing.Size(84, 15);
            this.losingTeamMemberTeamPositionLabel.TabIndex = 20;
            this.losingTeamMemberTeamPositionLabel.Text = "Team Position:";
            // 
            // losingTeamMemberDamageDealtLabel
            // 
            this.losingTeamMemberDamageDealtLabel.AutoSize = true;
            this.losingTeamMemberDamageDealtLabel.Location = new System.Drawing.Point(6, 189);
            this.losingTeamMemberDamageDealtLabel.Name = "losingTeamMemberDamageDealtLabel";
            this.losingTeamMemberDamageDealtLabel.Size = new System.Drawing.Size(112, 15);
            this.losingTeamMemberDamageDealtLabel.TabIndex = 19;
            this.losingTeamMemberDamageDealtLabel.Text = "Total Damage Dealt:";
            // 
            // losingTeamMemberKillsLabel
            // 
            this.losingTeamMemberKillsLabel.AutoSize = true;
            this.losingTeamMemberKillsLabel.Location = new System.Drawing.Point(185, 189);
            this.losingTeamMemberKillsLabel.Name = "losingTeamMemberKillsLabel";
            this.losingTeamMemberKillsLabel.Size = new System.Drawing.Size(31, 15);
            this.losingTeamMemberKillsLabel.TabIndex = 18;
            this.losingTeamMemberKillsLabel.Text = "Kills:";
            // 
            // losingTeamMemberChampionNameLabel
            // 
            this.losingTeamMemberChampionNameLabel.AutoSize = true;
            this.losingTeamMemberChampionNameLabel.Location = new System.Drawing.Point(6, 145);
            this.losingTeamMemberChampionNameLabel.Name = "losingTeamMemberChampionNameLabel";
            this.losingTeamMemberChampionNameLabel.Size = new System.Drawing.Size(101, 15);
            this.losingTeamMemberChampionNameLabel.TabIndex = 17;
            this.losingTeamMemberChampionNameLabel.Text = "Champion Name:";
            // 
            // losingTeamMemberSummonerLevelLabel
            // 
            this.losingTeamMemberSummonerLevelLabel.AutoSize = true;
            this.losingTeamMemberSummonerLevelLabel.Location = new System.Drawing.Point(185, 85);
            this.losingTeamMemberSummonerLevelLabel.Name = "losingTeamMemberSummonerLevelLabel";
            this.losingTeamMemberSummonerLevelLabel.Size = new System.Drawing.Size(99, 15);
            this.losingTeamMemberSummonerLevelLabel.TabIndex = 16;
            this.losingTeamMemberSummonerLevelLabel.Text = "Summoner Level:";
            // 
            // losingTeamMemberSummonerNameLabel
            // 
            this.losingTeamMemberSummonerNameLabel.AutoSize = true;
            this.losingTeamMemberSummonerNameLabel.Location = new System.Drawing.Point(185, 41);
            this.losingTeamMemberSummonerNameLabel.Name = "losingTeamMemberSummonerNameLabel";
            this.losingTeamMemberSummonerNameLabel.Size = new System.Drawing.Size(104, 15);
            this.losingTeamMemberSummonerNameLabel.TabIndex = 15;
            this.losingTeamMemberSummonerNameLabel.Text = "Summoner Name:";
            // 
            // losingTeamMemberTeamPosition
            // 
            this.losingTeamMemberTeamPosition.BackColor = System.Drawing.SystemColors.Window;
            this.losingTeamMemberTeamPosition.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.losingTeamMemberTeamPosition.Location = new System.Drawing.Point(6, 251);
            this.losingTeamMemberTeamPosition.Name = "losingTeamMemberTeamPosition";
            this.losingTeamMemberTeamPosition.ReadOnly = true;
            this.losingTeamMemberTeamPosition.Size = new System.Drawing.Size(173, 23);
            this.losingTeamMemberTeamPosition.TabIndex = 14;
            // 
            // losingTeamMemberDeaths
            // 
            this.losingTeamMemberDeaths.BackColor = System.Drawing.SystemColors.Window;
            this.losingTeamMemberDeaths.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.losingTeamMemberDeaths.Location = new System.Drawing.Point(185, 251);
            this.losingTeamMemberDeaths.Name = "losingTeamMemberDeaths";
            this.losingTeamMemberDeaths.ReadOnly = true;
            this.losingTeamMemberDeaths.Size = new System.Drawing.Size(149, 23);
            this.losingTeamMemberDeaths.TabIndex = 13;
            // 
            // losingTeamMemberKills
            // 
            this.losingTeamMemberKills.BackColor = System.Drawing.SystemColors.Window;
            this.losingTeamMemberKills.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.losingTeamMemberKills.Location = new System.Drawing.Point(185, 207);
            this.losingTeamMemberKills.Name = "losingTeamMemberKills";
            this.losingTeamMemberKills.ReadOnly = true;
            this.losingTeamMemberKills.Size = new System.Drawing.Size(149, 23);
            this.losingTeamMemberKills.TabIndex = 12;
            // 
            // losingTeamMemberTotalDamageDealt
            // 
            this.losingTeamMemberTotalDamageDealt.BackColor = System.Drawing.SystemColors.Window;
            this.losingTeamMemberTotalDamageDealt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.losingTeamMemberTotalDamageDealt.Location = new System.Drawing.Point(6, 207);
            this.losingTeamMemberTotalDamageDealt.Name = "losingTeamMemberTotalDamageDealt";
            this.losingTeamMemberTotalDamageDealt.ReadOnly = true;
            this.losingTeamMemberTotalDamageDealt.Size = new System.Drawing.Size(173, 23);
            this.losingTeamMemberTotalDamageDealt.TabIndex = 11;
            // 
            // losingTeamMemberChampionName
            // 
            this.losingTeamMemberChampionName.BackColor = System.Drawing.SystemColors.Window;
            this.losingTeamMemberChampionName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.losingTeamMemberChampionName.Location = new System.Drawing.Point(6, 163);
            this.losingTeamMemberChampionName.Name = "losingTeamMemberChampionName";
            this.losingTeamMemberChampionName.ReadOnly = true;
            this.losingTeamMemberChampionName.Size = new System.Drawing.Size(328, 23);
            this.losingTeamMemberChampionName.TabIndex = 10;
            // 
            // losingTeamMemberSummonerLevel
            // 
            this.losingTeamMemberSummonerLevel.BackColor = System.Drawing.SystemColors.Window;
            this.losingTeamMemberSummonerLevel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.losingTeamMemberSummonerLevel.Location = new System.Drawing.Point(185, 103);
            this.losingTeamMemberSummonerLevel.Name = "losingTeamMemberSummonerLevel";
            this.losingTeamMemberSummonerLevel.ReadOnly = true;
            this.losingTeamMemberSummonerLevel.Size = new System.Drawing.Size(149, 23);
            this.losingTeamMemberSummonerLevel.TabIndex = 9;
            // 
            // losingTeamMemberSummonerName
            // 
            this.losingTeamMemberSummonerName.BackColor = System.Drawing.SystemColors.Window;
            this.losingTeamMemberSummonerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.losingTeamMemberSummonerName.Location = new System.Drawing.Point(185, 59);
            this.losingTeamMemberSummonerName.Name = "losingTeamMemberSummonerName";
            this.losingTeamMemberSummonerName.ReadOnly = true;
            this.losingTeamMemberSummonerName.Size = new System.Drawing.Size(149, 23);
            this.losingTeamMemberSummonerName.TabIndex = 8;
            // 
            // losingTeamMembersLabel
            // 
            this.losingTeamMembersLabel.AutoSize = true;
            this.losingTeamMembersLabel.Location = new System.Drawing.Point(6, 26);
            this.losingTeamMembersLabel.Name = "losingTeamMembersLabel";
            this.losingTeamMembersLabel.Size = new System.Drawing.Size(91, 15);
            this.losingTeamMembersLabel.TabIndex = 5;
            this.losingTeamMembersLabel.Text = "Team Members:";
            // 
            // losingTeamListBox
            // 
            this.losingTeamListBox.FormattingEnabled = true;
            this.losingTeamListBox.ItemHeight = 15;
            this.losingTeamListBox.Location = new System.Drawing.Point(6, 44);
            this.losingTeamListBox.Name = "losingTeamListBox";
            this.losingTeamListBox.Size = new System.Drawing.Size(173, 94);
            this.losingTeamListBox.TabIndex = 4;
            this.losingTeamListBox.SelectedIndexChanged += new System.EventHandler(this.losingTeamListBox_SelectedIndexChanged);
            // 
            // winningTeamGroupBox
            // 
            this.winningTeamGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.winningTeamGroupBox.Controls.Add(this.winningTeamMemberDeathsLabel);
            this.winningTeamGroupBox.Controls.Add(this.winningTeamMemberTeamPositionLabel);
            this.winningTeamGroupBox.Controls.Add(this.winningTeamMemberDamageDealtLabel);
            this.winningTeamGroupBox.Controls.Add(this.winningTeamMemberKillsLabel);
            this.winningTeamGroupBox.Controls.Add(this.winningTeamMemberChampionNameLabel);
            this.winningTeamGroupBox.Controls.Add(this.winningTeamMemberSummonerLevelLabel);
            this.winningTeamGroupBox.Controls.Add(this.winningTeamMemberSummonerNameLabel);
            this.winningTeamGroupBox.Controls.Add(this.winningTeamMemberTeamPosition);
            this.winningTeamGroupBox.Controls.Add(this.winningTeamMemberDeaths);
            this.winningTeamGroupBox.Controls.Add(this.winningTeamMemberKills);
            this.winningTeamGroupBox.Controls.Add(this.winningTeamMemberTotalDamageDealt);
            this.winningTeamGroupBox.Controls.Add(this.winningTeamMemberChampionName);
            this.winningTeamGroupBox.Controls.Add(this.winningTeamMemberSummonerLevel);
            this.winningTeamGroupBox.Controls.Add(this.winningTeamMemberSummonerName);
            this.winningTeamGroupBox.Controls.Add(this.winningTeamMembersLabel);
            this.winningTeamGroupBox.Controls.Add(this.winningTeamListBox);
            this.winningTeamGroupBox.Location = new System.Drawing.Point(6, 124);
            this.winningTeamGroupBox.Name = "winningTeamGroupBox";
            this.winningTeamGroupBox.Size = new System.Drawing.Size(340, 285);
            this.winningTeamGroupBox.TabIndex = 4;
            this.winningTeamGroupBox.TabStop = false;
            this.winningTeamGroupBox.Text = "Winning Team";
            // 
            // winningTeamMemberDeathsLabel
            // 
            this.winningTeamMemberDeathsLabel.AutoSize = true;
            this.winningTeamMemberDeathsLabel.Location = new System.Drawing.Point(185, 233);
            this.winningTeamMemberDeathsLabel.Name = "winningTeamMemberDeathsLabel";
            this.winningTeamMemberDeathsLabel.Size = new System.Drawing.Size(46, 15);
            this.winningTeamMemberDeathsLabel.TabIndex = 21;
            this.winningTeamMemberDeathsLabel.Text = "Deaths:";
            // 
            // winningTeamMemberTeamPositionLabel
            // 
            this.winningTeamMemberTeamPositionLabel.AutoSize = true;
            this.winningTeamMemberTeamPositionLabel.Location = new System.Drawing.Point(6, 233);
            this.winningTeamMemberTeamPositionLabel.Name = "winningTeamMemberTeamPositionLabel";
            this.winningTeamMemberTeamPositionLabel.Size = new System.Drawing.Size(84, 15);
            this.winningTeamMemberTeamPositionLabel.TabIndex = 20;
            this.winningTeamMemberTeamPositionLabel.Text = "Team Position:";
            // 
            // winningTeamMemberDamageDealtLabel
            // 
            this.winningTeamMemberDamageDealtLabel.AutoSize = true;
            this.winningTeamMemberDamageDealtLabel.Location = new System.Drawing.Point(6, 189);
            this.winningTeamMemberDamageDealtLabel.Name = "winningTeamMemberDamageDealtLabel";
            this.winningTeamMemberDamageDealtLabel.Size = new System.Drawing.Size(112, 15);
            this.winningTeamMemberDamageDealtLabel.TabIndex = 19;
            this.winningTeamMemberDamageDealtLabel.Text = "Total Damage Dealt:";
            // 
            // winningTeamMemberKillsLabel
            // 
            this.winningTeamMemberKillsLabel.AutoSize = true;
            this.winningTeamMemberKillsLabel.Location = new System.Drawing.Point(185, 189);
            this.winningTeamMemberKillsLabel.Name = "winningTeamMemberKillsLabel";
            this.winningTeamMemberKillsLabel.Size = new System.Drawing.Size(31, 15);
            this.winningTeamMemberKillsLabel.TabIndex = 18;
            this.winningTeamMemberKillsLabel.Text = "Kills:";
            // 
            // winningTeamMemberChampionNameLabel
            // 
            this.winningTeamMemberChampionNameLabel.AutoSize = true;
            this.winningTeamMemberChampionNameLabel.Location = new System.Drawing.Point(6, 145);
            this.winningTeamMemberChampionNameLabel.Name = "winningTeamMemberChampionNameLabel";
            this.winningTeamMemberChampionNameLabel.Size = new System.Drawing.Size(101, 15);
            this.winningTeamMemberChampionNameLabel.TabIndex = 17;
            this.winningTeamMemberChampionNameLabel.Text = "Champion Name:";
            // 
            // winningTeamMemberSummonerLevelLabel
            // 
            this.winningTeamMemberSummonerLevelLabel.AutoSize = true;
            this.winningTeamMemberSummonerLevelLabel.Location = new System.Drawing.Point(185, 85);
            this.winningTeamMemberSummonerLevelLabel.Name = "winningTeamMemberSummonerLevelLabel";
            this.winningTeamMemberSummonerLevelLabel.Size = new System.Drawing.Size(99, 15);
            this.winningTeamMemberSummonerLevelLabel.TabIndex = 16;
            this.winningTeamMemberSummonerLevelLabel.Text = "Summoner Level:";
            // 
            // winningTeamMemberSummonerNameLabel
            // 
            this.winningTeamMemberSummonerNameLabel.AutoSize = true;
            this.winningTeamMemberSummonerNameLabel.Location = new System.Drawing.Point(185, 41);
            this.winningTeamMemberSummonerNameLabel.Name = "winningTeamMemberSummonerNameLabel";
            this.winningTeamMemberSummonerNameLabel.Size = new System.Drawing.Size(104, 15);
            this.winningTeamMemberSummonerNameLabel.TabIndex = 15;
            this.winningTeamMemberSummonerNameLabel.Text = "Summoner Name:";
            // 
            // winningTeamMemberTeamPosition
            // 
            this.winningTeamMemberTeamPosition.BackColor = System.Drawing.SystemColors.Window;
            this.winningTeamMemberTeamPosition.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.winningTeamMemberTeamPosition.Location = new System.Drawing.Point(6, 251);
            this.winningTeamMemberTeamPosition.Name = "winningTeamMemberTeamPosition";
            this.winningTeamMemberTeamPosition.ReadOnly = true;
            this.winningTeamMemberTeamPosition.Size = new System.Drawing.Size(173, 23);
            this.winningTeamMemberTeamPosition.TabIndex = 14;
            // 
            // winningTeamMemberDeaths
            // 
            this.winningTeamMemberDeaths.BackColor = System.Drawing.SystemColors.Window;
            this.winningTeamMemberDeaths.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.winningTeamMemberDeaths.Location = new System.Drawing.Point(185, 251);
            this.winningTeamMemberDeaths.Name = "winningTeamMemberDeaths";
            this.winningTeamMemberDeaths.ReadOnly = true;
            this.winningTeamMemberDeaths.Size = new System.Drawing.Size(149, 23);
            this.winningTeamMemberDeaths.TabIndex = 13;
            // 
            // winningTeamMemberKills
            // 
            this.winningTeamMemberKills.BackColor = System.Drawing.SystemColors.Window;
            this.winningTeamMemberKills.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.winningTeamMemberKills.Location = new System.Drawing.Point(185, 207);
            this.winningTeamMemberKills.Name = "winningTeamMemberKills";
            this.winningTeamMemberKills.ReadOnly = true;
            this.winningTeamMemberKills.Size = new System.Drawing.Size(149, 23);
            this.winningTeamMemberKills.TabIndex = 12;
            // 
            // winningTeamMemberTotalDamageDealt
            // 
            this.winningTeamMemberTotalDamageDealt.BackColor = System.Drawing.SystemColors.Window;
            this.winningTeamMemberTotalDamageDealt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.winningTeamMemberTotalDamageDealt.Location = new System.Drawing.Point(6, 207);
            this.winningTeamMemberTotalDamageDealt.Name = "winningTeamMemberTotalDamageDealt";
            this.winningTeamMemberTotalDamageDealt.ReadOnly = true;
            this.winningTeamMemberTotalDamageDealt.Size = new System.Drawing.Size(173, 23);
            this.winningTeamMemberTotalDamageDealt.TabIndex = 11;
            // 
            // winningTeamMemberChampionName
            // 
            this.winningTeamMemberChampionName.BackColor = System.Drawing.SystemColors.Window;
            this.winningTeamMemberChampionName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.winningTeamMemberChampionName.Location = new System.Drawing.Point(6, 163);
            this.winningTeamMemberChampionName.Name = "winningTeamMemberChampionName";
            this.winningTeamMemberChampionName.ReadOnly = true;
            this.winningTeamMemberChampionName.Size = new System.Drawing.Size(328, 23);
            this.winningTeamMemberChampionName.TabIndex = 10;
            // 
            // winningTeamMemberSummonerLevel
            // 
            this.winningTeamMemberSummonerLevel.BackColor = System.Drawing.SystemColors.Window;
            this.winningTeamMemberSummonerLevel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.winningTeamMemberSummonerLevel.Location = new System.Drawing.Point(185, 103);
            this.winningTeamMemberSummonerLevel.Name = "winningTeamMemberSummonerLevel";
            this.winningTeamMemberSummonerLevel.ReadOnly = true;
            this.winningTeamMemberSummonerLevel.Size = new System.Drawing.Size(149, 23);
            this.winningTeamMemberSummonerLevel.TabIndex = 9;
            // 
            // winningTeamMemberSummonerName
            // 
            this.winningTeamMemberSummonerName.BackColor = System.Drawing.SystemColors.Window;
            this.winningTeamMemberSummonerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.winningTeamMemberSummonerName.Location = new System.Drawing.Point(185, 59);
            this.winningTeamMemberSummonerName.Name = "winningTeamMemberSummonerName";
            this.winningTeamMemberSummonerName.ReadOnly = true;
            this.winningTeamMemberSummonerName.Size = new System.Drawing.Size(149, 23);
            this.winningTeamMemberSummonerName.TabIndex = 8;
            // 
            // winningTeamMembersLabel
            // 
            this.winningTeamMembersLabel.AutoSize = true;
            this.winningTeamMembersLabel.Location = new System.Drawing.Point(6, 26);
            this.winningTeamMembersLabel.Name = "winningTeamMembersLabel";
            this.winningTeamMembersLabel.Size = new System.Drawing.Size(91, 15);
            this.winningTeamMembersLabel.TabIndex = 5;
            this.winningTeamMembersLabel.Text = "Team Members:";
            // 
            // winningTeamListBox
            // 
            this.winningTeamListBox.FormattingEnabled = true;
            this.winningTeamListBox.ItemHeight = 15;
            this.winningTeamListBox.Location = new System.Drawing.Point(6, 44);
            this.winningTeamListBox.Name = "winningTeamListBox";
            this.winningTeamListBox.Size = new System.Drawing.Size(173, 94);
            this.winningTeamListBox.TabIndex = 4;
            this.winningTeamListBox.SelectedIndexChanged += new System.EventHandler(this.winningTeamListBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 486);
            this.Controls.Add(this.matchGroupBox);
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
            this.matchGroupBox.ResumeLayout(false);
            this.losingTeamGroupBox.ResumeLayout(false);
            this.losingTeamGroupBox.PerformLayout();
            this.winningTeamGroupBox.ResumeLayout(false);
            this.winningTeamGroupBox.PerformLayout();
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
        private System.Windows.Forms.ListBox summonerMatchesListBox;
        private System.Windows.Forms.Label recentMatchesLabel;
        private System.Windows.Forms.GroupBox matchGroupBox;
        private System.Windows.Forms.GroupBox winningTeamGroupBox;
        private System.Windows.Forms.Label winningTeamMembersLabel;
        private System.Windows.Forms.ListBox winningTeamListBox;
        private System.Windows.Forms.TextBox winningTeamMemberSummonerName;
        private System.Windows.Forms.TextBox winningTeamMemberTeamPosition;
        private System.Windows.Forms.TextBox winningTeamMemberDeaths;
        private System.Windows.Forms.TextBox winningTeamMemberKills;
        private System.Windows.Forms.TextBox winningTeamMemberTotalDamageDealt;
        private System.Windows.Forms.TextBox winningTeamMemberChampionName;
        private System.Windows.Forms.TextBox winningTeamMemberSummonerLevel;
        private System.Windows.Forms.Label winningTeamMemberSummonerNameLabel;
        private System.Windows.Forms.Label winningTeamMemberDamageDealtLabel;
        private System.Windows.Forms.Label winningTeamMemberKillsLabel;
        private System.Windows.Forms.Label winningTeamMemberChampionNameLabel;
        private System.Windows.Forms.Label winningTeamMemberSummonerLevelLabel;
        private System.Windows.Forms.Label winningTeamMemberDeathsLabel;
        private System.Windows.Forms.Label winningTeamMemberTeamPositionLabel;
        private System.Windows.Forms.GroupBox losingTeamGroupBox;
        private System.Windows.Forms.Label losingTeamMemberDeathsLabel;
        private System.Windows.Forms.Label losingTeamMemberTeamPositionLabel;
        private System.Windows.Forms.Label losingTeamMemberDamageDealtLabel;
        private System.Windows.Forms.Label losingTeamMemberKillsLabel;
        private System.Windows.Forms.Label losingTeamMemberChampionNameLabel;
        private System.Windows.Forms.Label losingTeamMemberSummonerLevelLabel;
        private System.Windows.Forms.Label losingTeamMemberSummonerNameLabel;
        private System.Windows.Forms.TextBox losingTeamMemberTeamPosition;
        private System.Windows.Forms.TextBox losingTeamMemberDeaths;
        private System.Windows.Forms.TextBox losingTeamMemberKills;
        private System.Windows.Forms.TextBox losingTeamMemberTotalDamageDealt;
        private System.Windows.Forms.TextBox losingTeamMemberChampionName;
        private System.Windows.Forms.TextBox losingTeamMemberSummonerLevel;
        private System.Windows.Forms.TextBox losingTeamMemberSummonerName;
        private System.Windows.Forms.Label losingTeamMembersLabel;
        private System.Windows.Forms.ListBox losingTeamListBox;
    }
}

