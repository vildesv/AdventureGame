using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Model
    {
        public Player player;
        public Room[] room;
        public Door[] doors;

        public Model()
        {
            player = new Player();
            var roomA = new Room { navn = "A", innhold = new[] { "rød nøkkel" }, start = true };
            var roomB = new Room { navn = "B", innhold = new[] { "grønn nøkkel" } };
            var roomC = new Room { navn = "C", innhold = new[] { "hvit nøkkel" } };
            var roomD = new Room { navn = "D", innhold = new[] { "blå nøkkel" } };
            var roomE = new Room { navn = "E", innhold = new[] { "grå nøkkel" } };
            var roomF = new Room { navn = "F", innhold = new string[0], vunnet = true };
            room = new[] { roomA, roomB, roomC, roomD, roomE, roomF, };
            player.room = room.FirstOrDefault(r => r.start);
            doors = new[]
            {
                new Door{ A= roomB, B= roomA, farge= "rød", åpen= false },
                new Door{ A= roomD, B= roomA, farge= "grønn", åpen= false },
                new Door{ A= roomC, B= roomB, farge= "grå", åpen= false },
                new Door{ A= roomE, B= roomB, farge= "blå", åpen= false },
                new Door{ A= roomF, B= roomE, farge= "hvit", åpen= false },
            };
        }

        public string Doors()
        {
            var room = player.room;
            var doorsInRoom = doors.Where(d => d.A == room || d.B == room);

            var txt = "";
            foreach (var door in doorsInRoom)
            {
                var til = door.A == room ? door.B : door.A;
                txt += door.åpen
                    ? $"Gå til {til.navn}\n"
                    : $"Låse opp {door.farge}\n";
            }
            return txt;
        }
    }
}
