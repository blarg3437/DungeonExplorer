using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public void MoveUp()
        {
            int newY = y - 1;
            setPos(x, newY);
        }
        public void MoveDown()
        {
            int newY = y + 1;
            setPos(x, newY);
        }
        public void MoveLeft()
        {
            
            setPos(x - 1, y);
        }

        public void MoveRight()
        {
            setPos(x + 1, y);
        }
        public bool setPos(int newX, int newY)
        {
            if(newX >= 0 && newX < world.GetWidth() && newY >= 0 && newY < world.GetHeight())
            {
                world.RemoveActorFromMap(x, y);
                world.AddActorToMap(this, newX, newY);
                x = newX;
                y = newY;
                System.Diagnostics.Debug.WriteLine("True");
                return true;
            }
            else
            {
                Debug.WriteLine("false");
                return false;
            }
        }
      

        public virtual void Update(GameTime gametime)
        {

        }

        
    }
}
