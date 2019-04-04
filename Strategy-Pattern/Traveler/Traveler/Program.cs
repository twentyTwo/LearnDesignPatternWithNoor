using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveler.TravelingStrategies;

namespace Traveler
{
    class Program
    {
        static void Main(string[] args)
        {
            TravelPlanner travelPlanner = new TravelPlanner();

            travelPlanner.SetTravelStrategy(new Plane());
            travelPlanner.Drive(1100);

            Console.ReadKey();
        }
    }
}
