using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocator
{
   public  class Client
   {
       public  IService Serve;

       public Client()
       {
           this.Serve = Locator.GetService();
         
       }

       public int Start(int a,int b)
       {
           Console.WriteLine("Service Started");
            this.Serve.Service1();
          return this.Serve.Service2(a,b);

        }
    }
}
