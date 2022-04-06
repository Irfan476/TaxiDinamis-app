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

            Console.WriteLine("=== Driver Info ===");
            Console.WriteLine("Masukkan nama driver\t: ");
            taxi.Name = Console.ReadLine();
            Console.WriteLine("On Duty (Yes/No)\t: ");
            taxi.Duty = (Console.ReadLine().ToLower() == "yes") || (Console.ReadLine().ToLower() == "Yes") ? true : false;

            if (taxi.Duty)
            {
                Console.WriteLine("Jumlah penumpang\t: ");
                taxi.Numberpass = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                taxi.TaxiInfo();
                taxi.PickupPassenger();
                taxi.DropOffPassenger();
            }
            else
            {
                Console.Clear();
                taxi.TaxiInfo();                
            }

            Console.WriteLine("\nTekan ENTER untuk melanjutkan");
            Console.ReadKey();
        }
    }
}
