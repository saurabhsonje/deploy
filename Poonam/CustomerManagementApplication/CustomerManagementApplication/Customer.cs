using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementApplication
{
    class Customer : IAddable

    {
        private int _CustType;

        public int CustType
        {
            get { return _CustType; }
            set { _CustType = value; }
        }

       

        public virtual double getDiscount()
        {
            return 10;
        }
    }
}
