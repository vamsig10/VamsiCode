using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DBFirst
{
    public class SaveChanges
    {
        public ObservableCollection<PlayerViewModel> Coll;


        public SaveChanges(ObservableCollection<PlayerViewModel> coll)
        {
            Coll = new ObservableCollection<PlayerViewModel>();
            Coll = coll;

            using (var ctx = new Vamsi_Gamidi_DBEntities())
            {
                using (var con = new EntityConnection("name=Vamsi_Gamidi_DBEntities"))
                {
                    con.Open();
                    EntityCommand cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT VALUE st FROM Vamsi_Gamidi_DBEntities.IPLs as st";
                    using (EntityDataReader rdr =
                        cmd.ExecuteReader(CommandBehavior.SequentialAccess | CommandBehavior.CloseConnection))
                    {
                        while (rdr.Read())
                        {
                            var list = new PlayerViewModel()
                            {
                                Id = rdr.GetInt32(0),
                                FullName = rdr.GetString(1),
                                Age = rdr.GetInt32(2),
                                Role = rdr.GetString(3),
                                Franchise = rdr.GetString(4)
                            };
                            coll.Add(list);
                        }

                    }

                    ctx.Configuration.AutoDetectChangesEnabled = true;
                }


            }
        }

     

        public void SaveToDb()
        {
            using (var ctx = new Vamsi_Gamidi_DBEntities())
            {
                foreach (var item in Coll)
                {
                    if (item.IsChanged())
                    {
                        ctx.Entry(item._playerModel).State = EntityState.Modified;
                    }
                }
                var changes = ctx.SaveChanges();
                MessageBox.Show(changes.ToString());
            }
        }
    }
}
