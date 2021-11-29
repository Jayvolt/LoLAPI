using System;
using MingweiSamuel.Camille;
using MingweiSamuel.Camille.Enums;

namespace LoLAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            var riotApi = RiotApi.NewInstance("RGAPI-b9b8fb4e-8ced-4055-b218-1c0ec8203d7e");
            var summoner = riotApi.SummonerV4.GetBySummonerName(Region.NA, "ChickenMessiah");
            Console.WriteLine($"Summoner: {summoner.Name}   Level: {summoner.SummonerLevel}");
        }
    }
}
