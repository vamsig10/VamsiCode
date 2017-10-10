using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DBFirst
{
    public class FranchiseInsert
    {
        private Franchise _franchiseModel;

        public FranchiseInsert(Franchise franchiseModel)
        {
            this._franchiseModel = franchiseModel;
            var ctx = new Vamsi_Gamidi_DBEntities();
               ctx.Franchises.Add(franchiseModel);
              ctx.SaveChanges();
               MessageBox.Show("Inserted");
        }

    }
}
