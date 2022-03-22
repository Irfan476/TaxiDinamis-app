using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();

            taxi.Name = "Andre";
            taxi.Duty = true;
            taxi.Numberpass = 8;

            taxi.TaxiInfo();
            taxi.PickupPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}
