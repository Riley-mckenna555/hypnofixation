using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using MohawkGame2D;

namespace MohawkGame2D
{
    public class clickable_tiles
    {
        public void tilesupdate()
            {
           
            Color clicksquare = new Color("#FFDAB9");
            Draw.FillColor = clicksquare;
            Draw.Rectangle(600, 100, 200, 100);

            Color pinkclicksquare = new Color("#F2A3A8");
            Draw.FillColor = pinkclicksquare;
            Draw.Rectangle(450, 400, 200, 100);

            Color blueclicksquare = new Color("#B4E7D9");
            Draw.FillColor = blueclicksquare;
            Draw.Rectangle(40, 100, 200, 100);
           
            



        }
    }
    

}
  
