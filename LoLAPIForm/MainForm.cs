using System.Windows.Forms;
using System.Collections.Generic;
using Newtonsoft.Json;
using MingweiSamuel.Camille;
using MingweiSamuel.Camille.Enums;
using MingweiSamuel.Camille.SummonerV4;
using LoLAPI;

namespace LoLAPIForm
{
    public partial class MainForm : Form
    {
        private string enteredAPIKey;
        private RiotApi riotApi;

        private MatchInfo _matchInfo;
        private MatchInfo MatchInfo 
        { 
            get => _matchInfo; 
            set => _matchInfo = value; 
        }

        private int totalKills;
        private string enteredSummonerName;
        private Summoner summoner;
        private Summoner Summoner 
        { 
            get => summoner; 
            set => summoner = value; 
        }

        public MainForm()
        {
            InitializeComponent();
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
                summonerMatchesListBox.Items.Add(match);
            }
        }

        private void summonerMatchesListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            GetMatchInformation();
        }
        void GetMatchInformation()
        {
            var selectedMatch = riotApi.MatchV5.GetMatch(MingweiSamuel.Camille.Enums.Region.Americas, summonerMatchesListBox.Text);
            foreach (KeyValuePair<string, object> entry in selectedMatch._AdditionalProperties)
            {
                if (entry.Key == "info")
                {
                    _matchInfo = (dynamic)JsonConvert.DeserializeObject<MatchInfo>(entry.Value.ToString());
                }
            }
            foreach (Participant participant in MatchInfo.Participants)
            {
                MatchInfo.SortParticipantsToTeams(participant);
                totalKills += participant.Kill;
            }

            foreach (Participant winningTeamMember in MatchInfo.winningTeam.TeamMembers)
            {
                winningTeamListBox.Items.Add(winningTeamMember.SummonerName);
            }
            foreach (Participant losingTeamMember in MatchInfo.losingTeam.TeamMembers)
            {
                losingTeamListBox.Items.Add(losingTeamMember.SummonerName);
            }
        }

        private void winningTeamListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            DisplayWinningTeamMemberInformation();
        }
        void DisplayWinningTeamMemberInformation()
        {
            
        }

        private void losingTeamListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            DisplayLosingTeamMemberInformation();
        }
        void DisplayLosingTeamMemberInformation()
        {

        }
    }
}
