using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
   public class Client
    {
        private IService _service;

        public Client(IService service)
        {
            _service = service;
        }

        public Client()
        {
                             
        }

        //public IService Service
        //{
        //    set { _service = value; }
        //}

        public int Start(int a,int b)
        {
            Console.WriteLine("Service Started");
            _service.Serve();
            return _service.Serve2(a,b);
            
        }
    }
}
