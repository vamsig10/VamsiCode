using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;

namespace MvvmDemo
{
    

    class DbUtil:MainWindow
    {
        Model model=new Model();
        
        private SqlConnection connection;
        private SqlCommand command;
     //   public List<Model> Emp { get; set; }
        public SqlDataReader Dr { get; set; }
        //public SqlDataReader Dr;

        public void OpenConn()
        {
            connection = new SqlConnection(@"Data Source=INHYZDPC35;Initial Catalog=Vamsi_Gamidi_DB; User id =Sa; Password=sa; ");
            connection.Open();
        }

        public void Execute(string selectQuery)
        {
           Dr =command.ExecuteReader();
            Dr.Read();
            //EmpGrid.ItemsSource = Dr;
           

            
            //Salary.Text = Dr.GetInt16(0).ToString();
           // Dr.Close();
            connection.Close();
        }

        public  void SelectDetails()
        {
            OpenConn();
            // int a = 1; 
            //  string selectQuery = $"select * from Employee where Id={a}";
            string selectQuery = "select * from Employee";
            command =new SqlCommand(selectQuery,connection); 
            Execute(selectQuery);
        }

    }
}
