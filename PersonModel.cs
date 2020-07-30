using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Repersents one person.
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// The persons first name.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// The persons last name.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// The persons primary email address.
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// The primary cell phone number of the person.
        /// </summary>
        public string CellphoneNumer { get; set; }
    }
}
