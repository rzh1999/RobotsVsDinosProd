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



            //            Robot robot1 = new Robot();
            //            Robot robot2 = new Robot();
            //            Robot robot3 = new Robot();

            //            robot1.CreateRobot();
            //            Console.WriteLine(robot1.ToString());

            //            robot2.CreateRobot();
            //            Console.WriteLine(robot2.ToString());

            //            robot3.CreateRobot();
            //            Console.WriteLine(robot3.ToString());



            //            Dinosaur dinosaur1 = new Dinosaur();
            //            Dinosaur dinosaur2 = new Dinosaur();
            //            Dinosaur dinosaur3 = new Dinosaur();

            //            dinosaur1.CreateADinosaur();
            //            Console.WriteLine(dinosaur1.ToString());

            //            dinosaur2.CreateADinosaur();
            //            Console.WriteLine(dinosaur2.ToString());

            //            dinosaur3.CreateADinosaur();
            //            Console.WriteLine(dinosaur3.ToString());

            //            //add created dinsaurs to a list
            //            List<Dinosaur> dinosaurs = new List<Dinosaur>();
            //            dinosaurs.Add(dinosaur1);
            //            dinosaurs.Add(dinosaur2);
            //            dinosaurs.Add(dinosaur3);
            //            //add dinso to herd
            //            Herd newHerd = new Herd(dinosaurs);



            //            //add created robots to a list
            //            List<Robot> robots = new List<Robot>();
            //            robots.Add(robot1);
            //            robots.Add(robot2);
            //            robots.Add(robot3);
            //            //add robots to the fleet
            //            Fleet newFleet = new Fleet(robots);

            //Console.WriteLine($"The fleet is {newFleet.robots[0].name}");

            Console.ReadLine();
        }
    }
}
