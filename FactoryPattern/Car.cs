using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Car : IVehicle
    {
        public Car() 
        { 
        }

        public void Drive () 
        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("The car is driving at a safe pace.  Oh boy  !");
        }
    }
}
