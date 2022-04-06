﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    public class Taxi
    {
        public string Name { get; set; }
        public bool Duty { get; set; }
        public int Numberpass { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Driver name\t: {0}", Name);
            if (Duty == true)
            {
                Console.WriteLine("On duty\t: yes");
            }
            else
            {
                Console.WriteLine("On duty\t: no");
            }
            Console.WriteLine("Number of passenger\t: {0}", Numberpass);
        }

        public void PickupPassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", Name);
        }

        public void DropOffPassenger()
        {
            Console.WriteLine("{0} sedang mengantar penumpang", Name);
        }
    }
}
