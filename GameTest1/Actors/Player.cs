using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameTest1.Components;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameTest1.Actors
{
    class Player: Entity
    {
        InputComponent input;
        public Player(Dungeon theworld):base(theworld)
        {
            input = new InputComponent(this);
        }

        public override void Update()
        {
            input.update();
        }

       
    }
}
