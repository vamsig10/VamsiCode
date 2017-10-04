using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Collections;

namespace Collections
{
    public class UserDetails
    {

        public int UserId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }

        public long PhoneNo { get; set; }
        public int? Pid { get; set; }

        public List<UserDetails> Children { get; set; }
    }



}
