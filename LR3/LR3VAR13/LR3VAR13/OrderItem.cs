using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3VAR13
{
    public class OrderItem
    {
        private TransportType type_;
        private int quantity_;

        public OrderItem(TransportType type, int quantity)
        {
            type_ = type;
            quantity_ = quantity;
        }
        public TransportType GetType()
        {
            return type_;
        }
        public int GetQuantity()
        {
            return quantity_;
        }

    }
}
