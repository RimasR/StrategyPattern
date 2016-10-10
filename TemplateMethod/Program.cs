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
            Vehicle tesla = new Tesla();
            tesla.Drive();

            Vehicle spaceship = new Spaceship();
            spaceship.Drive();
        }
    }
}
