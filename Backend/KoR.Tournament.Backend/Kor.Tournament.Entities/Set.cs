using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KoR.Tournament.Entities
{
    public class Set
    {
        public int BestOf { get; set; }
        public List<Match> Matches;
        public Tuple<Player, Player> Players;
    }
}