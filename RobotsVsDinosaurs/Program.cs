using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Program
    {
        static void Main(string[] args)
        {
            //create 3 robots in a fleet           
            Fleet fleet = new Fleet();
            fleet.AddRobotToFleet();
            fleet.AddRobotToFleet();
            fleet.AddRobotToFleet();

            Console.WriteLine($"Robot {fleet.robots[0].name}");
            Console.WriteLine($"Robot {fleet.robots[1].name}");
            Console.WriteLine($"Robot {fleet.robots[2].name}");

            Herd herd = new Herd();
            herd.AddDinoToHerd();
            herd.AddDinoToHerd();
            herd.AddDinoToHerd();

            Console.WriteLine($"Dinosaur {herd.dinosaurs[0].type}");
            Console.WriteLine($"Dinosaur {herd.dinosaurs[1].type}");
            Console.WriteLine($"Dinosaur {herd.dinosaurs[2].type}");



           

            Console.ReadLine();
        }
    }
}
