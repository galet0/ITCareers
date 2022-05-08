using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_FootballTeam
{
    class Team
    {
        private List<Player> players;
        private string name;

        
        public Team(string name)
        {
            this.players = new List<Player>();
            this.Name = name;
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

        IReadOnlyCollection<Player> Players { get => this.players.AsReadOnly(); }

        //рейтинг(изчислена от нивата на средните умения на всички играчи в отбора и закръглена до цяло число)
        public double Rating()
        {
            double sum = 0;
            foreach (var player in this.players)
            {
                sum += Math.Round(player.Stats.Average());
            }

            return sum;
        }

        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }

        public bool RemovePlayer(string name)
        {
            Player player = this.GetPlayerByName(name);
            if(player != null)
            {
                return this.players.Remove(player);
            }

            return false;
        }

        private Player GetPlayerByName(string name)
        {
            return this.players.Where(p => p.Name.Equals(name)).FirstOrDefault();
        }
    }
}
