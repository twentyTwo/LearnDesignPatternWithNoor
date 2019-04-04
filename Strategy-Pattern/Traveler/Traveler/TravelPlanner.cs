using System;


namespace Traveler
{
    public class TravelPlanner
    {
        private TravelStrategy _travelStrategy;

        public void SetTravelStrategy(TravelStrategy travelStrategy)
        {
            _travelStrategy = travelStrategy;
        }

        public void Drive(int kilometers)
        {
            var cost = _travelStrategy.TotalCost(kilometers);
            Console.WriteLine("Cost of the drive: " + cost);
        }
    }
}
