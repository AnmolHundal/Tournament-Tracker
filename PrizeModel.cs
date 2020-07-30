using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Repersents the Tournament rules
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// This unique identifier for the prize.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Repersents the placing a person can get in the tournament.
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Repersents the name of that placing 
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Repersents the amount of prize money to be had.
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Repersents the precentage of the money each place gets.
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }
        public PrizeModel(string placeName, string placeNamber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNamber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }

    }
}
