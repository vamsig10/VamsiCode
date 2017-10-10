using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirst
{
   public class DisplayViewModel
    {
        public IPL _playerModel;

        public IPL Model
        {
            get { return _playerModel; }
        }

        public int Id
        {
            get
            {
                if (_playerModel != null) return _playerModel.Id;
                else return 0;
            }
            set
            {
                if (_playerModel != null) _playerModel.Id = value;
            }
        }

        public string FullName
        {
            get
            {
                return _playerModel?.Name;
            }
            set
            {
                if (_playerModel != null) _playerModel.Name = value;
            }
        }

        public int Age
        {
            get
            {
                if (_playerModel != null) return _playerModel.Age;
                else return 0;

            }
            set
            {
                if (_playerModel != null) _playerModel.Age = value;
            }
        }

        public string Role
        {
            get
            {
                if (_playerModel != null) return _playerModel.Role;
                return null;
            }
            set
            {
                if (_playerModel != null) _playerModel.Role = value;
            }
        }

        public string Franchise
        {
            get
            {
                if (_playerModel != null) return _playerModel.Franchise;
                return null;

            }
            set
            {
                if (_playerModel != null) _playerModel.Franchise = value;
            }
        }

        public DisplayViewModel(DisplayViewModel details)
        {
            IPL a = new IPL
            {
                Id = details.Id,
                Name = details.FullName,
                Role = details.Role,
                Franchise = details.Franchise,
                Age = details.Age
            };

            _playerModel = a;
            PlayerInsert Insert = new PlayerInsert(_playerModel);



        }

        public DisplayViewModel()
        {
            _playerModel = new IPL();
        }
    }
}
