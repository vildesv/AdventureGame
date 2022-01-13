using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Room
    {
        public string navn;
        public string[] innhold;
        public bool start;
        public bool vunnet;

        public string hentInnhold()
        {
            return string.Join("\n", innhold);
        }
    }
}
