using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module10dz
{
    public class House
    {
        public const int COUNT_OF_WINDOWS = 4;
        public const int COUNT_OF_WALLS = 4;
        public const int ALL_PARTS = 11;

        public List<Wall> Walls { get; set; }
        public List<Window> Windows { get; set; }

        public Door Door { get; set; }
        public Roof Roof { get; set; }
        public Basement Basement { get; set; }

        public House()
        {
            Walls = new List<Wall> { new Wall(), new Wall(), new Wall(), new Wall() };
            Windows = new List<Window> { new Window(), new Window(), new Window(), new Window() };

            Door = new Door();
            Roof = new Roof();
            Basement = new Basement();
        }
    }
}