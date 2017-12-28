using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module10dz
{
    public class Basement : Part
    {
        public Basement() : base() { Placed = false; }
        public override bool CanBePlaced(House house)
        {
            if (house.Basement.Placed == false) return true;
            return false;
        }
    }
}