using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Tesla : Vehicle
    {
        public override void Accelerate()
        {
            Console.WriteLine("Slowly accelerating...");
        }

        public override void FuelConsumption()
        {
            Console.WriteLine("Consuming fuel in a reasonable amount.");
        }

        public override void Move()
        {
            Console.WriteLine("I'm driving!");
        }
    }
}
