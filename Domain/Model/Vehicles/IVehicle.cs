using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Vehicles
{
    public interface IVehicle
    {
        int SpeedUp();
        int SpeedDown();
        int TurnLeft();
        int TurnRight();
    }
}
