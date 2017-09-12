using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=INHYZDPC35;Initial Catalog=Hsptl_VamsiG; User id =Sa; Password=sa; ");
            conn.Open();

            Players[] players = new Players[4];

            for (int i = 0; i < 4; ++i)
            {
                players[i] = new Players();
            }


            players[0].Player_ID = 1;
            players[0].Player_Name = "Rohit";
            players[0].Player_Jersey_No = 45;

            players[1].Player_ID = 2;
            players[1].Player_Name = "Dhawan";
            players[1].Player_Jersey_No = 12;

            players[2].Player_ID = 3;
            players[2].Player_Name = "Virat";
            players[2].Player_Jersey_No = 18;
           
            players[3].Player_ID = 4;
            players[3].Player_Name = "Bhuvi";
            players[3].Player_Jersey_No = 22;

            var Players_ID = from player in players where player.Player_ID >= 0 select player.Player_ID;
            var Players_Names = players.Where(p=>p.Player_ID>=0).Select(p => p.Player_Name).OrderBy(p=>p.Length) ;

            var Players_ID1 = players.Select(p => p.Player_Name).Take(2);
            var Players_ID2 = players.Select(p => p.Player_Name).Skip(2);
            var Players_ID3 = players.Select(p => p.Player_Name).Reverse();
            var count = players.Count();
            Console.WriteLine(count);
            Console.WriteLine();


            foreach (var player in Players_ID)
            {
                Console.WriteLine(player);
            }
            Console.WriteLine();

            foreach (var player in Players_Names)
            {
                Console.WriteLine(player);
            }

            Console.WriteLine();


            foreach (var player in Players_ID1)
            {
                Console.WriteLine(player);
            }
            Console.WriteLine();

            foreach (var player in Players_ID2)
            {
                Console.WriteLine(player);
            }
            Console.WriteLine();

            foreach (var player in Players_ID3)
            {
                Console.WriteLine(player);
            }
            Console.WriteLine();


            string Insert_Query = "INSERT INTO Player_Details  VALUES (@Val1,@Val2,@Val3)";
            for (int i = 0; i < 4; ++i)
            {

                SqlCommand comm = new SqlCommand(Insert_Query, conn);

                comm.Parameters.AddWithValue("@Val1", players[i].Player_ID);
                comm.Parameters.AddWithValue("@Val2", players[i].Player_Name);
                comm.Parameters.AddWithValue("@Val3", players[i].Player_Jersey_No);

             //   comm.ExecuteNonQuery();
            }
            
            GenericClass<string> generic_class = new GenericClass<string>();
            generic_class.GenericMethod("Gen Class");
        
            conn.Close();

            //Console.WriteLine("Enter the Reg Num");
            //int reg_num;
            //if(int.TryParse(Console.ReadLine(), out reg_num))
            //{
            //    var Result = generic_class.Result_Method(reg_num);
            //    Console.WriteLine(Convert.ToString(Result));
            //}

        

            Console.ReadLine();
        }
    }
}
