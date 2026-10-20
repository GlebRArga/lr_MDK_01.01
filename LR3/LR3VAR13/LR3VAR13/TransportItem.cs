using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3VAR13
{
    public class TransportItem
    {
        private TransportType type_;
        private string name_;
        private int price_;
        private int amount_;

        public TransportItem(TransportType type, string name, int price, int amount)
        {
            type_ = type;
            name_ = name;
            price_ = price;
            amount_ = amount;
        }

        public TransportType GetTranspType()
        {
            return type_;
        }
        public string GetName()
        {
            return name_;
        }
        public int GetPrice()
        {
            return price_;
        }
        public int GetAmount()
        {
            return amount_;
        }
    }
}
