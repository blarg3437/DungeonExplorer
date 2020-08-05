using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace GameTest1
{
    public abstract class GameScreen
    {
        
        public abstract void Update();
        public abstract void Draw(SpriteBatch spritebatch);

        public virtual void Initialize() { }
        public virtual void Load(ContentManager content) { }
    }
}
