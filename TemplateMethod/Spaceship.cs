﻿using System;
using System.Collections.Generic;

namespace TemplateMethod
{
    public class Spaceship : Vehicle
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
                Type = "Rocket fuel"
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
                Type = "Rocket",
                Torque = 500
            };
            weight = 1550000;
            var acceleration = (engine.Torque - weight)/weight;

            Console.WriteLine($"Accelerating at {acceleration} m/s");
        }
    }
}