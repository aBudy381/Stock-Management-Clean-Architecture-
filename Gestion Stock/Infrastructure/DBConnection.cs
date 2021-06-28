using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DAOAccess.DAO.DBConnection
{
    public class DBConnection
    {
        private static DBConnection _DBInstance;
        public MySqlConnection _maConnexion;
        private DBConnection()
        {

        }
        public static DBConnection GetDBInstance(String ConnectionString)
        {
            if (_DBInstance == null)
            {
                try
                {
                    _DBInstance = new DBConnection();
                    _DBInstance._maConnexion = new MySqlConnection(ConnectionString);
                    _DBInstance._maConnexion.Open();
                }
                catch (MySqlException expp)
                {

                }
            }
            return _DBInstance;

        }
    }
}
