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
            Battlefield battlefield = new Battlefield();
            //create 3 robots in a fleet           
            battlefield.fleet.AddRobotToFleet();
           // battlefield.fleet.AddRobotToFleet();
            //battlefield.fleet.AddRobotToFleet();

            //Console.WriteLine($"Robot { battlefield.fleet.robots[0].name}");
            //Console.WriteLine($"Robot { battlefield.fleet.robots[1].name}");
            //Console.WriteLine($"Robot { battlefield.fleet.robots[2].name}");

           //create 3 dinosaurs
            battlefield.herd.AddDinoToHerd();
            //battlefield.herd.AddDinoToHerd();
            //battlefield.herd.AddDinoToHerd();

            //Console.WriteLine($"Dinosaur {battlefield.herd.dinosaurs[0].type}");
            //Console.WriteLine($"Dinosaur {battlefield.herd.dinosaurs[1].type}");
            //Console.WriteLine($"Dinosaur {battlefield.herd.dinosaurs[2].type}");


            
            battlefield.DoBattle();

            

            Console.ReadLine();
        }
    }
}
