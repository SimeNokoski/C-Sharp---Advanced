using CarService.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Entities
{
    public class CarCenter : ICarWash, IGasPump, IRepairService
    {
        public void CheckVehicle(Vehicle vehicle)
        {
            Console.WriteLine($"Checking a vehicle  {vehicle.Brand} {vehicle.Model}");
        }

        public void FixVehicle(Vehicle vehicle)
        {
            Console.WriteLine($"Fixing a vehicle {vehicle.Brand} {vehicle.Model}");
        }

        public void PumpGas(Vehicle vehicle)
        {
            Console.WriteLine($"Pumping gas for the {vehicle.Brand} {vehicle.Model} vehicle");
        }

        public void WashCar(Car car)
        {
            Console.WriteLine($"Washing a car {car.Brand} {car.Model}");
        }

        public void WashTrailer(Truck truck)
        {
            Console.WriteLine($"Washing a truck trailer {truck.Brand} {truck.Model}");
        }

    }
}
