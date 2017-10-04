using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVM
{
    class DbUtilViewTeams
    {
        private SqlConnection _conn;
        private SqlCommand _comm;
        public string[] TeamArray;
        public void Open_Conn()
        {
            _conn = new SqlConnection(@"Data Source=INHYZDPC35;Initial Catalog=Vamsi_Gamidi_DB; User id =Sa; Password=sa; ");
            _conn.Open();
        }
        public string[] Execute()
        {
           var players=_comm.ExecuteReader() ;
             TeamArray = new string[21];
            int i = 0;
            while (players.Read())
            {
                TeamArray[i] = players.GetString(0);
                i++;
            }
           _conn.Close();
            return TeamArray;
        }

        public string[] Retreive_Team_details(string franchise)
        {
            if (franchise == null) throw new ArgumentNullException(nameof(franchise));
            Open_Conn();
            string retreivequery = $"Select Name from IPL where Franchise='{franchise}'";

            _comm = new SqlCommand(retreivequery, _conn);
            var results = Execute();
            return results;
        }
    }
}
