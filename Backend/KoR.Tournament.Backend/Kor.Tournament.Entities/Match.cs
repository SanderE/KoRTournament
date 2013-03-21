using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KoR.Tournament.Entities
{
    public class Match
    {
        public bool Completed { get; set; }
        public Tuple<Player, Player> Players { get; set; }
    }
}