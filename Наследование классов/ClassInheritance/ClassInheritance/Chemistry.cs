using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritance
{
    class Chemistry:Product
    {
        public override double GetDiscount()
        {
            if (base.sold_ > 5 && base.sold_ < 10)
            {
                return 15;
            }
            if (base.sold_ >= 10)
            {
                return 25;
            }
            return base.GetDiscount();

        }
    }
}
