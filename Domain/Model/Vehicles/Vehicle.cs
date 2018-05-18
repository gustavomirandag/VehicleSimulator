using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Vehicles
{
    public abstract class Vehicle:IVehicle
    {
        public int Acceleration { get; set; }
        public int Speed { get; set; }
        public int Direction { get; set; }
        public Vehicle(int acceleration)
        {
            Acceleration = acceleration;
        }
        public int SpeedUp()
        {
            Speed += Acceleration;
            return Speed;
        }

        public int SpeedDown()
        {
            Speed -= Acceleration;
            return Speed;
        }

        public int TurnLeft()
        {
            Direction -= 1;
            return Direction;
        }
        public int TurnRight()
        {
            Direction += 1;
            return Direction;
        }
    }
}
