using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocator
{
   public static class Locator
    {
        public  static IService Serve { get; set; }

        public static IService GetService()
        {
            Serve=new Service();
            return Serve;

        }
    }
}
