using System.Collections.Generic;

namespace StrategyPattern
{
    internal class Spaceship
    {
        public int crewOnBoard;

        public Engine engine;

        public Fuel fuel;

        private readonly IMove move;

        public List<Turn> turnsForMoon;

        public double weight;

        public Spaceship()
        {
            move = new RocketEngineStrategy();
            turnsForMoon = new List<Turn>
            {
                Turn.ReturnLeft(),
                Turn.ReturnLeft(),
                Turn.ReturnRight(),
                Turn.ReturnLeft(),
                Turn.ReturnRight(),
                Turn.ReturnLeft(),
                Turn.ReturnLeft(),
                Turn.ReturnRight(),
                Turn.ReturnLeft(),
                Turn.ReturnRight()
            };
            engine = new Engine
            {
                Torque = 10000,
                Type = "Rocket"
            };

            fuel = new Fuel
            {
                Amount = 50000,
                Type = "Nitrate"
            };
            crewOnBoard = 10;

            weight = 1500000;
        }

        public bool IsIntergalacticalSpeedPossible()
        {
            FollowGps(turnsForMoon);
            if (crewOnBoard < 20)
            {
                move.Accelerate(engine, weight);
                move.ConsumeFuel(engine, fuel);
                return true;
            }
            return false;
        }

        private void FollowGps(List<Turn> turns)
        {
            foreach (var turn in turns)
                move.Turn(turn);
        }
    }
}