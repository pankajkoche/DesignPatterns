using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Car : IVehicle
    {
        private readonly int Wheels;
        public Car()
        {
            this.Wheels = 4;
        }
        public int NumberOfWheels()
        {
            return this.Wheels;
        }

        public string VehicleType()
        {
            return " car class";
        }
    }
}
