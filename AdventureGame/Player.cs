using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Player
    {
        public List<string> har;
        public Room room;

        public Player()
        {
            har = new List<string>();
        }

        public string inventory()
        {
            return string.Join("\n", har);
        }
    }
}
