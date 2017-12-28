using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module10dz
{
    public class Worker : IWorker
    {
        string Name { get; set; }

        public Worker(string name = "Рабочий")
        {
            Name = name;
        }

        public void DoWork(House house)
        {
            if (!house.Basement.Placed)
            {
                house.Basement.Placed = true;
                return;
            }
            for (int i = 0; i < House.COUNT_OF_WALLS; i++)
            {
                if (!house.Walls[i].Placed)
                {
                    house.Walls[i].Placed = true;
                    return;
                }
            }
            if (!house.Door.Placed)
            {
                house.Door.Placed = true;
                return;
            }
            for (int i = 0; i < House.COUNT_OF_WINDOWS; i++)
            {
                if (!house.Windows[i].Placed)
                {
                    house.Windows[i].Placed = true;
                    return;
                }
            }
            if (!house.Roof.Placed)
            {
                house.Roof.Placed = true;
                return;
            }
        }
    }
}