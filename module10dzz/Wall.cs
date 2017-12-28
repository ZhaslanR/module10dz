using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module10dz
{
    public class Wall : Part
    {
        public Wall() : base() { Placed = false; }
        public override bool CanBePlaced(House house)
        {
            if (house.Basement.Placed && house.Walls.Count < 4) return true;
            return false;
        }
    }
}