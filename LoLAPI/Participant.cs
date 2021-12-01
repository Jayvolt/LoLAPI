using Newtonsoft.Json;

namespace LoLAPI
{
    public class Participant
    {
        [JsonProperty(PropertyName = "championName")]
        public string ChampionName { get; private set; }
        [JsonProperty(PropertyName = "summonerName")]
        public string SummonerName { get; private set; }
        [JsonProperty(PropertyName = "summonerLevel")]
        public int SummonerLevel { get; private set; }
        [JsonProperty(PropertyName = "deaths")]
        public int Deaths { get; private set; }
        [JsonProperty(PropertyName = "kills")]
        public int Kill { get; private set; }
        [JsonProperty(PropertyName = "teamPosition")]
        public string TeamPosition { get; private set; }
        [JsonProperty(PropertyName = "totalDamageDealt")]
        public int TotalDamageDealt { get; private set; }
        [JsonProperty(PropertyName = "win")]
        public bool Win { get; private set; }

    }
}
