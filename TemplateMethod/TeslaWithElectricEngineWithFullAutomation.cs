using System;
using System.Collections.Generic;

namespace TemplateMethod
{
    internal class TeslaWithElectricEngineWithFullAutomation : Tesla
    {
        public List<Turn> turns;
        public Engine engine;
        public Fuel fuel;

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
        }

        public override void Accelerate()
        {
        }

        public override bool CruiseControl()
        {
            return true;
        }

        public override bool DriveAutomatically()
        {
            return true;
        }
    }
}