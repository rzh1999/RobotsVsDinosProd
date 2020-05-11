using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Battlefield
    {
        public Fleet fleet;
        public Herd herd;

        public Battlefield()
        {
            
            this.herd = new Herd();
            this.fleet = new Fleet();
        }

        public void DoBattle()
        {
            //bool isWinner = false;
            //string robotName = "";
            //while (!isWinner)
            //{
            //    Console.WriteLine("Enter a robot to fight: ");
            //    DisplayRobotNames();
            //    robotName = Console.ReadLine();

            //}
           

            Console.WriteLine($"Robots health before attack {fleet.robots[0].health}");
            herd.dinosaurs[0].Attack(fleet.robots[0]);
            Console.WriteLine($"Robots health after attack 1 {fleet.robots[0].health}");
            herd.dinosaurs[0].Attack(fleet.robots[0]);
            Console.WriteLine($"Robots health after attack 2 {fleet.robots[0].health}");
            herd.dinosaurs[0].Attack(fleet.robots[0]);
            Console.WriteLine($"Robots health after attack 3 {fleet.robots[0].health}");

        }

        public void DisplayRobotNames()
        {
            foreach(Robot robot in fleet.robots)
            {
                Console.WriteLine($"{robot.name}");
            }
            
        }

        
    }

   
}
