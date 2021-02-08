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
                    Server = "localhost",
                    Port = 3306,
                    UserID = "matthieu",
                    Password = "mdp",
                    Database = "configuration"
                };
                string hello = null;

                using (MySqlConnection connection = new MySqlConnection(connectionBuilder.ToString()))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM description  WHERE Id = 1;", connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                                hello = reader.GetString("Description");
                        }
                    }
                }

                return hello;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                throw e;
            }












        }
    }
}
