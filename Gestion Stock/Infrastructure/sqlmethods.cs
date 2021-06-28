using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DAOAccess
{
    public class sqlmethods
    {
        public static String getMaxId(String tableName, String idTable, MySqlConnection connexion)
        {
            MySqlDataReader reader = null;
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connexion;
                cmd.CommandText = "select ifnull(max(" + idTable + "),0) from " + tableName;
                reader = cmd.ExecuteReader();
                String id = "";
                if (reader.Read())
                {
                    id = reader.GetString(0);
                }
                reader.Close();
                return id;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (reader != null && !reader.IsClosed) reader.Close();
            }
        }

    }
}
