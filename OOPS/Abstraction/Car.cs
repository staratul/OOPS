using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Abstraction
{
    // Concrete class representing a car
    public class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Car Started");
        }

        public override void Stop()
        {
            Console.WriteLine("Car Stopped");
        }
    }
}
