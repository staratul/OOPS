using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Abstraction
{
    // Concreate class representing a motorcycle
    public class Motorcycle : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Motercycle started");
        }

        public override void Stop()
        {
            Console.WriteLine("Motercycle stopped");
        }
    }
}
