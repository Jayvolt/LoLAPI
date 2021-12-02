using System.Windows.Forms;
using System.Collections.Generic;
using Newtonsoft.Json;
using MingweiSamuel.Camille;
using MingweiSamuel.Camille.Enums;
using MingweiSamuel.Camille.SummonerV4;
using LoLAPI;
using MingweiSamuel.Camille.MatchV5;

namespace LoLAPIForm
{
    public partial class MainForm : Form
    {
        private string enteredAPIKey;
        private RiotApi riotApi;

        private Match selectedMatch;
        public Game Game { get; set; }
        private MatchInfo _matchInfo;


        private int totalKills;
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

            summonerNameTextBox.Text = summoner.Name;
            summonerLevelTextBox.Text = summoner.SummonerLevel.ToString();

            var matches = riotApi.MatchV5.GetMatchIdsByPUUID(MingweiSamuel.Camille.Enums.Region.Americas, summoner.Puuid);

            foreach (var match in matches)
            {
                Match currentMatch = riotApi.MatchV5.GetMatch(MingweiSamuel.Camille.Enums.Region.Americas, match);
                Game.Matches.Add(currentMatch);
                summonerMatchesListBox.Items.Add(currentMatch);
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
            selectedMatch = (Match)summonerMatchesListBox.SelectedItem;
            //selectedMatch = riotApi.MatchV5.GetMatch(MingweiSamuel.Camille.Enums.Region.Americas, summonerMatchesListBox.Text);
            foreach (KeyValuePair<string, object> entry in selectedMatch._AdditionalProperties)
            {
                if (entry.Key == "info")
                {
                    _matchInfo = (dynamic)JsonConvert.DeserializeObject<MatchInfo>(entry.Value.ToString());
                }
            }
            foreach (Participant participant in _matchInfo.Participants)
            {
                _matchInfo.SortParticipantsToTeams(participant);
                totalKills += participant.Kill;
            }

            foreach (Participant winningTeamMember in _matchInfo.winningTeam.TeamMembers)
            {
                winningTeamListBox.Items.Add(winningTeamMember);
            }
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
            winningTeamMemberSummonerName.Text = winningTeamMember.SummonerName;
            winningTeamMemberSummonerLevel.Text = winningTeamMember.SummonerLevel.ToString();
            winningTeamMemberChampionName.Text = winningTeamMember.ChampionName;
            winningTeamMemberTotalDamageDealt.Text = winningTeamMember.TotalDamageDealt.ToString();
            winningTeamMemberKills.Text = winningTeamMember.Kill.ToString();
            winningTeamMemberTeamPosition.Text = winningTeamMember.TeamPosition;
            winningTeamMemberDeaths.Text = winningTeamMember.Deaths.ToString();
        }

        private void losingTeamListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            DisplayLosingTeamMemberInformation();
        }
        void DisplayLosingTeamMemberInformation()
        {
            var losingTeamMember = (Participant)losingTeamListBox.SelectedItem;
            losingTeamMemberSummonerName.Text = losingTeamMember.SummonerName;
            losingTeamMemberSummonerLevel.Text = losingTeamMember.SummonerLevel.ToString();
            losingTeamMemberChampionName.Text = losingTeamMember.ChampionName;
            losingTeamMemberTotalDamageDealt.Text = losingTeamMember.TotalDamageDealt.ToString();
            losingTeamMemberKills.Text = losingTeamMember.Kill.ToString();
            losingTeamMemberTeamPosition.Text = losingTeamMember.TeamPosition;
            losingTeamMemberDeaths.Text = losingTeamMember.Deaths.ToString();
        }
    }
}
