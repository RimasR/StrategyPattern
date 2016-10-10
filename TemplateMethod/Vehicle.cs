using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class Vehicle
    {

        public List<Turn> turns;
        public Engine engine;
        public Fuel fuel;
        public int peopleOnboard;
        public double weight;

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
