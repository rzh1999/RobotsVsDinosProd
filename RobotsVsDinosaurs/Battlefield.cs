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
            bool isWinner = false;
            string robotName = "";
            while (!isWinner)
            {
                Console.WriteLine("Enter a robot to fight: ");
                DisplayRobotNames();
                robotName = Console.ReadLine();

            }
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
