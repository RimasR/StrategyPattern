using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Tesla car = new Tesla();
            car.Accelerate();
            car.FuelConsumption();
            car.Move();

            Spaceship spaceship = new Spaceship();
            spaceship.Accelerate();
            spaceship.FuelConsumption();
            spaceship.Move();
        }
    }
}
