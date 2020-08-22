using GameTest1.Actors;
using GameTest1.GameScreens;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GameTest1.Content
{
    class Scenes
    {
        Texture2D Background;
        Townscreen BaseScreen;
        List<Entity> Entities;

        //I guess that within each scene, there would be a collison box that would teleport you to the next world
        public Scenes()
        {
            Entities = new List<Entity>();
        }

        public void AddBaseScreen(Townscreen basescreen)
        {
            BaseScreen = basescreen;
        }
        public void AddBackground(Texture2D newBack)
        {
            Background = newBack;
        }
        public void AddCharacters(params Entity[] actors)
        {
            for (int i = 0; i < actors.Length; i++)
            {
                Entities.Add(actors[i]);
            }
        }


        public void AddCharacter(Entity newEntity)
        {
            Entities.Add(newEntity);
        }

        public void Update(GameTime gameTime)
        {

        }

        public void Draw(SpriteBatch spritebatch)
        {

        }
    }
}
