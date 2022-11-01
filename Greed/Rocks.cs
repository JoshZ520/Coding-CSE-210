using Raylib_cs;


class Rocks: MovingObj {
    public void DrawRock() {
        Raylib.DrawCircle(3, 4, 0, Color.BLUE);
    }
    
}
//Rocks rock = new Rocks();