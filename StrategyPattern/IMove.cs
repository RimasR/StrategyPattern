using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    interface IMove
    {
        void Accelerate(Engine engine, double weight);
        void ConsumeFuel(Engine engine, Fuel fuel);
        void Turn(Turn turn);
    }
}
