using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Entities
{
    public class Truck : Vehicle
    {
        public Truck(string brand, string model) : base(brand, model)
        {
          
        }

        public override void Drive()
        {
            Console.WriteLine($"{Brand} {Model} drives");
        }
    }
}
