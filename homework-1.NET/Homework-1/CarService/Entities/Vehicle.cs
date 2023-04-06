using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Entities
{
    public abstract class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public Vehicle(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }
        public abstract void Drive();
    }
}
