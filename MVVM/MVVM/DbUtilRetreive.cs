using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MVVM
{
    /// <summary>
    /// should not be in the same project
    /// </summary>
    public class DbUtilRetreive
    {
        private SqlConnection _conn;
        private SqlCommand _comm;

        public DataDisplayModel DataDisplayModel { get; set; }

       // public ObservableCollection<PlayerModel> list { get; set; }
      

        private ObservableCollection<PlayerModel> Open_Conn()
        {
            _conn = new SqlConnection(@"Data Source=INHYZDPC35;Initial Catalog=Vamsi_Gamidi_DB; User id =sa; Password=sa;");
            _conn.Open();
            const string selectQuery = "select * from IPL";
            _comm = new SqlCommand(selectQuery, _conn);

            SqlDataReader reader = _comm.ExecuteReader();
             
            DataDisplayModel=new DataDisplayModel();
           DataDisplayModel.Data=new ObservableCollection<PlayerModel>();

            while (reader.Read())
            {
                var list1 = new PlayerModel()
                {
                    Id = reader.GetInt32(0), PlaName = reader.GetString(1),Age = reader.GetInt32(2),Role = reader.GetString(3), Franchise = reader.GetString(4)
                    
                };
                DataDisplayModel.Data.Add(list1);
             }
          //   Display(DataDisplayModel.Data);
            return DataDisplayModel.Data;
        }
        public void Execute()
        {
            SqlDataReader reader = _comm.ExecuteReader();
            if (reader.HasRows)
            {

                DataTable dt = new DataTable();
                dt.Load(reader);
              //  Display(dt);
            }                
                _conn.Close();
        }
        public ObservableCollection<PlayerModel> Retreive_Player_Details()
        {          
            var temp=Open_Conn();
            return temp;
        }

    }
}
