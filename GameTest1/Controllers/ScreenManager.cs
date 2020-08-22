using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace GameTest1.Controllers
{
    class ScreenManager
    {
        Stack<GameScreen> activescreens;
        Dictionary<string, GameScreen> gamescreens;

        public ScreenManager()
        {
            gamescreens = new Dictionary<string, GameScreen>();
            activescreens = new Stack<GameScreen>();
        }

        public void AddScreen(string key, GameScreen newScreen)
        {
           if(!gamescreens.ContainsKey(key))
            gamescreens.Add(key, newScreen);
        }
        public void PushScreen(string gamescreen)
        {
            if(gamescreens.ContainsKey(gamescreen))
            {
                activescreens.Push(gamescreens[gamescreen]);
            }
        }

        public void PopScreen()
        {
            if(activescreens.Count != 0)
            activescreens.Pop();
        }

       public void LoadScreens(ContentManager content)
        {
            foreach (GameScreen item in gamescreens.Values)
            {
                item.Load(content);
            }
        }

        public void Update(GameTime gametime)
        {
            activescreens.Peek().Update(gametime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            activescreens.Peek().Draw(spriteBatch);
        }
    }
}
