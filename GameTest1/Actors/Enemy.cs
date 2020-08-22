using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest1.Actors
{
    class Enemy:Entity
    {
        public Enemy(Dungeon dungeon, int x, int y):base(dungeon)
        {
            this.x = x;
            this.y = y;
        }

        
    }
}
