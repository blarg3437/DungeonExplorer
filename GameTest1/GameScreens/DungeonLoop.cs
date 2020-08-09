using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameTest1.Actors;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace GameTest1.GameScreens
{
    class DungeonLoop : GameScreen
    {
        Dungeon currentDungeon;
        
       
        public DungeonLoop()
        {
            currentDungeon = new Dungeon();
        }

        public void OnGameStart()
        {
            StartDungeon();
            
            //just a temporary method until I figure out what Im doing 
        }

        public void StartDungeon()
        {
           currentDungeon.StartDungeon();
           
           
        }
        public override void Load(ContentManager content)
        {
            currentDungeon.LoadTexture(content.Load<Texture2D>("smallertileset"));
            base.Load(content);
        }
        
        public override void Update()
        {
            currentDungeon.Update();
        }
        public override void Draw(SpriteBatch spritebatch)
        {
            currentDungeon.Draw(spritebatch);
        }



    }
}
