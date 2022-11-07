using Raylib_cs;
using System.Numerics;

class Player: MovingObj {
    public Player(Color color, int size): base(color) {
        Size = size;
    }

    public Vector2 GetStartPos(int ScreenWidth, int ScreenHeight) {
        float x_pos = ScreenWidth / 2;
        float y_pos = ScreenHeight - 20;

        List<float> startPoint = new List<float> {x_pos, y_pos};

        return new Vector2(x_pos, y_pos);
    }
    public override void Draw()
    {
        Raylib.DrawText("#", (int)Position.X, (int)Position.Y, Size, this.Color);
    }
}

class Gems: MovingObj {

    public Gems(Color color, int size): base(color) {
        Size = size;
    }
    public override void Draw()
    {
        Raylib.DrawText("*", (int)Position.X, (int)Position.Y, Size, this.Color);
    }
}

class Rocks: MovingObj {
    
    public int Radius { get; set; }
    public Rocks(Color color, int radius): base(color) {
        Radius = radius;
    }
    override public void Draw() {
        Raylib.DrawCircle(3, 4, 0, this.Color);
    }
    
}