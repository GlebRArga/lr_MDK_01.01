using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritance
{
    internal class Product
    {
        protected string name_;
        protected double price_;
        protected int sold_;
        public virtual double GetDiscount()
        {
            return 0;
        }
        public string GetName()
        {
            return name_;
        }
        public void SetName(string name)
        {
            name_ = name;
        }
        public double GetPrice()
        {
            return price_;
        }
        public void SetPrice(double price)
        {
            price_ = price;
        }
        public int GetSold()
        {
            return sold_;
        }
        public void SetSold(int sold)
        {
            sold_ = sold;
        }
    }
}
