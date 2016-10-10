using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class RocketEngineStrategy : IMove
    {
        public void Accelerate(Engine engine, double weight)
        {
            var acceleration = (engine.Torque - weight)/weight;
            Console.WriteLine($"Our acceleration is {acceleration}");
        }

        public void ConsumeFuel(Engine engine, Fuel fuel)
        {
            if (engine.Torque > 400)
            {
                while (fuel.Amount > 0)
                {
                    fuel.Amount = fuel.Amount - 200;
                }
            }
            else
            {
                fuel.Amount = fuel.Amount - 100;
            }
        }

        public void Turn(Turn turn)
        {
            Console.WriteLine($"Please turn {turn.Way}");
        }
    }
}
