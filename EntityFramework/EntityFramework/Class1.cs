using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class Class1:DbContext
    {
        public Class1():base()
        {
            
        }
       // public DbSet<Class2> Class2S { get; set; }
        public DbSet<Class3> Class3S { get; set; }

    }
}
