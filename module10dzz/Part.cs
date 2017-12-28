using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module10dz
{
    public abstract class Part : IPart
    {
        public Part()
        {
            Placed = false;
        }
        public bool Placed { get; set; }
        public abstract bool CanBePlaced(House house);
    }
}