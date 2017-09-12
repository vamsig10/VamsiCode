using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LinqDemo
{
    class GenericClass<T>
    {
        public T Generic_Prop { get; set; }
        public T Result;
        public T GenericMethod(T Gen_Par)
        {
            Console.WriteLine(Gen_Par);
            return Gen_Par;
        }

        public T Result_Method(int Reg_Num)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=INHYZDPC35;Initial Catalog=Hsptl_VamsiG; User id =sa; Password=sa; ");
            conn.Open();
            string Select_Query = string.Format("select Marks from Marks where Reg_No={0}",Reg_Num);

            SqlCommand comm = new SqlCommand(Select_Query, conn);
            int Marks = Convert.ToInt16(comm.ExecuteScalar());
          //  Console.WriteLine(Convert.ToString(Marks));
           
            if (Marks < 35)
            {
              
                Result = (T)Convert.ChangeType("F", typeof(T));
                return Result;
            }
            else
            {
                Result = (T)Convert.ChangeType(Marks, typeof(T));
            }
            conn.Close();
            return Result;
        }
    }
}
