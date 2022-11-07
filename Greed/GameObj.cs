using Raylib_cs;


class Player: MovingObj {
    public Player(Color color, int size) {
        Size = size;
    }

    public List<float> GetStartPos(int ScreenWidth) {
        float x_pos = ScreenWidth / 2;
        float y_pos = 5;

        List<float> startPoint = new List<float> {x_pos, y_pos};

        return startPoint;
    }
    public override void Draw()
    {
        Raylib.DrawText("#", /*middle*/ -400,/*bottom of screen*/ -400, Size, Color.WHITE);
    }
}

class Gems: MovingObj {

    public Gems(Color color, int size): base(color) {
        Size = size;
    }
    public override void Draw()
    {
        Raylib.DrawText("*", randomX, randomY, 5, Color.WHITE);
    }
}

class Rocks: MovingObj {
    
    public int Radius { get; set; }
    public Rocks(Color color, int radius): base(color) {
        Radius = radius;
    }
    override public void Draw() {
        Raylib.DrawCircle(3, 4, 0, Color.BLUE);
    }
    
}