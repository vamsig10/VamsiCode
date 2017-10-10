using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirst
{
   public  class FranchiseViewModel
    {
        
        public Franchise FranchiseModel;
        

        public Franchise Model => FranchiseModel;

        
        public  int Id
        {
            get
            {
                if (FranchiseModel != null) return FranchiseModel.Id;
                else return 0;
            }
            set
            {
                if (FranchiseModel != null) FranchiseModel.Id = value;
            }
        }

        public string Owner
        {
            get
            {
                if (FranchiseModel != null) return FranchiseModel.Owner;
                else return null;



            }
            set
            {
                if (FranchiseModel != null) FranchiseModel.Owner = value;
            }
        }

        public string Franchise1
        {
            get
            {
                if (FranchiseModel != null) return FranchiseModel.Franchise1;
                else return null;

            }
            set
            {
                if (FranchiseModel != null) FranchiseModel.Franchise1 = value;
            }
        }


        public FranchiseViewModel()
        {
            FranchiseModel=new Franchise();
        }

        public  FranchiseViewModel(FranchiseViewModel obj)
        {
            Franchise a=new Franchise();
            a.Id = obj.Id;
            a.Franchise1 = obj.Franchise1;
            a.Owner = obj.Owner;
            FranchiseModel = a;

            FranchiseInsert Insert=new FranchiseInsert(FranchiseModel);
        }
    }
}
