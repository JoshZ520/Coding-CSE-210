using Raylib_cs;
using System.Numerics;

public class Game {
    public void PlayGame() {
        

        List<Rocks> rocks = new List<Rocks> {};

        List<Gems> gems = new List<Gems> {};

        var ScreenHeight = 480;
        var ScreenWidth = 800;
        var Objects = new List<MovingObj>();
        var Rdm = new Random();

        
        Player player = new Player(Color.BLACK, 5);
        player.Position = player.GetStartPos(ScreenWidth, ScreenHeight);

        

        Raylib.InitWindow(ScreenWidth, ScreenHeight, "Greed");
        Raylib.SetTargetFPS(60);
        
        while (!Raylib.WindowShouldClose())
            {
                
                var whichType = Rdm.Next(100);

                var Xstart = Rdm.Next(ScreenWidth);

                var randomY = Rdm.Next(2);
                var randomX = Rdm.Next(2);

                var position = new Vector2(Xstart, 0);
            
                

                switch (whichType) {
                    case 0:
                        var Rock = new Rocks(Color.BLUE, 5);
                        Rock.Position = position;
                        Rock.Velocity = new Vector2(0, 1);
                        Objects.Add(Rock);
                        break;
                    case 1:
                        var Rock2 = new Rocks(Color.GOLD, 10);
                        Rock2.Position = position;
                        Rock2.Velocity = new Vector2(0, 1);
                        Objects.Add(Rock2);
                        break;
                    case 2:
                        var Gem = new Gems(Color.PURPLE, 25);
                        Gem.Position = position;
                        Gem.Velocity = new Vector2(0, 1);
                        Objects.Add(Gem);
                        break;
                    case 3:
                        var Gem2 = new Gems(Color.DARKPURPLE, 30);
                        Gem2.Position = position;
                        Gem2.Velocity = new Vector2(0,1);
                        Objects.Add(Gem2);
                        break;
                    default:
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
