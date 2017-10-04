using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM
{
  public  class FranchiseModel
    {
        private int _id;
        private string _owner;
        private string _franchise;

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Owner
        {
            get => _owner;
            set => _owner = value;
        }

        public string Franchise
        {
            get => _franchise;
            set => _franchise = value;
        }

    }
}
