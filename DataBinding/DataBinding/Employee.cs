using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding
{
   public class Employee
    {
        private string _fname;
        private string _lname;
        private string[] _role1;
        private string _desc;
     

        public string Fname
        {
            get { return _fname; }
            set { _fname = value; }
        }

        public string Lname
        {
            get { return _lname; }
            set { _lname = value; }
        }

        
        public string[] Role
        {
            get { return _role1; }
            set { _role1 = value; }
        }
        public string Desc  
        {
            get { return _desc; }
            set { _desc = value; }
        }

      
    }
}
