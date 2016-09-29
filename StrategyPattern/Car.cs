using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Car : Vehicle
    {
        public Car()
        {
            MoveBehavior = new Drive();
        }
    }
}
