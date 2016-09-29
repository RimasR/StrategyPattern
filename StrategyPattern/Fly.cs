﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Fly : IMoveBehavior
    {
        public void Accelerate(Vehicle vehicle)
        {
            Console.WriteLine("Intergalactical acceleration!!!");
        }

        public void FuelCunsuption(Vehicle vehicle)
        {
            Console.WriteLine("ITS OVER 9000!!");
        }

        public void Move(Vehicle vehicle)
        {
            Console.WriteLine("I'm flying!");
        }
    }
}
