using Raylib_cs;


class Player: MovingObj {
    int size = 5;

    public List<float> GetStartPos(int ScreenWidth) {
        float x_pos = ScreenWidth / 2;
        float y_pos = 5;

        List<float> startPoint = new List<float> {x_pos, y_pos};

        return startPoint;
    }
}

class Gems: MovingObj {
    
}

class Rocks: MovingObj {
    public void DrawRock() {
        Raylib.DrawCircle(3, 4, 0, Color.BLUE);
    }
    
}