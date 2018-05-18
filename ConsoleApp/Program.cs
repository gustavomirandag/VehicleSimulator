using Domain.Model;
using Domain.Model.Pilots;
using Domain.Model.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Simulator simulator;
            simulator = new Simulator
                (
                    new Driver("Senna"), 
                    new Mazda()
                );

            simulator.SpeedUp();
            Console.WriteLine(simulator.SpeedUp());
            Console.WriteLine(simulator.Pilot.Name);

            //Aguardo pressionar ENTER...
            Console.ReadLine();
        }
    }
}
