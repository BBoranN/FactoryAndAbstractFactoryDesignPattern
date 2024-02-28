using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAndAbstractFactory.Models
{
    public class Car: IVehicle
    {
        public void Manufacture()
        {
            Console.WriteLine("Car is manufactured");
        }

    }
}
