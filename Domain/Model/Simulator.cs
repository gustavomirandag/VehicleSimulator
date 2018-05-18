using Domain.Model.Pilots;
using Domain.Model.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Simulator
    {
        public Pilot Pilot { get; set; }
        public IVehicle Vehicle { get; set; }

        public Simulator(Pilot pilot, IVehicle vehicle)
        {
            Pilot = pilot;
            Vehicle = vehicle;
        }

        public int SpeedUp()
        {
            return Vehicle.SpeedUp();
        }
        public int SpeedDown()
        {
            return Vehicle.SpeedDown();
        }
        public int TurnRight()
        {
            return Vehicle.TurnRight();
        }
        public int TurnLeft()
        {
            return Vehicle.TurnLeft();
        }
    }
}
