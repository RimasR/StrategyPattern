using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Spaceship : Vehicle
    {
        public override void Accelerate()
        {
            Console.WriteLine("Intergalactical acceleration!!!");
        }

        public override void FuelConsumption()
        {
            Console.WriteLine("ITS OVER 9000!!");
        }

        public override void Move()
        {
            Console.WriteLine("I'm flying!");
        }
    }
}
