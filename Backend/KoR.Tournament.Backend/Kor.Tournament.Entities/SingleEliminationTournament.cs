using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoR.Tournament.Entities
{
    public class SingleEliminationTournament: Tournament
    {
        public SingleEliminationTournament()
        {
            Bracket = new SingleEliminationBracket();
        }
    }
}
