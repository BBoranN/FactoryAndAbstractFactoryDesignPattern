using FactoryAndAbstractFactory.AbstaractFactory;
using FactoryAndAbstractFactory.Factory;
using FactoryAndAbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAndAbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IVehicleFactory carFactory = new CarFactory();
            IVehicle car = carFactory.CreateVehicle();
            car.Manufacture();

            IVehicleFactory motorCycleFactory = new MotorCycleFactory();
            IVehicle motorCycle = motorCycleFactory.CreateVehicle();
            motorCycle.Manufacture();

            IGuiFactory windowsFactory = new WindowsGuiFactory();
            IButton windowsButton = windowsFactory.CreateButton();
            ITextBox windowsTextBox = windowsFactory.CreateTextBox();

            windowsButton.Click();
            windowsTextBox.Type();

            // Creating a Linux-style GUI
            IGuiFactory macFactory = new MacGuiFactory();
            IButton macButton = macFactory.CreateButton(); 
            ITextBox macTextBox = macFactory.CreateTextBox();

            macButton.Click();
            macTextBox.Type();



            Console.WriteLine("Press 'q' to exit...");

            while (Console.ReadKey().Key != ConsoleKey.Q)
            {
                // Continue running
            }
        }
    }
}
