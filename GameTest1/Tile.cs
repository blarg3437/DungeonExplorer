using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameTest1.Actors;

namespace GameTest1
{
    class Tile
    {
        public int TileId;
        Actor ActorOn = null;
        bool isWalkable;

        
        public Tile(int TileID, bool isWalkable)
        {
            TileId = TileID;
            this.isWalkable = isWalkable;
        }
    }
}
