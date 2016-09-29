using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    abstract public class Vehicle
    {
        public abstract void Move();
        public abstract void FuelConsumption();
        public abstract void Accelerate();
    }
}
