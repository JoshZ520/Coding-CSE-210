using Raylib_cs;


class Player: MovingObj {
    int size = 5;
}

class Gems: MovingObj {
    
}

class Rocks: MovingObj {
    public void DrawRock() {
        Raylib.DrawCircle(3, 4, 0, Color.BLUE);
    }
    
}