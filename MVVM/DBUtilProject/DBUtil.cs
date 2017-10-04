using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;
using MVVM;


namespace MVVM
{
    public class DBUtil
    {       
        SqlConnection _conn;
        SqlCommand _comm;
        public void Open_Conn()
        {
          _conn   = new SqlConnection(@"Data Source=INHYZDPC35;Initial Catalog=Vamsi_Gamidi_DB; User id =Sa; Password=sa; ");
          _conn.Open();
        }
        public void Execute(string insertQuery)
        {
            _comm.ExecuteNonQuery();
            _conn.Close();
            MessageBox.Show("Succesfully Inserted");
        }
        

        //PlayerModel is a concrete type. It should be generic
        public void Enter_Player_Details(string table,object obj)
        {          
            Open_Conn();
            string Insert_Query = "INSERT INTO " + table + "  VALUES (@Val1,@Val2,@Val3,@Val4,@Val5)";
            _comm = new SqlCommand(Insert_Query, _conn);
            //foreach (var VARIABLE in parameters         {
            //    _comm.Parameters.AddWithValue("@Val1", obj.Id);
            //}
            //_comm.Parameters.AddWithValue("@Val1", obj.Id);
            //_comm.Parameters.AddWithValue("@Val2", obj.PlaName);
            //_comm.Parameters.AddWithValue("@Val3", obj.Age);
            //_comm.Parameters.AddWithValue("@Val4", obj.Role);
            //_comm.Parameters.AddWithValue("@Val5", obj.Franchise);

            Execute(Insert_Query);
        }
    }
}
