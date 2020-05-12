using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Robot
    {
        public string name;
        public double health;
        public int powerLevel;
        public Weapon weapon;

        public Robot(){
            this.health = 100.0;
        }

        public void CreateRobot(List<Weapon> weaponOptions)
        {
            
            Console.WriteLine("Enter a robots name: ");
            this.name = Console.ReadLine();
            this.powerLevel = GenerateRobotsPowerLevel();
            // Display a list of weapons a robot can have
            Console.WriteLine($"Choose a weapon for your robot: ");
            for(int i =0; i < weaponOptions.Count; i++)
            {
                Console.WriteLine($" {i} {weaponOptions[i].type}");
            }
            int weaponChoice = int.Parse(Console.ReadLine());
            this.weapon = weaponOptions[weaponChoice];
        }

        public int GenerateRobotsPowerLevel()
        {
            Random random = new Random();
            //return a random number between 1 and 20
            return random.Next(1, 20);
        }

        public override string ToString()
        {
            return $"Robots name is {name} Robots power {powerLevel} Robots weapon {weapon.type} and {weapon.attackPower}";
        }

        public void Attack(Dinosaur dinosaur)
        {
            int absolutePower = powerLevel + weapon.attackPower;
            dinosaur.health = dinosaur.health - absolutePower;
            Console.WriteLine($"Dinosaur {dinosaur.type} health is {dinosaur.health}\n");
            
        }


    }
}
