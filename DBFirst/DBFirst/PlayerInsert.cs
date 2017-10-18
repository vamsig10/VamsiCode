using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DBFirst
{
  public class PlayerInsert: IPlayerInsert
    {
        private IPL _playerModel;

        public void PlayerInsertMethod(IPL playerModel)
        {
            this._playerModel = playerModel;
            var ctx = new Vamsi_Gamidi_DBEntities();
            ctx.IPLs.Add(playerModel);
            ctx.SaveChanges();
            MessageBox.Show("Inserted");
        }
    }
}
