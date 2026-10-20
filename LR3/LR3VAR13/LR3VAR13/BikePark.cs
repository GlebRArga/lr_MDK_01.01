using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3VAR13
{
    public class BikePark
    {
        private List<TransportItem> park_;

        public BikePark()
        {
            park_ = new List<TransportItem>();
        }

        public void AddTransport(TransportItem item)
        {
            park_.Add(item);
        }

        public List<TransportItem> GetPark()
        {
            return park_;
        }

        public TransportItem FindTransport(TransportType type)
        {
            foreach (TransportItem item in park_)
            {
                if (item.GetTranspType() == type)
                    return item;
            }
            return null;
        }
    }
        
}
