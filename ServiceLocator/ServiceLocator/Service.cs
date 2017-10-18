using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocator
{
    public class Service : IService
    {
      
        public void Service1()
        {
            Console.WriteLine("Service1 Offered");
        }
        public int Service2(int a,int b)
        {

            Console.WriteLine("Service2 Offered");
            return (a + b);
        }
    }
}
