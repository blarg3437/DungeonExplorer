using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameTest1.Actors;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace GameTest1.Components
{
    class InputComponent
    {
        Entity holder;
        KeyboardState keystate;
        //temporary solution to a very difficult and imposing problem
        double tempTime = 0.25f;
        double elapsedTime = 0;
        public InputComponent(Entity holder)
        {
            this.holder = holder;
        }

        public void update(GameTime gametime)
        {
            //this is lowkey broken for right now because its getting reset everytime regardless of whether a control is being pressed
            if (elapsedTime >= tempTime)
            {
                keystate = Keyboard.GetState();
                
                if (keystate.IsKeyDown(Keys.A))
                {
                    holder.MoveLeft();
                }
                if (keystate.IsKeyDown(Keys.D))
                {
                    holder.MoveRight();
                }
                if (keystate.IsKeyDown(Keys.W))
                {
                    holder.MoveUp();
                }
                if (keystate.IsKeyDown(Keys.S))
                {
                    holder.MoveDown();
                }


                elapsedTime = 0;
            }
            else
            {
                elapsedTime += gametime.ElapsedGameTime.TotalSeconds;
            }
            System.Diagnostics.Debug.WriteLine(elapsedTime);
        }
    }
}
