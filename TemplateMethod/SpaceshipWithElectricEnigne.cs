using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class SpaceshipWithElectricEnigne : Spaceship
    {
        public override void Turn()
        {
            turns = new List<Turn>
            {
                TemplateMethod.Turn.ReturnLeft(),
                TemplateMethod.Turn.ReturnLeft(),
                TemplateMethod.Turn.ReturnRight(),
                TemplateMethod.Turn.ReturnLeft(),
                TemplateMethod.Turn.ReturnRight(),
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
                Amount = 15000,
                Type = "Electric fuel"
            };
            if (engine.Torque > 400)
            {
                while (fuel.Amount > 0)
                {
                    fuel.Amount -= 200;
                }
            }
            else
            {
                while (fuel.Amount > 0)
                {
                    fuel.Amount -= 100;
                }
            }
        }

        public override void Accelerate()
        {
            engine = new Engine()
            {
                Type = "Electric",
                Torque = 500
            };
            var acceleration = engine.Torque;

            Console.WriteLine($"Accelerating at {acceleration} m/s");
        }
    }
}
}
