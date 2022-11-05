using Raylib_cs;


class Player: MovingObj {
    int size = 5;
}

class Gems: MovingObj {
    public override void Draw()
    {
        Raylib.DrawText("*", RandomX, RandomY, 5, Color.WHITE);
    }
}

class Rocks: MovingObj {
    override public void Draw() {
        Raylib.DrawCircle(3, 4, 0, Color.BLUE);
    }
    
}