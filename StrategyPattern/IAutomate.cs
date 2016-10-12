using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    interface IAutomate
    {
        bool CruiseControl(string transmission);
        bool DriveAutomatically(string transmission);
    }
}
