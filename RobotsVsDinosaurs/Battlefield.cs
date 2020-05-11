using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Battlefield
    {
        Fleet fleet;
        Herd herd;

        public Battlefield(Fleet fleet, Herd herd)
        {
            this.herd = herd;
            this.fleet = fleet;
        }


    }
}
