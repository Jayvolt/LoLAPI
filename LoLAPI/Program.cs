using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using MingweiSamuel.Camille;
using MingweiSamuel.Camille.Enums;

namespace LoLAPI
{
    class Program
    {
        public static int totalKills;
        static void Main(string[] args)
        {
            var riotApi = RiotApi.NewInstance("RGAPI-b9b8fb4e-8ced-4055-b218-1c0ec8203d7e");
            var summoner = riotApi.SummonerV4.GetBySummonerName(Region.NA, "DonutBlanket");
            Console.WriteLine($"Summoner: {summoner.Name}   Level: {summoner.SummonerLevel}");

            var matches = riotApi.MatchV5.GetMatchIdsByPUUID(Region.Americas, summoner.Puuid);
            var recentMatch = matches[0];
            var matchDto = riotApi.MatchV5.GetMatch(Region.Americas, recentMatch);
            foreach (KeyValuePair<string, object> entry in matchDto._AdditionalProperties)
            {
                    if (entry.Key == "info")
                    {
                        var matchInfo = (dynamic)JsonConvert.DeserializeObject<MatchInfo>(entry.Value.ToString());
                    }
            }

            foreach (Participant participant in MatchInfo.Participants)
            {
                MatchInfo.SortParticipantsToTeams(participant);
                if (participant.Win == true)
                {
                    Console.WriteLine($"Champion Name: {participant.ChampionName},\nChampion Total Damage Dealt: {participant.TotalDamageDealt},\n" +
                        $"Champion Kills: {participant.Kill},\nChampion Deaths: {participant.Deaths},\nTeam Position: {participant.TeamPosition},\nWin:{participant.Win}");
                }
                else
                {
                    Console.WriteLine($"Champion Name: {participant.ChampionName},\nChampion Total Damage Dealt: {participant.TotalDamageDealt},\n" +
                        $"Champion Kills: {participant.Kill},\nChampion Deaths: {participant.Deaths},\nTeam Position: {participant.TeamPosition},\nWin:{participant.Win}");
                }
                

                totalKills += participant.Kill;
            }


            Console.WriteLine($"Most Recent Match Total Kills: {totalKills}");
        }
    }
}
