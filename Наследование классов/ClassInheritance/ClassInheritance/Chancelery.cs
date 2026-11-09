using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritance
{
    class Chancelery:Product
    {
        public override double GetDiscount()
        {
            if (base.sold_ > 20 && base.sold_ < 100)
            {
                return 10;
            }

            if (base.sold_ > 150 && base.sold_ < 200)
            {
                return 30;
            }
            if (base.sold_ >= 300)
            {
                return 50;

            }
            return base.GetDiscount();
        }
    }
}
