using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAndAbstractFactory.Models
{
    public class MotorCycle: IVehicle
    {
        public void Manufacture()
        {
            Console.WriteLine("MotorCycle is manufactured");
        }
    }
}
