using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DBFirst
{
    public class DbInsert
    {
        public DbInsert(object obj,string str)
        {
            var ctx = new Vamsi_Gamidi_DBEntities();
            Type fieldsType = obj.GetType();
            
            ctx.SaveChanges();
            MessageBox.Show("Inserted");
        }
    }
}
