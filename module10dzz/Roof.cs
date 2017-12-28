using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module10dz
{
    public class Roof : Part
    {
        public Roof() : base() { Placed = false; }
        public override bool CanBePlaced(House house)
        {
            if (house.Windows[house.Windows.Capacity - 1].Placed && !house.Roof.Placed) return true;
            return false;
        }
    }
}