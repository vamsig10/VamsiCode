using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;


namespace MVVM
{
    class ViewModel: Player_Details
    {       
        SqlConnection _conn;
        SqlCommand _comm;
        public void Open_Conn()
        {
          _conn   = new SqlConnection(@"Data Source=INHYZDPC35;Initial Catalog=Vamsi_Gamidi_DB; User id =Sa; Password=sa; ");
          _conn.Open();
        }
        public void Execute(string Insert_Query)
        {
            _comm.ExecuteNonQuery();
            _conn.Close();
            MessageBox.Show("Succesfully Inserted");
        }
        
        public void Enter_Player_Details(Player_Details obj)
        {          
            Open_Conn();
            string Insert_Query = "INSERT INTO IPL  VALUES (@Val1,@Val2,@Val3,@Val4,@Val5)";
            _comm = new SqlCommand(Insert_Query, _conn);
            _comm.Parameters.AddWithValue("@Val1", obj.Id);
            _comm.Parameters.AddWithValue("@Val2", obj.PlaName);
            _comm.Parameters.AddWithValue("@Val3", obj.Age);
            _comm.Parameters.AddWithValue("@Val4", obj.Role);
            _comm.Parameters.AddWithValue("@Val5", obj.Franchise);

            Execute(Insert_Query);
        }
    }
}
