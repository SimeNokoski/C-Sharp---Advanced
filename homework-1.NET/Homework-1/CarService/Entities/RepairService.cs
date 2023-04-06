using CarService.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Entities
{
    public class RepairService : IRepairService
    {
        public void CheckVehicle(Vehicle vehicle)
        {
            Console.WriteLine($"Checking a vehicle  {vehicle.Model} {vehicle.Brand}");
        }

        public void FixVehicle(Vehicle vehicle)
        {
            Console.WriteLine($"Fixing a vehicle {vehicle.Model} {vehicle.Brand}");
        }
    }
}
