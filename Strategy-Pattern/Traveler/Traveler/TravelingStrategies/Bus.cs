using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveler.TravelingStrategies
{
    public class Bus : TravelStrategy
    {
        public Bus()
        {
            KilometerCost = 20;
        }

        public override decimal TotalCost(int kilometers)
        {
            return kilometers * KilometerCost;
        }
    }
}
