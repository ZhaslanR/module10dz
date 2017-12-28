using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module10dz
{
    public class Team
    {
        List<Worker> Workers { get; set; }
        TeamLeader TeamLeader { get; set; }
        public Team(int countOfWorkers = 0)
        {
            Workers = new List<Worker>();
            TeamLeader = new TeamLeader();
            for (int i = 0; i < countOfWorkers; i++) Workers.Add(new Worker());
        }

        public int GetWorkersCount()
        {
            return Workers.Count;
        }

        public void UseOneWorker(House house)
        {
            Workers[Workers.Count - 1].DoWork(house);
            Workers.Remove(Workers[Workers.Count - 1]);
        }
        public void UseTeamLeader(House house)
        {
            TeamLeader.DoWork(house);
        }
    }
}