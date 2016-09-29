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
            Car car = new Car();
            car.Accelerate();
            car.FuelConsumption();
            car.Move();

            Airplane airplane = new Airplane();
            airplane.Accelerate();
            airplane.FuelConsumption();
            airplane.Move();
        }
    }
}
