using System;
using System.Net.WebSockets;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using MohawkGame2D;

namespace MohawkGame2D
{
    
public class clickable_tiles
    {
         //remove 
    }


    public class TilesUpdate
    {
        Game lobbymap = new Game();
        //int and vector2 storage
        public int x;
        public int y;
        Vector2 tileR;
        Vector2 tiles;
        Vector2 position;
        public bool istileopen = true;
        public bool istileclosed = false;

        public void tileone()
        {
            //tiles for the game
            Color clicksquare = new Color("#FFDAB9");
            Draw.FillColor = clicksquare;
            Draw.Rectangle(600, 100, 200, 100);
        }

        public void tiletwo()
        {
            //tiles for the game (pink_tile)
            Color pinkclicksquare = new Color("#F2A3A8");
            Draw.FillColor = pinkclicksquare;
            Draw.Rectangle(450, 400, 200, 100);
        }

        public void tilethree()
        {
            //tiles for the game (blue_tile)
            Color blueclicksquare = new Color("#B4E7D9");
            Draw.FillColor = blueclicksquare;
            Draw.Rectangle(40, 100, 200, 100);
        }

       
    }

    //open new "window"
    public class newwindow
    {
        public int x;
        public int y;
        Vector2 tileR;
        Vector2 tiles;
        Vector2 position;
        public bool istileopen = true;
        public bool istileclosed = false;


        public void tilemechanics()
        {
            Game lobbymap = new Game();
            gamemap jumpgame = new gamemap();
            bool showmap = true;

            //make the window appear a different color with the code for map() in it 
            bool isKeyPressed = Input.IsKeyboardKeyPressed(KeyboardInput.B);
            if ( isKeyPressed == true)

            {
                
                
                showmap = false;




            }
            if (showmap )
            {
                lobbymap.Update();
            }
            
            else
            {
                jumpgame.map();
            }

           




        }
    }
}
  
