using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class FullAutomationStrategy : IAutomate
    {
        public bool CruiseControl(string transmission)
        {
            Console.WriteLine("This vehicle does have a cruise control, but it is reduntant.");
            return true;
        }

        public bool DriveAutomatically(string transmission)
        {
            Console.WriteLine("This vehicle can drive automatically.");
            return true;
        }
    }
}
