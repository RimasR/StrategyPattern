using System;
using System.Collections.Generic;

namespace TemplateMethod
{
    public abstract class Tesla
    {
        public List<Turn> turns;
        public Engine engine;
        public Fuel fuel;

        public abstract void Turn();

        public abstract void ConsumeFuel();

        public abstract void Accelerate();

        public abstract bool CruiseControl();

        public abstract bool DriveAutomatically();

        public void Drive()
        {
            Accelerate();
            if (fuel.Amount > 0)
                ConsumeFuel();
            Turn();
            if (DriveAutomatically() == true)
            {
                Console.WriteLine("Driving automatically");
            }
            else
            {
                if (CruiseControl() == true)
                {
                    Console.WriteLine("Tesla can use cruise control");
                }
                else
                {
                    Console.WriteLine("Tesla cant drive automatically");
                }
            }

            Turn();
        }
    }
}