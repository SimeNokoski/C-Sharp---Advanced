using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Entities.Interfaces
{
    public interface IGasPump
    {
        void PumpGas(Vehicle vehicle);
    }
}
