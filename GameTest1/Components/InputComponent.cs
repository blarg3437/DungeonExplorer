using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameTest1.Actors;
using Microsoft.Xna.Framework.Input;

namespace GameTest1.Components
{
    class InputComponent
    {
        Entity holder;
        KeyboardState keystate;
        public InputComponent(Entity holder)
        {
            this.holder = holder;
        }

        public void update()
        {
            keystate = Keyboard.GetState();

            if(keystate.IsKeyDown(Keys.A))
            {
                holder.setXBy(-1);
            }
            if(keystate.IsKeyDown(Keys.D))
            {
                holder.setXBy(1);
            }
            if(keystate.IsKeyDown(Keys.W))
            {
                holder.setYBy(-1);
            }
            if(keystate.IsKeyDown(Keys.S))
            {
                holder.setYBy(1);
            }
        }
    }
}
