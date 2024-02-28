using FactoryAndAbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAndAbstractFactory.Factory
{
    public class MotorCycleFactory: IVehicleFactory
    {

        public IVehicle CreateVehicle()
        {
            return new MotorCycle();
        }
    }
}
