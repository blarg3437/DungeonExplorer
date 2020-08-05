using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace GameTest1.Menu
{
    class Button
    {
        Texture2D unpressedTexture;
        Texture2D PressedTexture;

        int x, y, width, height;

        public bool IsMouseWithin(int x, int y)
        {
            //check
            return true;
        }
    }
}
