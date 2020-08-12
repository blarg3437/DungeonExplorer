using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameTest1.Actors;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GameTest1
{
    class Camera
    {
        //this will allow the camera to change its focus and follow another entity or item
        Actor focus;
        Dungeon map;
        public int cameraX { get; private set; }
        public int cameraY { get; private set; }
        public int width { get; private set; }
        public int height { get; private set; }

        public Camera(Actor focus, Dungeon currentmap)
        {
            this.focus = focus;
            map = currentmap;
            width = (int)Math.Ceiling((float)Global.Graphics.PreferredBackBufferWidth / (float)Global.TexSize);
            height = (int)Math.Ceiling((float)Global.Graphics.PreferredBackBufferHeight / (float)Global.TexSize);
            cameraX = 0;
            cameraY = 0;
            if (cameraX < 0) cameraX = 0;
            if (cameraY < 0) cameraY = 0;
        }

        public void changeFocus(Actor newActor)
        {
            if (newActor != null)
                focus = newActor;
        }

        public void UpdateView()
        {
            //get keyboard input
            //determine if the view has to be updated
            //update the view
            //add the offset to the draw in the offset


            //if the cx is below 0, set it to zero
            //if cx > mapwidth, set it to mapwidth - width


            int focX = focus.x;
            int focY = focus.y;
            int newcamX = focX - width / 2;
            int newcamY = focY - height / 2;
            int newcamW = focX + width / 2;
            int newcamH = focY + height / 2;


            if (focX - width / 2 < 0)
            {
                cameraX = 0;
            }
            else
            {
                cameraX = focX - width / 2;
            }

            if (focY - height / 2 < 0)
            {
                cameraY = 0;
            }
            else
            {
                cameraY = focY - height / 2;
            }
            if (focX + width / 2 >= map.GetWidth())
            {
                cameraX = map.GetWidth() - width;
            }
            if (focY + height / 2 >= map.GetHeight())
            {
                cameraY = map.GetHeight() - height;
            }

            Debug.WriteLine("Cx: " + cameraX + "  Cy:" + cameraY);
        }
        /*
    * if (newcamX < 0)
           {
               cameraX = 0;
           }
           else
           {
               cameraX = newcamX;
           }

          if(newcamY < 0)
           {
               cameraY = 0;
           }
           else
           {
               cameraY = newcamY;
           }
          /*
          if(newcamW >= map.GetWidth())
           {
               cameraX = map.GetWidth() - width;
           }
          else
           {
               cameraX = newcamX;
           }

           if (newcamH >= map.GetHeight())
           {
               cameraY = map.GetHeight() - height;
           }
           else
           {
               cameraY = newcamY;
           }
           */

    }
}
   


