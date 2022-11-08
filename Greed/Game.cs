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
                int count = 0; 
                while (count != 300) {
                count += 1;
                }
                var whichType = Rdm.Next(2);


                var randomY = Rdm.Next(2);
                var randomX = Rdm.Next(2);

                var position = new Vector2(ScreenWidth, 0);
                var randomPos = new Vector2((int)ScreenWidth, randomY);

                
                if (count == 300) {

                    switch (whichType) {
                        case 0:
                            var Rock = new Rocks(Color.BLUE, 10);
                            Rock.Position = randomPos;
                            Rock.Velocity = new Vector2(0, 1);
                            Objects.Add(Rock);
                            count = 0;
                            break;
                        case 1:
                            var Gem = new Gems(Color.PURPLE, 25);
                            Gem.Position = position;
                            Gem.Velocity = new Vector2(0, randomY);
                            Objects.Add(Gem);
                            count = 0;
                            break;
                    } 
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
