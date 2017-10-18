using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
   public interface IService
    {
        void Serve();
        int Serve2(int a,int b);

    }
}
