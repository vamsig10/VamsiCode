using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM
{
   public class FranchiseViewModel
    {
        public FranchiseModel _franchiseModel;

        public FranchiseModel Model
        {
            get { return _franchiseModel; }
        }

        public int Id
        {
            get => _franchiseModel.Id;
            set => _franchiseModel.Id = value;
        }

        public string Owner
        {
            // get { return string.Concat(_playerModel.PlaName, _playerModel.Role); }
            get => _franchiseModel.Owner;
            set => _franchiseModel.Owner = value;
        }

      

        public string Franchise
        {
            get => _franchiseModel.Franchise;
            set => _franchiseModel.Franchise = value;
        }

        public FranchiseViewModel(FranchiseModel details)
        {
            _franchiseModel = details;


        }
        public void Save()
        {
            // db util cannot be in view as per MVVM
            DbUtil util = new DbUtil();
            util.Enter_Player_Details("Franchise", _franchiseModel);
        }
    }
}
