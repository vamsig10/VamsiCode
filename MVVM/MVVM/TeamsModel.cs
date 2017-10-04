using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM
{
   public class TeamsModel
    {
        private string[] _names;

        public string[] Names
        {
            get { return _names; }
            set { _names = value; }
        }
    }
}
