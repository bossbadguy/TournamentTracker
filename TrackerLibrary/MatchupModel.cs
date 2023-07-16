using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// Represents matchup
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// Represents the winner of the matchup
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Represents the winner of the matchup
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
