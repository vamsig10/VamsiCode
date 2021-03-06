﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows;

namespace DBFirst
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public FranchiseViewModel obj=new FranchiseViewModel();
       

      //  FranchiseViewModel obj = new FranchiseViewModel();

        public MainWindow()
        {
            InitializeComponent();
            
            using (var ctx = new Vamsi_Gamidi_DBEntities())
            {
                Franchise franchise1 = new Franchise() { Id = 5, Franchise1 = "CSK", Owner = "Srinivasan" };
                //ctx.Franchises.Add(franchise1);
                ctx.Configuration.AutoDetectChangesEnabled = true;
                var query = from ipl in ctx.IPLs where ipl.Role == "Batsman" select ipl.Name;
                var player = query.FirstOrDefault() ?? throw new ArgumentNullException($"query.FirstOrDefault()");
              //  MessageBox.Show(player.ToString());

                string sqlquery = "select value st from Vamsi_Gamidi_DBEntities.IPLs" + " as st where st.Id==1";
                var objctx = (ctx as IObjectContextAdapter).ObjectContext;
                ObjectQuery<IPL> ipl1 = objctx.CreateQuery<IPL>(sqlquery);
                IPL newStudent = ipl1.FirstOrDefault<IPL>() ?? throw new ArgumentNullException($"ipl1.FirstOrDefault<IPL>()");
              //  MessageBox.Show(newStudent.Role);

                var player1 = ctx.IPLs.Find(1);
                var entry = ctx.Entry(player1);
              //  MessageBox.Show(entry.Entity.GetType().Name);
               // MessageBox.Show(entry.State.ToString());

                Franchise franchise2 = new Franchise() { Id = 6, Franchise1 = "RCB", Owner = "Malya" };
                //ctx.Franchises.Add(franchise2);
               // ctx.SaveChanges();
            }

            using (var con = new EntityConnection("name=Vamsi_Gamidi_DBEntities"))
            {
                con.Open();
                EntityCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT VALUE st FROM Vamsi_Gamidi_DBEntities.IPLs as st where st.Role=='Batsman'";
                Dictionary<int, string> dict = new Dictionary<int, string>();
                using (EntityDataReader rdr = cmd.ExecuteReader(CommandBehavior.SequentialAccess | CommandBehavior.CloseConnection))
                {
                    while (rdr.Read())
                    {
                        int a = rdr.GetInt32(0);
                        var b = rdr.GetString(1);
                        dict.Add(a, b);
                    }
                }
            }

            DataContext = obj;
            
            //  obj = new FranchiseViewModel(obj);

        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
           
            FranchiseViewModel a =new FranchiseViewModel(obj);
      
            
            
        }
    }
}