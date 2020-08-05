﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameTest1.Actors;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameTest1
{
    /// <summary>
    /// A dungeon gets created with a single texture sheet for the whole dungeon. To switch to a new spritesheet(new textures)
    /// you have to make a new dungeon/load in a new texture
    /// </summary>
    class Dungeon
    {
        Texture2D currenttexture;
        Tile[,] TileMap;
        Random rand;
        int width, height;
        Camera camera;
        Player player;
        public Dungeon()
        {
            rand = new Random();
            player = new Player(this);
            camera = new Camera(player, this);
        }

        public int GetWidth() => width;
        public int GetHeight() => height;
        public void LoadTexture(Texture2D spritesheet)
        {
            currenttexture = spritesheet;
        }
        public void GenerateRandomDungeon()
        {
            //When generating a dungeon, I would specify a few different things with an apply method
            //think of graphics and changing back buffer height and width.
            GenerateDungeonOfSize(rand.Next(20, 30), rand.Next(20, 30));
        }

        public void GenerateDungeonOfSize(int width, int height)
        {
            TileMap = new Tile[width, height];
            this.width = width;
            this.height = height;
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int tiletype = rand.Next(0, 4);
                    switch(tiletype)
                    {
                        case 0:
                            //this will set the ground as walkable
                            TileMap[x, y] = new Tile(tiletype, true);
                            break;

                        default:
                            //this is the default case where the tile wont be walkable
                            TileMap[x, y] = new Tile(tiletype, false);
                            break;
                    }
                    // remember to set the walkable tiles correctly
                }
            }
        }

        public void CreateDungeonFromFile(string Directory)
        {
            //this will be used to load up custom dungeons for boss fights and stuff
        }
        
        public void Update()
        {
            camera.UpdateView();
            player.Update();
        }
        public void Draw(SpriteBatch spritebatch)
        {
            for (int y = camera.cameraY; y < camera.cameraY + camera.height; y++)
            {
                for (int x = camera.cameraX; x < camera.cameraX + camera.width; x++)
                {               
                    spritebatch.Draw(currenttexture,
                        new Rectangle((x - camera.cameraX ) * Global.TexSize, (y - camera.cameraY) * Global.TexSize, Global.TexSize, Global.TexSize),
                        new Rectangle(TileMap[x, y].TileId * 32, 0, 32, 32),
                        Color.White);
                }
            }



        }
    }
}
