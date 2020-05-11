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
            Robot robot2 = new Robot();
            Robot robot3 = new Robot();
            
            robot1.CreateRobot();
            Console.WriteLine(robot1.ToString());

            robot2.CreateRobot();
            Console.WriteLine(robot2.ToString());

            robot3.CreateRobot();
            Console.WriteLine(robot3.ToString());



            Dinosaur dinosaur1 = new Dinosaur();
            Dinosaur dinosaur2 = new Dinosaur();
            Dinosaur dinosaur3 = new Dinosaur();

            dinosaur1.CreateADinosaur();
            Console.WriteLine(dinosaur1.ToString());

            dinosaur2.CreateADinosaur();
            Console.WriteLine(dinosaur2.ToString());

            dinosaur3.CreateADinosaur();
            Console.WriteLine(dinosaur3.ToString());



            Console.ReadLine();
        }
    }
}
