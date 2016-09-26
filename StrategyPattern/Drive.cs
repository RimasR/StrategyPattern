﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Drive : IMoveBehavior
    {
        public void Move(Vehicle vehicle)
        {
            Console.WriteLine("I'm driving!");
        }
    }
}