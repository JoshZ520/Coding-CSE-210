using Raylib_cs;


class Player: MovingObj {
    int size = 5;

    public List<float> GetStartPos(int ScreenWidth) {
        float x_pos = ScreenWidth / 2;
        float y_pos = 5;

        List<float> startPoint = new List<float> {x_pos, y_pos};

        return startPoint;
    }
    public override void Draw()
    {
        Raylib.DrawText("#", /*middle*/ -400,/*bottom of screen*/ -400, 5, Color.WHITE);
    }
}

class Gems: MovingObj {
    public override void Draw()
    {
        Raylib.DrawText("*", randomX, randomY, 5, Color.WHITE);
    }
}

class Rocks: MovingObj {
    override public void Draw() {
        Raylib.DrawCircle(3, 4, 0, Color.BLUE);
    }
    
}