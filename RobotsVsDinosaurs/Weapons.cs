using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
   public class Weapons
    {
        public List<Weapon> weapons;

        public Weapons()
        {
            this.weapons = new List<Weapon>();
        }

        public void AddWeaponToList()
        {
            Weapon weapon = new Weapon();
           
            weapons.Add(weapon);
        
        }
    }
}
