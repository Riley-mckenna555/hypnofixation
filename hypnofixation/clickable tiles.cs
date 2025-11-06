using System;
using System.Net.WebSockets;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using MohawkGame2D;

namespace MohawkGame2D
{
    
public class clickable_tiles
    {
        // Fixes for CS8981 and IDE1006: Rename 'tilesupdate' to 'TilesUpdate' and remove invalid constructor parentheses.
    }


    public class TilesUpdate
    {
        public int x;
        public int y;
        Vector2 tileR;
        Vector2 tiles;
        Vector2 position;
        public bool istileopen = true;
        public bool istileclosed = false;

        public void tileone()
        {
            Color clicksquare = new Color("#FFDAB9");
            Draw.FillColor = clicksquare;
            Draw.Rectangle(600, 100, 200, 100);
        }

        public void tiletwo()
        {
            Color pinkclicksquare = new Color("#F2A3A8");
            Draw.FillColor = pinkclicksquare;
            Draw.Rectangle(450, 400, 200, 100);
        }

        public void tilethree()
        {
            Color blueclicksquare = new Color("#B4E7D9");
            Draw.FillColor = blueclicksquare;
            Draw.Rectangle(40, 100, 200, 100);
        }

        public void tilemechanics()
        {
            // Handle click: detect a click near the tile center and open the tile
            if (Input.IsMouseButtonPressed(MouseInput.Left))
            {
                Vector2 mouseposition = Input.GetMousePosition();
                Vector2 fromTileToMouseClick = mouseposition - position;
                float distanceOnClick = fromTileToMouseClick.Length();
                if (distanceOnClick > 0f)
                {
                    istileopen = true;
                }
            }

            if (istileopen)
            {


                Vector2 mouseposition = Input.GetMousePosition();
                Vector2 fromEyeToMouse = mouseposition - position;
                float distancetomouse = fromEyeToMouse.Length();

                if (distancetomouse > 0f)
                {
                    Vector2 directiontomouse = Vector2.Normalize(fromEyeToMouse);

                    // Convert the Vector2 comparison to a scalar by taking the length of the difference.
                    // This fixes CS0019 by comparing float to float.
                    float radiusDiff = (tileR - tiles).Length();

                    Vector2 tileposition;
                    if (distancetomouse < radiusDiff)
                    {
                        tileposition = mouseposition;
                    }
                    else
                    {
                        // Use the computed scalar 'radiusDiff' instead of undefined names.
                        tileposition = position + directiontomouse * radiusDiff;
                    }

                    // TODO: apply tileposition to your tile transform/state as needed
                }
                if (istileclosed)
                {
                    Window.ClearBackground(Color.OffWhite);

                }
            }
        }
    }


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
            // Handle click: detect a click near the tile center and open the tile
            if (Input.IsMouseButtonPressed(MouseInput.Left))
            {
                Vector2 mouseposition = Input.GetMousePosition();
                Vector2 fromTileToMouseClick = mouseposition - position;
                float distanceOnClick = fromTileToMouseClick.Length();
                if (distanceOnClick > 0f)
                {
                    istileopen = true;
                }
            }

            if (istileopen)
            {


                Vector2 mouseposition = Input.GetMousePosition();
                Vector2 fromEyeToMouse = mouseposition - position;
                float distancetomouse = fromEyeToMouse.Length();

                if (distancetomouse > 0f)
                {
                    Vector2 directiontomouse = Vector2.Normalize(fromEyeToMouse);

                    // Convert the Vector2 comparison to a scalar by taking the length of the difference.
                    // This fixes CS0019 by comparing float to float.
                    float radiusDiff = (tileR - tiles).Length();

                    Vector2 tileposition;
                    if (distancetomouse < radiusDiff)
                    {
                        tileposition = mouseposition;
                    }
                    else
                    {
                        // Use the computed scalar 'radiusDiff' instead of undefined names.
                        tileposition = position + directiontomouse * radiusDiff;
                    }

                    // TODO: apply tileposition to your tile transform/state as needed
                }
                if (istileclosed)
                {
                    Window.ClearBackground(Color.OffWhite);

                }

                else if (istileopen)
                {

                }

            }
        }
    }
}
  
