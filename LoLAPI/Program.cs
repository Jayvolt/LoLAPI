using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using MingweiSamuel.Camille;
using MingweiSamuel.Camille.SummonerV4;
using MingweiSamuel.Camille.Enums;

namespace LoLAPI
{
    class Program
    {
        public static int totalKills;
        
        static void Main(string[] args)
        {
            var riotApi = RiotApi.NewInstance("RGAPI-7accb838-d511-4c63-a8cb-92342d6f9960");
            Summoner summoner = riotApi.SummonerV4.GetBySummonerName(Region.NA, "DonutBlanket");
            Console.WriteLine($"Summoner: {summoner.Name}   Level: {summoner.SummonerLevel}");

            var matches = riotApi.MatchV5.GetMatchIdsByPUUID(Region.Americas, summoner.Puuid);
            var recentMatch = matches[0];
            var matchDto = riotApi.MatchV5.GetMatch(Region.Americas, recentMatch);
            foreach (KeyValuePair<string, object> entry in matchDto._AdditionalProperties)
            {
                if (entry.Key == "info")
                {
                    var matchInfo = (dynamic)JsonConvert.DeserializeObject<MatchInfo>(entry.Value.ToString());
                    Console.WriteLine($"=============\nMost Recent Match Info:\nMatch Duration in Seconds: {matchInfo.GameDuration},\nGame Mode: {matchInfo.GameMode}");
                }
            }
            //foreach (Participant participant in MatchInfo.Participants)
            //{
            //    MatchInfo.SortParticipantsToTeams(participant);
            //    totalKills += participant.Kill;
            //}
            //Console.WriteLine($"Total Kills in Match: {totalKills}");

            //Console.WriteLine("=============\nMatch Participants:");
            //Console.WriteLine("WinningTeam:");
            //foreach (Participant winningTeamMember in MatchInfo.winningTeam.TeamMembers)
            //{
            //    Console.WriteLine($"Summoner Name: {winningTeamMember.SummonerName},\nSummoner Level: {winningTeamMember.SummonerLevel}\nChampion Name: {winningTeamMember.ChampionName},\nChampion Total Damage Dealt: {winningTeamMember.TotalDamageDealt},\n" +
            //        $"Champion Kills: {winningTeamMember.Kill},\nChampion Deaths: {winningTeamMember.Deaths},\nTeam Position: {winningTeamMember.TeamPosition},\nWin:{winningTeamMember.Win}");
            //}            
            //Console.WriteLine("LosingTeam:");
            //foreach (Participant losingTeamMember in MatchInfo.losingTeam.TeamMembers)
            //{
            //    Console.WriteLine($"Summoner Name: {losingTeamMember.SummonerName},\nSummoner Level: {losingTeamMember.SummonerLevel}\nChampion Name: {losingTeamMember.ChampionName},\nChampion Total Damage Dealt: {losingTeamMember.TotalDamageDealt},\n" +
            //        $"Champion Kills: {losingTeamMember.Kill},\nChampion Deaths: {losingTeamMember.Deaths},\nTeam Position: {losingTeamMember.TeamPosition},\nWin:{losingTeamMember.Win}");
            //}
        }
    }
}
