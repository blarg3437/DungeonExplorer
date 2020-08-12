using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameTest1.Actors;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
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
        Texture2D itemTexSheet;

        Texture2D playerTex;

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
        public void LoadTexture(ContentManager manager)
        {
            currenttexture = manager.Load<Texture2D>("smallertileset");
            playerTex = manager.Load<Texture2D>("Mechanic");
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
            player.setPos(2, 2);
        }

        public void CreateDungeonFromFile(string Directory)
        {
            //this will be used to load up custom dungeons for boss fights and stuff
        }
        public void StartDungeon()
        {
            GenerateDungeonOfSize(35, 35);
            AddActorToMap(player, 0, 0);
            //next step is to draw the actors
        }
        public void AddActorToMap(Actor newActor, int x, int y)
        {
            if(newActor != null)
            {
                if(x <= width && x >= 0)
                {
                    if(y <= height && y >= 0)
                    {
                        TileMap[x,y].setActor(newActor);//returns false if occupied, but doesnt handle it
                    }
                }
            }
        }
        
        public void RemoveActorFromMap(int x, int y)
        {
            TileMap[x, y].setActor(null);
            

            
        }
        public void Update()
        {
            player.Update();
            camera.UpdateView();
            
        }
        public void Draw(SpriteBatch spritebatch)
        {
            for (int y = camera.cameraY; y < (camera.cameraY + camera.height) ; y++)
            {
                for (int x = camera.cameraX; x < (camera.cameraX + camera.width); x++)
                {               
                   
                    spritebatch.Draw(currenttexture,
                        new Rectangle((x - camera.cameraX ) * Global.TexSize, (y - camera.cameraY) * Global.TexSize, Global.TexSize, Global.TexSize),
                        new Rectangle(TileMap[x, y].TileId * 32, 0, 32, 32),
                        Color.White);
                }
            }

            //this will be where the entity drawcall is
            spritebatch.Draw(playerTex, new Rectangle((player.x - camera.cameraX) * Global.TexSize, (player.y-camera.cameraY) * Global.TexSize, Global.TexSize, Global.TexSize), Color.White);
           
            Debug.WriteLine("X: " + player.x + " Y: " + player.y + " CX:" + camera.cameraX + " CY: " + camera.cameraY);
        }
    }
}

