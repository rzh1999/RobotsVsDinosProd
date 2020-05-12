using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Herd
    {
       public List<Dinosaur> dinosaurs;

        public Herd()
        {
            this.dinosaurs = new List<Dinosaur>();
        }

        public void AddDinoToHerd()
        {
            Dinosaur dinosaur = new Dinosaur();
            dinosaur.CreateADinosaur();
            dinosaurs.Add(dinosaur);
            int attack1 = dinosaur.GenerateDinosaursAttackPower();
            int attack2 = dinosaur.GenerateDinosaursAttackPower();
            int attack3 = dinosaur.GenerateDinosaursAttackPower();
            int[] dinoAttackTypes = new int[3] { attack1, attack2, attack3 };
            for (int i = 0; i < dinoAttackTypes.Length; i++)
            {
                Console.WriteLine($"AddDinoToHerd {i}. {dinoAttackTypes[i]}");
            }
            int powerChoice = int.Parse(Console.ReadLine());
            dinosaur.attackPower = dinoAttackTypes[powerChoice];
        }
    }

   
}
