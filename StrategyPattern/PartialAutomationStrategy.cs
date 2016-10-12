using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class PartialAutomationStrategy : IAutomate
    {
        public bool CruiseControl(string transmission)
        {
            if (transmission == "auto")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DriveAutomatically(string transmission)
        {
            Console.WriteLine("This vehicle does not have automation.");
            return false;
        }
    }
}
