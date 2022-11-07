using Raylib_cs;
using System.Numerics;

public class Game {
    public void PlayGame() {
        Player player = new Player();

        List<Rocks> rocks = new List<Rocks> {};

        List<Gems> gems = new List<Gems> {};

        var ScreenHeight = 800;
        var ScreenWidth = 480;
        var Objects = new List<MovingObj>();
        var Random = new Random();

        Raylib.InitWindow(ScreenHeight, ScreenWidth, "Greed");
        Raylib.SetTargetFPS(60);
        
        while (!Raylib.WindowShouldClose())
            {

                var whichType = Random.Next(2);

                var randomY = Random.Next(-2, 2);
                var randomX = Random.Next(-2, 2);

                var position = new Vector2(ScreenWidth / 2, ScreenHeight);


                switch (whichType) {
                    case 0:
                        var Rock = new Rocks(Color.BLUE, 5);
                        rocks.Position = position;
                        Objects.Add(Rock);
                        break;
                    case 1:
                        var Gem = new Gems(Color.PURPLE, 5);
                        gems.Position = position;
                        Objects.Add(Gem);
                        break;
                } 
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);

                foreach (var obj in Objects) {
                    obj.Draw();
                }



                Raylib.EndDrawing();
            }

    }
}
