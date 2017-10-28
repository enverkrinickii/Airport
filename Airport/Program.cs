using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airport.Employee;
using Airport.Interfaces;
using Airport.Transports;
using Airport.MyAirport;

namespace Airport
{
    class Program
    {
        static void Main(string[] args)
        {
            MyAirPort myAirPort = new MyAirPort();
           
            AbstractTransport passengerPlane1 = new PassengerPlane("Boing", "777", 1996, 1600, 315, 305);
            AbstractTransport passengerPlane2 = new PassengerPlane("Boing", "737", 2003, 1550, 300, 400);
            AbstractTransport passengerPlane3 = new PassengerPlane("Boing", "747", 2005, 1500, 298, 403);
            AbstractTransport cargoPlane1 = new CargoPlane("Ан","225", 1989, 2014, 300, 440);
            AbstractTransport cargoPlane2 = new CargoPlane("Ан", "123", 1987, 2035, 178, 120);

            myAirPort.AddTransport(passengerPlane1);
            myAirPort.AddTransport(passengerPlane2);
            myAirPort.AddTransport(passengerPlane3);
            myAirPort.AddTransport(cargoPlane1);
            myAirPort.AddTransport(cargoPlane2);

            myAirPort.SortTransports();

            int generalPassengerCount = myAirPort.GetGeneralMaxPassengerCount();
            int generalLoad = myAirPort.getGeneralMaxLoad();

            myAirPort.PrintTransports();

            Console.WriteLine($"Общее количество пассажиров во всех самолетах(чел): {generalPassengerCount}");
            Console.WriteLine($"Общая грузоподъемность(т): {generalLoad}");

            AbstractEmployee pilot1 = new Pilot("Адам", "Смитт", 35, 0);
            AbstractEmployee pilot2 = new Pilot("Петр", "Петров", 25, 0);
            AbstractEmployee manager = new Manager("Вася", "Пупкин", 40, 0);
            AbstractEmployee security = new Security("Семен", "Семенов", 18, 0);
            AbstractEmployee accountant = new Accountant("Мария", "Иванова", 50, 0);
            
            myAirPort.AddEmployee(pilot1);
            myAirPort.AddEmployee(pilot2);
            myAirPort.AddEmployee(manager);
            myAirPort.AddEmployee(security);
            myAirPort.AddEmployee(accountant);

            myAirPort.PrintEmployees();

            Console.WriteLine("Введите верхний диапозон расхода топлива");
            int max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите нижний диапозон расхода топлива");
            int min = Convert.ToInt32(Console.ReadLine());

            myAirPort.FindPlane(min, max);

            Console.ReadKey();
            
            

        }
    }
}
