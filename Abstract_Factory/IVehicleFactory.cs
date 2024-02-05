using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal interface IVehicleFactory
    {
        IBike CreateBike();
        ICar CreateCar();
    }
}
