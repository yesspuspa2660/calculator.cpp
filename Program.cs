using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugasclassdanobject
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();

            taxi.DriverName = "jono";
            taxi.OnDuty = true;
            taxi.NumPasangger = 10;


            taxi.TaxiInfo();
            Console.WriteLine();
            taxi.PickUpPasangger();
            taxi.DropOffPasangger();

            Console.ReadKey();

        }
    }
}
