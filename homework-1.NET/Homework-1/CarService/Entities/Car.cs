using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Entities
{
    public class Car : Vehicle
    {
        public Car(string brand, string model) : base(brand, model)
        {
            Brand = brand;
            Model = model;
        }

        public override void Drive()
        {
            Console.WriteLine($"{Brand} {Model} drives");
        }
    }
}
