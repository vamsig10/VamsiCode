using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data.SqlClient;

namespace MVVM
{
    class ViewModelTeams
    {
        private SqlConnection _conn;
        private SqlCommand _comm;
        public void Open_Conn()
        {
            _conn = new SqlConnection(@"Data Source=INHYZDPC35;Initial Catalog=Vamsi_Gamidi_DB; User id =Sa; Password=sa; ");
            _conn.Open();
        }
        public void Execute()
        {
            var Players=_comm.ExecuteScalar() ;
            _conn.Close();
        }

        public void Retreive_Player_details(string franchise)
        {
            if (franchise == null) throw new ArgumentNullException(nameof(franchise));
            Open_Conn();
            string retreivequery = $"Select Name from IPL where Franchise={franchise}";
            _comm = new SqlCommand(retreivequery, _conn);
          

            Execute();
        }
    }
}
