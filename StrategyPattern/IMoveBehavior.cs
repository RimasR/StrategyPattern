using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    interface IMoveBehavior
    {
        void Move(Vehicle vehicle);

        void Accelerate(Vehicle vehicle);

        void FuelCunsuption(Vehicle vehicle);


    }
}
