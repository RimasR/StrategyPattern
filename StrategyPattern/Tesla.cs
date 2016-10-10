using System.Collections.Generic;

namespace StrategyPattern
{
    internal class Tesla
    {
        public Engine engine;

        public Fuel fuel;

        private readonly IMove move;
        public int PeopleOnBoard = 4;

        public List<Turn> turns;

        public double Weight = 1500;

        public Tesla()
        {
            engine = new Engine
            {
                Torque = 100,
                Type = "Electric"
            };

            move = new CarEngineStrategy();
            fuel = new Fuel
            {
                Amount = 500,
                Type = "Electrolythe"
            };

            turns = new List<Turn>
            {
                Turn.ReturnLeft(),
                Turn.ReturnLeft(),
                Turn.ReturnRight(),
                Turn.ReturnLeft(),
                Turn.ReturnRight()
            };
        }

        public void Drive()
        {
            move.Accelerate(engine, Weight);
            if (PeopleOnBoard > 2)

                fuel.Amount -= 10;

            move.ConsumeFuel(engine, fuel);
            FollowGps(turns);
        }

        private void FollowGps(List<Turn> turns)
        {
            foreach (var turn in turns)
                move.Turn(turn);
        }
    }
}