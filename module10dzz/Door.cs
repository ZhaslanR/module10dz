using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module10dz
{
    public class Door : Part
    {
        public Door() : base() { Placed = false; }
        public override bool CanBePlaced(House house)
        {
            if (house.Walls[3].Placed && !house.Door.Placed)
            {
                return true;
            }
            return false;
        }
    }
}