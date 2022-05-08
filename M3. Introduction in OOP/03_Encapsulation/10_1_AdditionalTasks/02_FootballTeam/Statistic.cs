using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_FootballTeam
{
    class Statistic
    {
        private int endurance;
        private int sprint;
        private int dribble;
        private int passes;
        private int shooting;

        public Statistic(int endurance, int sprint, int dribble, int passes, int shooting)
        {
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passes = passes;
            Shooting = shooting;
        }

        public int Endurance
        {
            get { return endurance; }
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("endurance", "Endurance should be between 0 and 100.");
                }
                endurance = value;
            }
        }
        public int Sprint
        {
            get { return sprint; }
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("sprint", "Sprint should be between 0 and 100.");
                }
                sprint = value;
            }
        }
        public int Dribble
        {
            get { return dribble; }
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("dribble", "Dribble should be between 0 and 100.");
                }
                dribble = value;
            }
        }
        public int Passes
        {
            get { return passes; }
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("passes", "Passes should be between 0 and 100.");
                }
                passes = value;
            }
        }
        public int Shooting
        {
            get { return shooting; }
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("shooting", "Shooting should be between 0 and 100.");
                }
                shooting = value;
            }
        }

        public double Average()
        {
            return (Endurance + Sprint + Dribble + Passes + Shooting) / 5.0;
        }
    }
}
