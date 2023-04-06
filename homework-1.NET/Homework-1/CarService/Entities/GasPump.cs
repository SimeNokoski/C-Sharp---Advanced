using CarService.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Entities
{
    public class GasPump : IGasPump
    {
        public void PumpGas(Vehicle vehicle)
        {
            Console.WriteLine($"Pumping gas for the {vehicle.Model} {vehicle.Brand} vehicle");
        }
    }
}
