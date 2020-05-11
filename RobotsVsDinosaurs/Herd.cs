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
            
           

        }
    }

   
}
