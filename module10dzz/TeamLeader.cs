using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module10dz
{
    public class TeamLeader : IWorker
    {
        public void DoWork(House house)
        {
            int doneParts = 0;
            int Windows = 0, Walls = 0;
            for (int i = 0; i < House.COUNT_OF_WALLS; i++)
            {
                if (house.Walls[i].Placed)
                {
                    Walls++;
                    doneParts++;
                }
            }
            for (int i = 0; i < House.COUNT_OF_WINDOWS; i++)
            {
                if (house.Windows[i].Placed)
                {
                    doneParts++;
                    Windows++;
                }
            }

            string str = house.Basement.Placed ? "установлен" : "не установен";

            doneParts += house.Basement.Placed ? 1 : 0;
            doneParts += house.Roof.Placed ? 1 : 0;
            doneParts += house.Door.Placed ? 1 : 0;

            Console.WriteLine("Фундамент {0}", str);
            Console.WriteLine("Установлено {0} стен", Walls);
            str = house.Door.Placed ? "установлена" : "не установлена";
            Console.WriteLine("Дверь {0}", str);
            Console.WriteLine("Установлено {0} окон", Windows);
            str = house.Roof.Placed ? "установлена" : " не установлена";
            Console.WriteLine("Крыша {0}", str);

            if (doneParts == House.ALL_PARTS) Console.WriteLine("Дом построен");
        }
    }
}