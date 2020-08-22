using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameTest1.Actors;
using GameTest1.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameTest1.GameScreens
{
    class Townscreen : GameScreen
    {
        //while in the town, there are multipble textures(scenes) that the player can go to
        Dictionary<string, Scenes> AllScenes;

        Scenes ActiveScene;

        public Townscreen()
        {
            AllScenes = new Dictionary<string, Scenes>();
        }
            
        public void AddScene(string key, Scenes newScene)
        {
            newScene.AddBaseScreen(this);
            AllScenes.Add(key, newScene);
        }

        public void SwitchScene(string key)
        {
            if(AllScenes.ContainsKey(key))
            {
                //add a nice fade
                ActiveScene = AllScenes[key];
            }
        }

        public override void Draw(SpriteBatch spritebatch)
        {
            ActiveScene.Draw(spritebatch);
        }

        public override void Update(GameTime gameTime)
        {
            ActiveScene.Update(gameTime);
        }
    }
}
