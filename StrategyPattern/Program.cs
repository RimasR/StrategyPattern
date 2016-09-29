using System;

namespace StrategyPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Car car = new Car();
            Airplane airplane = new Airplane();

            switch (Int32.Parse(Console.ReadLine()))
            {
                case 1:
                    car.Accelerate();
                    car.FuelConsumption();
                    car.Move();
                    break;

                case 2:
                    airplane.Accelerate();
                    airplane.FuelConsumption();
                    airplane.Move();
                    break;
            }
        }
    }
}