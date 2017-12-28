using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module10dz
{
    public class Window : Part
    {
        public Window() : base() { }
        public override bool CanBePlaced(House house)
        {
            if (house.Door.Placed && house.Windows.Count < 4) return true;
            return false;
        }
    }
}