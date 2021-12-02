using MingweiSamuel.Camille.MatchV5;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoLAPI
{
    public class Game
    {
        public List<Match> Matches { get; set; }

        public Game()
        {
            Matches = new List<Match>();
        }
    }
}
