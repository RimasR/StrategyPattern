﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Drive : IMoveBehavior
    {
        public void Accelerate(Vehicle vehicle)
        {
            Console.WriteLine("Slowly accelerating...");
        }

        public void FuelCunsuption(Vehicle vehicle)
        {
            Console.WriteLine("Consuming fuel in a reasonable amount.");
        }

        public void Move(Vehicle vehicle)
        {
            Console.WriteLine("I'm driving!");
        }
    }
}
