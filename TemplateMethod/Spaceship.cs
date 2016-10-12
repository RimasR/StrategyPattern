using System;
using System.Collections.Generic;

namespace TemplateMethod
{
    public abstract class Spaceship
    {
        public Engine engine;
        public Fuel fuel;
        public List<Turn> turns;

        public abstract void Turn();

        public abstract void ConsumeFuel();

        public abstract void Accelerate();

        public void Drive()
        {
            Accelerate();
            ConsumeFuel();
            Turn();
        }
    }
}