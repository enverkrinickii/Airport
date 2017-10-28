using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airport.Interfaces;
using Airport.Transports;

namespace Airport
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Transport> myTransports = new List<Transport>();
            PassengerPlane passengerPlane1 = new PassengerPlane("Boing", "777", 1996, 1600, 315, 305);
            PassengerPlane passengerPlane2 = new PassengerPlane("Boing", "737", 2003, 1550, 300, 400);
            PassengerPlane passengerPlane3 = new PassengerPlane("Boing", "747", 2005, 1500, 298, 403);
            CargoPlane cargoPlane1 = new CargoPlane("Ан","225", 1989, 2014, 300, 440);
            CargoPlane cargoPlane2 = new CargoPlane("Ан", "123", 1987, 2035, 178, 120);

            myTransports.Add(passengerPlane1);
            myTransports.Add(passengerPlane2);
            myTransports.Add(passengerPlane3);
            myTransports.Add(cargoPlane1);
            myTransports.Add(cargoPlane2);

            myTransports.Sort();

            foreach (var transport in myTransports)
            {
                Console.WriteLine(transport);
            }

            Console.ReadKey();

        }
    }
}
