using Raylib_cs;
using System.Numerics;

public class Game {
    public void PlayGame() {
        

        List<Rocks> rocks = new List<Rocks> {};

        List<Gems> gems = new List<Gems> {};

        var ScreenHeight = 800;
        var ScreenWidth = 480;
        var Objects = new List<MovingObj>();
        var Rdm = new Random();

        Player player = new Player(Color.BLACK, 5);
        player.Position = player.GetStartPos(ScreenHeight, ScreenWidth);


        Raylib.InitWindow(ScreenHeight, ScreenWidth, "Greed");
        Raylib.SetTargetFPS(60);
        
        while (!Raylib.WindowShouldClose())
            {

                var whichType = Rdm.Next(2);


                var randomY = Rdm.Next(-2, 2);
                var randomX = Rdm.Next(-2, 2);

                var position = new Vector2(ScreenWidth / 2, 0);


                switch (whichType) {
                    case 0:
                        var Rock = new Rocks(Color.BLUE, 10);
                        Rock.Position = position;
                        Objects.Add(Rock);
                        break;
                    case 1:
                        var Gem = new Gems(Color.PURPLE, 25);
                        Gem.Position = position;
                        Objects.Add(Gem);
                        break;
                } 
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);

                foreach (var obj in Objects) {
                    obj.Draw();
                }

                player.Draw();

                

                Raylib.EndDrawing();

                foreach (var obj in Objects) {
                    obj.Move();
                }
            }

    }
}
