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
            Robot robot1 = new Robot();
            Console.WriteLine(robot1.health);
            robot1.CreateRobot();
            Console.WriteLine($"Robots name {robot1.name}");
            Console.WriteLine($"Robots power {robot1.powerLevel}");
            Console.WriteLine($"Robots weapon {robot1.weapon.type} and {robot1.weapon.attackPower}");
            Console.ReadLine();
        }
    }
}
