using System;

namespace StrategyPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            switch (Int32.Parse(Console.ReadLine()))
            {
                case 1:
                    Tesla tesla = new Tesla(new CarEngineStrategy(), new FullAutomationStrategy());
                    tesla.Drive();
                    break;

                case 2:
                    Spaceship spaceship = new Spaceship(new RocketEngineStrategy());
                    spaceship.Drive();
                    break;
            }
        }
    }
}