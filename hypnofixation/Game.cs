// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;
using MohawkGame2D;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    /// 

   
    public class Game
    {

        Vector2[] positions = [
           new Vector2 (500,100),
            new Vector2 (50,50),
            new Vector2 (350,300),
            new Vector2 (75,325),
            new Vector2 (275,40),
            new Vector2 (225,375),
            ];
        int[] radii;
        // Place your variables here:
        int r = 200;
        int x = 200;
        int y = 200;
        Vector2 position;

      clickable_tiles tiles = new clickable_tiles ();
        TilesUpdate tiles123 = new TilesUpdate ();
        newwindow windowopen = new newwindow();
        gamemap jumpgamemap = new gamemap();

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("hypnofixation");
            Window.SetSize(800, 600);
            radii = new int[positions.Length];

            for (int i = 0; i < radii.Length; i++)
            {
                radii[i] = Random.Integer(10, 50);
            }

          
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {

            Window.ClearBackground(Color.OffWhite);
           
            //main menu map
            Color bluesky = new Color("#4B9CD3");
            Draw.FillColor = bluesky;
            Draw.Square(0, 0, 800);

            Color building3 = new Color("#F76C6C");
            Draw.FillColor = building3;
            Draw.Rectangle(150, 0, 200, 500);

            Color building = new Color("#E1E1E1");
            Draw.FillColor = building;
            Draw.Rectangle(50, 50, 100, 400);

            Color building2 = new Color("#2F343B");
            Draw.FillColor = building2;
            Draw.Rectangle(130, 100, 100, 400);

            Color building4 = new Color("#A4C8E1");
            Draw.FillColor = building4;
            Draw.Rectangle(300, 100, 90, 500);

            Color building5 = new Color("#3B4E8E");
            Draw.FillColor = building5;
            Draw.Rectangle(350, 150, 90, 500);

            Color sun = new Color("#F6C03F");
            Draw.FillColor = sun;
            Draw.Circle(550, 50, 60);

            Color evendarkergrass = new Color("#4F6646");
            Draw.FillColor = evendarkergrass;
            Draw.Circle(660, 700, 500);

            Color darkergrass = new Color("#749B64");
            Draw.FillColor = darkergrass;
            Draw.Circle(200, 900, 700);

            Color grasswithshadow = new Color("#88BC73");
            Draw.FillColor = grasswithshadow;
            Draw.Circle(100, 660, 400);

            Color greengrass = new Color("#A2D98B");
            Draw.FillColor = greengrass;
            Draw.Circle(660, 750, 500);

            for (int i = 0; i < positions.Length; i++) // or i += 1
            {
                Vector2 position = positions[i];
                int radius = radii[i];
                float corneaR = radius;
                float irisR = radius * 0.7f;
                float pupilR = radius * 0.35f;
                DrawEyeball(position, corneaR, irisR, pupilR);


            }


            Color clicksquare = new Color("#FFDAB9");
            Draw.FillColor = clicksquare;

            tiles123.tileone();

            tiles123.tiletwo();

            tiles123.tilethree();

            windowopen.tilemechanics();

            
        }


        void makenewwindow()
        {
            if (Input.IsMouseButtonPressed(MouseInput.Left))
            {
                windowopen.tilemechanics();

                tiles123.tileone(); tiles123.tiletwo();

                Window.ClearBackground(Color.OffWhite);

            }
        }


        void DrawEyeball(Vector2 eyeposition, float corneaR, float irisR, float pupilR)
        {
            //get both X and Y coordinates as a vector
            Vector2 mouseposition = Input.GetMousePosition();
            //to go from A TO B, we do B minus A

            Vector2 vectorfromeyetomouse = mouseposition - eyeposition;
            //split vector into direction and magnitude
            Vector2 direction = Vector2.Normalize(vectorfromeyetomouse);
            //
            float distance = vectorfromeyetomouse.Length();
            //calculate where iris and pupil need to go 
            Vector2 irisposition = eyeposition + direction * (corneaR - irisR); //pixils

            //cornea
            Draw.LineSize = 1;
            Draw.LineColor = Color.Black;
            Draw.FillColor = Color.White;
            Draw.Circle(eyeposition, corneaR);
            //iris
            Draw.FillColor = Color.Blue;
            Draw.Circle(irisposition, irisR);
            //pupil
            Draw.FillColor = Color.Black;
            Draw.Circle(irisposition, pupilR);

        }


        TilesUpdate tileclicker = new TilesUpdate();
        




    }
}
