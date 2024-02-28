using FactoryAndAbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAndAbstractFactory.Factory
{
    public interface IVehicleFactory
    {
        IVehicle CreateVehicle();
    }
}
