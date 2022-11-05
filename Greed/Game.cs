using Raylib_cs;

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
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);



                Raylib.EndDrawing();
            }

    }
}