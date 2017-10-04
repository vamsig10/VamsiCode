using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM
{
    public class PlayerModel
    {
        private int _id;
        private string _plaName;
        private int _age;
        private string _role;
        private string _franchise;

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string PlaName
        {
            get => _plaName;
            set => _plaName = value;
        }

        public int Age
        {
            get => _age;
            set => _age = value;
        }

        public string Role
        {
            get => _role;
            set => _role = value;
        }

        public string Franchise
        {
            get => _franchise;
            set => _franchise = value;
        }
    }
}
