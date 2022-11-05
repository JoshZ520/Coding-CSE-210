using Raylib_cs;
using System.Numerics;

class Game {
    public void PlayGame() {
        Player player = new Player();

        List<Rocks> rocks = new List<Rocks> {};

        List<Gems> gems = new List<Gems> {};

        var ScreenHeight = 800;
        var ScreenWidth = 480;

        Raylib.InitWindow(ScreenHeight, ScreenWidth, "Greed");
        Raylib.SetTargetFPS(60);
        
        while (!Raylib.WindowShouldClose())
            {

                var whichType = Random.Next(2);


                var randomY = Random.Next(-2, 2);
                var randomX = Random.Next(-2, 2);



                switch (whichType) {
                    case 0:
                        var Rock = new Rocks(Color.BLUE)
                        break;
                    case 1:
                        break;
                } 
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);



                Raylib.EndDrawing();
            }

    }
}
