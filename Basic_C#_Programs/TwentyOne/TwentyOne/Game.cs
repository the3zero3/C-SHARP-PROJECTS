using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game
    {
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public abstract void Play(); // Any class inheriting this must has some sort of implementation of this method

        public virtual void ListPlayers() // Virtual method - default implementation can be overridden by the inheriting class
        {
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
