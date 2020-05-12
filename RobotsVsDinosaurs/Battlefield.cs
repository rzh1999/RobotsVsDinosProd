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
        public Weapons weapons;
        public Battlefield()
        {
            
            this.herd = new Herd();
            this.fleet = new Fleet();
            this.weapons = new Weapons();

            Console.WriteLine($"How many weapons do you want to create: ");
            int numWeapons = int.Parse(Console.ReadLine());
            for (int i = 0; i < numWeapons; i++)
            {
                weapons.AddWeaponToList();
            }

            fleet.AddRobotToFleet(weapons.weapons);
            fleet.AddRobotToFleet(weapons.weapons);
            fleet.AddRobotToFleet(weapons.weapons);

            herd.AddDinoToHerd();
            herd.AddDinoToHerd();
            herd.AddDinoToHerd();
        }

        public void DoBattle()
        {

            RobotsChooseYourWeapon();

            
            bool breakLoop = false;
            while (!breakLoop)
            {
                Console.WriteLine($"Do you want a 1. Robot vs Dino or 2. Dino vs Robot");
                int vs = int.Parse(Console.ReadLine());

                switch (vs)
                {
                    case 1:
                        Console.WriteLine($"Enter the number of the robot you want to fight: ");
                        DisplayRobotNames();
                        int roboToFight = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Enter the number of the dinosaur you want to fight: ");
                        DisplayDinoNames();
                        int dinoToFight = int.Parse(Console.ReadLine());
                        fleet.robots[roboToFight].Attack(herd.dinosaurs[dinoToFight]);
                       
                        if (herd.dinosaurs[dinoToFight].health <= 0)
                        {
                            if (herd.dinosaurs.Count != 0)
                            {
                                Console.WriteLine($"{herd.dinosaurs[dinoToFight]} is dead!");
                                herd.dinosaurs.RemoveAt(dinoToFight);
                                if(herd.dinosaurs.Count == 0)
                                {
                                    breakLoop = true;
                                }
                            }
                            
                        }
                        break;
                    case 2:
                        Console.WriteLine($"Enter the number of the dinosaur you want to fight: ");
                        DisplayDinoNames();
                        int dinoToFight2 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Enter the number of the robot you want to fight: ");
                        DisplayRobotNames();
                        int roboToFight2 = int.Parse(Console.ReadLine());
                        herd.dinosaurs[dinoToFight2].Attack(fleet.robots[roboToFight2]);
                        if (fleet.robots[roboToFight2].health <= 0)
                        {
                            if (fleet.robots.Count != 0)
                            {
                                Console.WriteLine($"{fleet.robots[roboToFight2].name} is dead!");
                                fleet.robots.RemoveAt(roboToFight2);
                                if(fleet.robots.Count == 0)
                                {
                                    breakLoop = true;
                                    break;
                                }
                            }
                           
                        }
                        break;
                    default:
                        break;
                }
            }

           if (fleet.robots.Count == 0)
            {
                Console.WriteLine("Dinosaurs won");

            }
            else
            {
                Console.WriteLine("Robots won");
            }
            

        }

        public void DisplayRobotNames()
        {
            int count = 0;
            foreach(Robot robot in fleet.robots)
            {
                Console.WriteLine($"{count}: {robot.name}");
                count++;
            }
            
        }
        public void DisplayDinoNames()
        {
            int count = 0;
            foreach (Dinosaur dinosaur in herd.dinosaurs)
            {
                Console.WriteLine($"{count}: {dinosaur.type}");
                count++;
            }

        }

        public void RobotsChooseYourWeapon()
        {

            foreach(Weapon item in weapons.weapons)
            {
                Console.WriteLine($"The weapons in the list are {item.type}");
            }
        }
}

   
}
