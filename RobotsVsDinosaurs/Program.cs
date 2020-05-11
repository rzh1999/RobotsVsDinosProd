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
            robot2.CreateRobot();
            robot3.CreateRobot();

            //Console.WriteLine($"Robots name is {robot1.name} Robots power {robot1.powerLevel} Robots weapon {robot1.weapon.type} and {robot1.weapon.attackPower}");
            //Console.WriteLine($"Robots name is {robot2.name} Robots power {robot2.powerLevel} Robots weapon {robot2.weapon.type} and {robot2.weapon.attackPower}");
            //Console.WriteLine($"Robots name is {robot3.name} Robots power {robot3.powerLevel} Robots weapon {robot3.weapon.type} and {robot3.weapon.attackPower}");

            Dinosaur dinosaur1 = new Dinosaur();
            Dinosaur dinosaur2 = new Dinosaur();
            Dinosaur dinosaur3 = new Dinosaur();

            dinosaur1.CreateADinosaur();
            Console.WriteLine(dinosaur1.ToString());
            dinosaur2.CreateADinosaur();
            dinosaur3.CreateADinosaur();

            //Console.WriteLine($"The dinosaur is a {dinosaur1.type} his health is {dinosaur1.health} his energy is {dinosaur1.energy} and his attack power is {dinosaur1.attackPower}");
            //Console.WriteLine($"The dinosaur is a {dinosaur2.type} his health is {dinosaur2.health} his energy is {dinosaur2.energy} and his attack power is {dinosaur2.attackPower}");
            //Console.WriteLine($"The dinosaur is a {dinosaur3.type} his health is {dinosaur3.health} his energy is {dinosaur3.energy} and his attack power is {dinosaur3.attackPower}");

            Console.ReadLine();
        }
    }
}
