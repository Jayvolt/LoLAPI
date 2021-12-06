using System.Windows.Forms;
using System.Collections.Generic;
using Newtonsoft.Json;
using MingweiSamuel.Camille;
using MingweiSamuel.Camille.Enums;
using MingweiSamuel.Camille.SummonerV4;
using LoLAPI;
using MingweiSamuel.Camille.MatchV5;
using System;

namespace LoLAPIForm
{
    public partial class MainForm : Form
    {
        private string enteredAPIKey;
        private RiotApi riotApi;

        private Match selectedMatch;
        public Game Game { get; set; }
        private MatchInfo _matchInfo;


        private string enteredSummonerName;
        private Summoner summoner;


        public MainForm()
        {
            InitializeComponent();
            Game = new Game();
        }

        public void enterSummonerNameTextBox_TextChanged(object sender, System.EventArgs e)
        {
            enteredSummonerName = enterSummonerNameTextBox.Text;
        }

        public void apiKeyTextBox_TextChanged(object sender, System.EventArgs e)
        {
            enteredAPIKey = apiKeyTextBox.Text;
        }

        private void launchButton_Click(object sender, System.EventArgs e)
        {
            GetSummonerInformation();
        }
        void GetSummonerInformation()
        {
            riotApi = RiotApi.NewInstance(enteredAPIKey);
            summoner = riotApi.SummonerV4.GetBySummonerName(MingweiSamuel.Camille.Enums.Region.NA, enteredSummonerName);

            summonerNameTextBox.Enabled = true;
            summonerNameTextBox.Text = summoner.Name;
            summonerLevelTextBox.Enabled = true;
            summonerLevelTextBox.Text = summoner.SummonerLevel.ToString();

            summonerMatchesListBox.Enabled = true;
            var matches = riotApi.MatchV5.GetMatchIdsByPUUID(MingweiSamuel.Camille.Enums.Region.Americas, summoner.Puuid);
            foreach (var match in matches)
            {
                summonerMatchesListBox.Items.Add(match);
            }
        }

        private void summonerMatchesListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            winningTeamListBox.Items.Clear();
            losingTeamListBox.Items.Clear();
            GetMatchInformation();
        }
        void GetMatchInformation()
        {
            selectedMatch = riotApi.MatchV5.GetMatch(MingweiSamuel.Camille.Enums.Region.Americas, (string)summonerMatchesListBox.SelectedItem);
            foreach (KeyValuePair<string, object> entry in selectedMatch._AdditionalProperties)
            {
                if (entry.Key == "info")
                {
                    _matchInfo = (dynamic)JsonConvert.DeserializeObject<MatchInfo>(entry.Value.ToString());
                }
            }
            matchNameTextBox.Enabled = true;
            matchNameTextBox.Text = _matchInfo.GameName;
            matchGameModeTextBox.Enabled = true;
            matchGameModeTextBox.Text = _matchInfo.GameMode;

            long gameDuration = _matchInfo.GameDuration;
            TimeSpan t = TimeSpan.FromSeconds(gameDuration);
            matchDurationHoursTextBox.Enabled = true;
            matchDurationHoursTextBox.Text = string.Format("{0:D2}h", t.Hours);
            matchDurationMinutesTextBox.Enabled = true;
            matchDurationMinutesTextBox.Text = string.Format("{0:D2}m", t.Minutes);
            matchDurationSecondsTextBox.Enabled = true;
            matchDurationSecondsTextBox.Text = string.Format("{0:D2}s", t.Seconds);

            foreach (Participant participant in _matchInfo.Participants)
            {
                _matchInfo.SortParticipantsToTeams(participant);
            }
            winningTeamListBox.Enabled = true;
            foreach (Participant winningTeamMember in _matchInfo.winningTeam.TeamMembers)
            {
                winningTeamListBox.Items.Add(winningTeamMember);
            }
            losingTeamListBox.Enabled = true;
            foreach (Participant losingTeamMember in _matchInfo.losingTeam.TeamMembers)
            {
                losingTeamListBox.Items.Add(losingTeamMember);
            }
        }

        private void winningTeamListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            DisplayWinningTeamMemberInformation();
        }
        void DisplayWinningTeamMemberInformation()
        {
            var winningTeamMember = (Participant)winningTeamListBox.SelectedItem;
            winningTeamMemberSummonerName.Enabled = true;
            winningTeamMemberSummonerName.Text = winningTeamMember.SummonerName;
            winningTeamMemberSummonerLevel.Enabled = true;
            winningTeamMemberSummonerLevel.Text = winningTeamMember.SummonerLevel.ToString();
            winningTeamMemberChampionName.Enabled = true;
            winningTeamMemberChampionName.Text = winningTeamMember.ChampionName;
            winningTeamMemberTotalDamageDealt.Enabled = true;
            winningTeamMemberTotalDamageDealt.Text = winningTeamMember.TotalDamageDealt.ToString();
            winningTeamMemberKills.Enabled = true;
            winningTeamMemberKills.Text = winningTeamMember.Kill.ToString();
            winningTeamMemberTeamPosition.Enabled = true;
            winningTeamMemberTeamPosition.Text = winningTeamMember.TeamPosition;
            winningTeamMemberDeaths.Enabled = true;
            winningTeamMemberDeaths.Text = winningTeamMember.Deaths.ToString();
        }

        private void losingTeamListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            DisplayLosingTeamMemberInformation();
        }
        void DisplayLosingTeamMemberInformation()
        {
            var losingTeamMember = (Participant)losingTeamListBox.SelectedItem;
            losingTeamMemberSummonerName.Enabled = true;
            losingTeamMemberSummonerName.Text = losingTeamMember.SummonerName;
            losingTeamMemberSummonerLevel.Enabled = true;
            losingTeamMemberSummonerLevel.Text = losingTeamMember.SummonerLevel.ToString();
            losingTeamMemberChampionName.Enabled = true;
            losingTeamMemberChampionName.Text = losingTeamMember.ChampionName;
            losingTeamMemberTotalDamageDealt.Enabled = true;
            losingTeamMemberTotalDamageDealt.Text = losingTeamMember.TotalDamageDealt.ToString();
            losingTeamMemberKills.Enabled = true;
            losingTeamMemberKills.Text = losingTeamMember.Kill.ToString();
            losingTeamMemberTeamPosition.Enabled = true;
            losingTeamMemberTeamPosition.Text = losingTeamMember.TeamPosition;
            losingTeamMemberDeaths.Enabled = true;
            losingTeamMemberDeaths.Text = losingTeamMember.Deaths.ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
