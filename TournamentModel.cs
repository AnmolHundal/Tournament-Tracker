using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models

{
    /// <summary>
    /// Repersents the Tournamet UI stuff
    /// </summary>
    public class TournamentModel
    {
        /// <summary>
        /// This is the name of the tournament 
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// repersent the amount of money a person uses to enter the tournament
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Repersents the number of teams and there names 
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
