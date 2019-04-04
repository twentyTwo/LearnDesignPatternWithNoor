using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveler.TravelingStrategies
{
    public class Car : TravelStrategy
    {
        public Car()
        {
            KilometerCost = 25;
        }

        public override decimal TotalCost(int kilometers)
        {
            return kilometers * KilometerCost;
        }
    }
}
