using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameTest1.Controllers;
using Microsoft.Xna.Framework;

namespace GameTest1.Actors
{
    class Entity : Actor
    {
        enum Direction
        {
            UP,
            RIGHT,
            DOWN,
            LEFT
        }
        Direction facing;
        Dungeon world;
        //A list of current effects
        public Entity(Dungeon currentworld)
        {
            IsItem = false;
            world = currentworld;
        }

        public void SetX(int newX)
        {
            if (newX >= 0 && newX < world.GetWidth())
                x = newX;
        }
        public void SetY(int newY)
        {
            if (newY >= 0 && newY < world.GetHeight())
                x = newY;
        }
        public void setXBy(int incX)
        {
            if (x + incX < world.GetWidth() && x + incX > 0)
            {
                x += incX;
            }
        }

        public void setYBy(int incY)
        {
            if (y + incY < world.GetWidth() && y + incY > 0)
            {
                y += incY;
            }
        }

        public virtual void Update()
        {

        }
    }
}
