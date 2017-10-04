using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVM
{
    public class PlayerViewModel
    {

        public PlayerModel _playerModel;

        public PlayerModel Model
        {
            get { return _playerModel; }
        }

        public int Id
        {
            get => _playerModel.Id;
            set => _playerModel.Id = value;
        }

        public string FullName
        {
            // get { return string.Concat(_playerModel.PlaName, _playerModel.Role); }
            get => _playerModel.PlaName;
            set => _playerModel.PlaName = value;
        }

        public int Age
        {
            get => _playerModel.Age;
            set => _playerModel.Age = value;
        }

        public string Role
        {
            get => _playerModel.Role;
            set => _playerModel.Role = value;
        }

        public string Franchise
        {
            get => _playerModel.Franchise;
            set => _playerModel.Franchise = value;
        }

        public PlayerViewModel(PlayerModel details)
        {
            _playerModel = details;

            
        }
        public void Save()
        {
            DbUtil util = new DbUtil();
            util.Enter_Player_Details("IPL",_playerModel );
        }
    }
}
