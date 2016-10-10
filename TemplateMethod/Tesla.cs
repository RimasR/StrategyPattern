using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Tesla : Vehicle
    {
        public override void Turn()
        {
            turns = new List<Turn>
            {
                TemplateMethod.Turn.ReturnLeft(),
                TemplateMethod.Turn.ReturnLeft(),
                TemplateMethod.Turn.ReturnRight(),
                TemplateMethod.Turn.ReturnLeft(),
                TemplateMethod.Turn.ReturnRight()
            };

            foreach (Turn turn in turns)
            {
                Console.WriteLine($"{turn.Way}");
            }
        }

        public override void ConsumeFuel()
        {
            fuel = new Fuel()
            {
                Amount = 150,
                Type = "Electrolytes"
            };
            if (engine.Type == "Electric")
            {
                fuel.Amount = 0;
            }
            else
            {
                while (fuel.Amount > 0)
                {
                    fuel.Amount -= 1;
                }
            }
        }

        public override void Accelerate()
        {
            engine = new Engine()
            {
                Type = "Electric",
                Torque = 200
            };
            var acceleration = engine.Torque / 2;

            Console.WriteLine($"Accelerating at {acceleration} m/s");
        }
    }
}
