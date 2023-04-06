using CarService.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Entities
{
    public class CarWash : ICarWash
    {
 
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
