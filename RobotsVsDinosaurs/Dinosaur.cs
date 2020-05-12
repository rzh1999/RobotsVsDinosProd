using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Dinosaur
    {
        public string type;
        public double health;
        public int energy;
        public int attackPower;

        public Dinosaur()
        {
            this.health = 100.0;
        }

        public void  CreateADinosaur()
        {
            Console.WriteLine("Enter in a type of dinosaur: ");
            this.type = Console.ReadLine();
            this.energy = GenerateDinosaursEnergy();
            this.attackPower = GenerateDinosaursAttackPower();

        }

        public int GenerateDinosaursEnergy()
        {
            Random random = new Random();
            //return a random number between 1 and 30
            return random.Next(1, 30);
        }

        public int GenerateDinosaursAttackPower()
        {
            Random random = new Random();
            //Retrun a random number between 40 and 100
            System.Threading.Thread.Sleep(30);
            return random.Next(40, 100);
        }

        public override string ToString()
        {
            return $"The dinosaur is a {type} his health is {health} his energy is {energy} and his attack power is {attackPower}";
        }

        public void Attack(Robot robot)
        {
            int dinosaurPower = attackPower + energy;
            robot.health = robot.health - dinosaurPower;
            Console.WriteLine($"Robot {robot.name} health is {robot.health}\n");
            
           

        }
    }
}
