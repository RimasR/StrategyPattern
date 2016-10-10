using System;

namespace StrategyPattern
{
    internal class CarEngineStrategy : IMove
    {
        public void Accelerate(Engine engine, double weight)
        {
            var acceleration = engine.Torque / 2;
            Console.WriteLine($"Our acceleration is {acceleration}");
        }

        public void ConsumeFuel(Engine engine, Fuel fuel)
        {
            if (engine.Type == "Electric")
            {
                fuel.Amount = 0;
            }
            else
            {
                while (fuel.Amount > 0)
                {
                    fuel.Amount = fuel.Amount - 1;
                }
            }
        }

        public void Turn(Turn turn)
        {
            Console.WriteLine($"Please turn {turn.Way}");
        }
    }
}