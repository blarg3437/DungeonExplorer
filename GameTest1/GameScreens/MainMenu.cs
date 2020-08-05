using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GameTest1.GameScreens
{
    class MainMenu : GameScreen
    {
        public delegate void OnButtonClick();
        public static event OnButtonClick StartGame;

        Texture2D background;
        public override void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(background, Vector2.Zero, new Rectangle(0, 0, 1920, 1080), Color.White);
        } 

        public override void Load(ContentManager content)
        {
            background = content.Load<Texture2D>("clouds over ocean");
            base.Load(content);
        }
        public override void Update()
        {

            KeyboardState key = Keyboard.GetState();
            if(key.IsKeyDown(Keys.Enter))
            {
                StartGame();
                Global.TheScreenManager.PopScreen();
            }
        }
    }
}
