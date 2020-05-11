﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Robot
    {
        public string name;
        public double health;
        public int powerLevel;
        public Weapon weapon;

        public Robot(){
            this.health = 100.0;
        }

        public void CreateRobot()
        {
            Console.WriteLine("Enter a robots name: ");
            this.name = Console.ReadLine();
            this.powerLevel = GenerateRobotsPower();
            // Create a wepaon for this robot
            this.weapon = new Weapon();
        }

        public int GenerateRobotsPower()
        {
            Random random = new Random();
            //return a random number between 1 and 20
            return random.Next(1, 20);
        }
    }
}