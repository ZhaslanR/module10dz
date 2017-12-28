using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module10dz
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House();
            Team team = new Team(House.ALL_PARTS);
            while (team.GetWorkersCount() > 0)
            {
                team.UseOneWorker(house);
            }
            team.UseTeamLeader(house);
            Console.ReadLine();
        }
    }
}