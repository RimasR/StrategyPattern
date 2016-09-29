
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Vehicle
    {
        public IMoveBehavior MoveBehavior;

        public Vehicle()
        {
            
        }

        public void FuelConsumption()
        {
            MoveBehavior.FuelCunsuption(this);
        }

        public void Accelerate()
        {
            MoveBehavior.Accelerate(this);
        }

        public void Move()
        {
            MoveBehavior.Move(this);
        }
    }

}
