using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Data.SqlClient;
using System.Windows;
using MVVM;


namespace MVVM
{
    /// <summary>
    /// Connection should be from single class. 
    /// Retreiving and saving should also be done through single channel.
    /// </summary>
    public class DbUtil
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
            _comm.ExecuteNonQuery();
            _conn.Close();
            MessageBox.Show("Succesfully Inserted");
        }
        public void Enter_Player_Details(string table, object obj)
        {
            
            Open_Conn();
            string insertQuery = "";
            insertQuery = "INSERT INTO " + table;
            insertQuery += "  VALUES ";
            insertQuery += "(";
            insertQuery += String.Format("@Val1");
          
            Type fieldsType = obj.GetType();
             FieldInfo[] fields = fieldsType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            for (int i = 1; i < fields.Length; i++)
            {
                insertQuery += $",@Val{i + 1}";
            }
            insertQuery += ")";
            _comm = new SqlCommand(insertQuery, _conn);
            for (int i = 0; i < fields.Length; i++)
            {
                _comm.Parameters.AddWithValue($"@Val{i + 1}", fields[i].GetValue(obj));
            }
            Execute();
        }
    }

    
}
