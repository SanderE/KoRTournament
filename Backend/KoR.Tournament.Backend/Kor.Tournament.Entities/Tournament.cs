using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KoR.Tournament.Entities
{
    public abstract class Tournament
    {
        public Tournament ParentTournament { get; set; }

        public List<Player> Participants { get; set; }
        public List<Map> MapPool { get; set; }
        public string Name { get; set; }
        public Bracket Bracket { get; set; }
    }
}