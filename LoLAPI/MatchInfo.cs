using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace LoLAPI
{
    public class MatchInfo
    {
        [JsonProperty(Order = 0)]
        public long GameCreation { get; private set; }
        [JsonProperty(Order = 1)]
        public long GameDuration { get; private set; }
        [JsonProperty(Order = 2)]
        public long GameEndTime { get; private set; }
        [JsonProperty(Order = 3)]
        public long GameID { get; private set; }
        [JsonProperty(Order = 4)]
        public string GameMode { get; private set; }
        [JsonProperty(Order = 5)]
        public string GameName { get; private set; }
        [JsonProperty(Order = 6)]
        public long GameStartTime { get; private set; }
        [JsonProperty(Order = 7)]
        public string GameType { get; private set; }
        [JsonProperty(Order = 8)]
        public string GameVersion { get; private set; }
        [JsonProperty(Order = 9)]
        public int MapID { get; private set; }
        [JsonProperty(Order = 10)]
        public static List<Participant> Participants { get; private set; }
        [JsonProperty(Order = 11)]
        public string PlatformID { get; private set; }
        [JsonProperty(Order = 12)]
        public int QueueID { get; private set; }
        [JsonProperty(Order = 13)]
        public static List<Team> Teams { get; private set; }
        [JsonProperty(Order = 14)]
        public string TournamentCode { get; private set; }

        public static void SortParticipantsToTeams(Participant participant)
        {
            foreach (Team team in Teams)
            {
                if (team.Win)
                {
                    if (participant.Win == true)
                    {
                        team.TeamMembers.Add(participant);
                    }
                }
                else
                {
                    team.TeamMembers.Add(participant);
                }
            }
        }
    }
}
