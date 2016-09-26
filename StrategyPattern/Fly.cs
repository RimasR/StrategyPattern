using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Fly : IMoveBehavior
    {
        public void Move(Vehicle vehicle)
        {
            Console.WriteLine("I'm flying!");
        }
    }
}
