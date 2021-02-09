using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationPosteDevCSHARP.Models
{
    public class DateBaseHelper
    {
        public static  string Mdu ()
        {

            try
            {
                MySqlConnectionStringBuilder connectionBuilder = new MySqlConnectionStringBuilder
                {
                    Database = "configuration",
                    Server = "localhost",
                    // local 
                    //Port = 3307,
                    //UserID = "root",
                    //Password = "",

                    // serveur 

                    Port = 3306,
                    UserID = "matthieu",
                    Password = "mdp"

                };
                string mdu = null;

                using (MySqlConnection connection = new MySqlConnection(connectionBuilder.ToString()))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM description  WHERE Id = 1;", connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                                mdu = reader.GetString("Description");
                        }
                    }
                }

                return mdu;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                throw e;
            }
        }
    }
}
