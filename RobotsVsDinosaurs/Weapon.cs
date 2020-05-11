using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Weapon
    {
       public string type;
       public  int attackPower;

        public Weapon()
        {
           
        }

        public void CreateAWeapon()
        {
            Console.WriteLine($"Enter weapon name: ");
            this.type = Console.ReadLine();
            Console.WriteLine($"Eneter a weapons attack power 1-100: ");
            this.attackPower = int.Parse(Console.ReadLine());

        }
    }
}
