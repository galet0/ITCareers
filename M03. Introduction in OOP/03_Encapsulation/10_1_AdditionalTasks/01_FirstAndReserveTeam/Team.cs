using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_FirstAndReserveTeam
{
    class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;
        public Team(string name)
        {
            Name = name;
            this.firstTeam = new List<Person>();
            this.reserveTeam = new List<Person>();
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public IReadOnlyCollection<Person> FirstTeam { get => this.firstTeam.AsReadOnly(); }
        public IReadOnlyCollection<Person> ReserveTeam { get => this.reserveTeam.AsReadOnly(); }

        public void AddPlayer(Person player)
        {
            if(player.Age < 40)
            {
                this.firstTeam.Add(player);
            }
            else
            {
                this.reserveTeam.Add(player);
            }
        }
    }
}
