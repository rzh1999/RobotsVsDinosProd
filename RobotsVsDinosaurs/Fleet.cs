using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Fleet
    {
        public List<Robot> robots;

        public Fleet()
        {
            this.robots = new List<Robot>();
        }

        //create fleet (instantiating a robot object and adding to the list)
        public void AddRobotToFleet()
        {
            Robot robot = new Robot();
            robot.CreateRobot();
            robots.Add(robot);
        }
    }
}
