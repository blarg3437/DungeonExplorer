using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest1.Actors
{
    abstract class Actor
    {
        protected bool IsItem;
        public Rectangle textureRegion{get; protected set;}
        public int x { get; protected set; }
        public int y { get; protected set; }

       
        
    }
}
