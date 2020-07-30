using System.Data;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        // TODO - Make the CreatePrize method actually save to the databasw
        /// <summary>
        /// Saves the new Prize to the database
        /// </summary>
        /// <param name="model">The Prize info</param>
        /// <returns>The Prize information, including the unique Identifier</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnector(GlobalConfig.CnnString("Tournaments")))
            {
                 
            }

                
           
        }
    }
}
