using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {

        /// <summary>
        /// Represents Placement
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Represents the prize place
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Represents the amount of the prize
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Represents the percentage of prize to be distributed
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
