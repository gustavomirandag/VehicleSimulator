using Domain.Model.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Pilots
{
    public abstract class Pilot
    {
        public string Name { get; set; }

        public Pilot(string name)
        {
            Name = name;
        }
    }
}
