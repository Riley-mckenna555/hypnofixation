using System;
using System.Numerics;
using MohawkGame2D;

namespace MohawkGame2D
{

    public class gamemap
    {

        public void map()
        {
            Window.ClearBackground(Color.Black);

            Color backwall = new Color("#e4e6a8");
            Draw.FillColor = backwall;
            Draw.Rectangle(0,0,7000,8000);

            
            Color floor = new Color("#c6c58b");
            Draw.FillColor = floor;
            Draw.Rectangle(-200, 500, 400, 700);

            Draw.FillColor = floor;
            Draw.Rectangle(700, 500, 400, 100);

            

            

        }
         
    }



}

