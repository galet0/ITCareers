using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_FootballTeam
{
    class Player
    {
        private string name;
        private Statistic stats;

        public Player(string name, Statistic stats)
        {
            Name = name;
            Stats = stats;
        }

        public string Name
        {
            get { return name; }
            private set { 
                if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("name", "A name should not be empty. ");
                }
                name = value; }
        }
        public Statistic Stats
        {
            get { return stats; }
            private set { stats = value; }
        }

    }
}
