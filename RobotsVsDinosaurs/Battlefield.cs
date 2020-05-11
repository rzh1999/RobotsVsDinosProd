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
            //while (fleet.robots.Count > 0 || herd.dinosaurs.Count > 0)
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
                            //else
                            //{
                            //    breakLoop = true;
                            //    break;
                            //}
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
                            //else
                            //{
                            //    breakLoop = true;
                            //    break;
                            //}
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

    }

   
}
