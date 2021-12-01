using System.Windows.Forms;
using MingweiSamuel.Camille;
using MingweiSamuel.Camille.Enums;
using MingweiSamuel.Camille.SummonerV4;
using LoLAPI;

namespace LoLAPIForm
{
    public partial class MainForm : Form
    {
        private string enteredAPIKey;
        private MatchInfo _matchInfo;
        private MatchInfo MatchInfo 
        { 
            get => _matchInfo; 
            set => _matchInfo = value; 
        }
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
            var riotApi = RiotApi.NewInstance(enteredAPIKey);
            summoner = riotApi.SummonerV4.GetBySummonerName(MingweiSamuel.Camille.Enums.Region.NA, enteredSummonerName);

            summonerNameTextBox.Text = summoner.Name;
            summonerLevelTextBox.Text = summoner.SummonerLevel.ToString();
        }
    }
}
