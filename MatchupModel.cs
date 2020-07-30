using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Repersents  one match in the tournament.
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// The Set of teams that were involved in this match.
        /// </summary>
       // public List<MatupEntryModels> Entries { get; set; } = new List<MatupEntryModels>();
        /// <summary>
        /// The winnter of the match.
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Which round this match is a part of.
        /// </summary>
        public int MatchupRound { get; set; }

    }
}
