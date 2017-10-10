using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirst
{
  public  class PlayerViewModel
  {
      private Dictionary<string, Tuple<string,string>> ChangesDictionary;
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
            get =>  _playerModel?.Name;
            set
            {


                if (_playerModel != null)
                {
                    RegisterChanges(_playerModel.Name,value,nameof(FullName));
                    _playerModel.Name = value;
                }
               

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
                if (_playerModel != null)
                {

                    RegisterChanges(_playerModel.Age.ToString(),value.ToString(),nameof(Age));
                    _playerModel.Age = value;
                }
               

            }
        }

        public string Role
        {
            get => _playerModel?.Role;
            set
            {


                if (_playerModel != null)
                {
                    RegisterChanges(_playerModel.Role, value,nameof(Role));

                    _playerModel.Role = value;
                }

               
            }
        }

        private void RegisterChanges(string oldValue, string newValue,string prop)
        {
            if
               ( oldValue != null && oldValue != "0")
            { 
                if (ChangesDictionary == null)
                {
                    ChangesDictionary = new Dictionary<string, Tuple<string, string>>();

                }
                if (ChangesDictionary != null && !ChangesDictionary.ContainsKey(prop))
                {
                    ChangesDictionary.Add(prop, new Tuple<string, string>(oldValue, newValue));

                }
                else
                {
                    if (ChangesDictionary[prop].Item1 == newValue)
                    {
                        ChangesDictionary.Remove(prop);
                    }
                }
            }
        }

        public string Franchise
        {
            get => _playerModel?.Franchise;
            set
            {
                if (_playerModel != null)
                {
                    RegisterChanges(_playerModel.Franchise,value,nameof(Franchise));
                    _playerModel.Franchise = value;
                }
               
            }
        }

        public PlayerViewModel(PlayerViewModel details)
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
            PlayerInsert insert = new PlayerInsert(_playerModel);
        }
        
        public PlayerViewModel()
        {
            _playerModel=new IPL();
        }


        public bool IsChanged()
        {
            if (ChangesDictionary == null||ChangesDictionary.Keys.Count==0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
