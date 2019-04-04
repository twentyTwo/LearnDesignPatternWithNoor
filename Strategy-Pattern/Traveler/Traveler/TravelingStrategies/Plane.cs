using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveler.TravelingStrategies
{
    public class Plane : TravelStrategy
    {
        public Plane()
        {
            KilometerCost = 50;
        }

        public override decimal TotalCost(int kilometers)
        {
            if (kilometers > 1000)
            {
                KilometerCost = 15;
            }

            return kilometers * KilometerCost;
        }
    }
}
