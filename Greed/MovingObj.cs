class MovingObj {
    
    public int Size { get; set; }
    public int Speed { get; set; }
    public MovingObj(int size = 1, int speed = 1) {

        Size = size;
        Speed = speed;
    }


    public void MoveUp() {
        
    }
    public void MoveDown() {

    }
    public void MoveRight() {

    }
    public void MoveLeft() {

    }


    // I copied this from one of the things that we had in the teams that I think we can use to make our 
    // stuff move using the keyboard class. I pastsed it here as a reference for now.
    // if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)) {
    //     BallPosition.X += BallMovementSpeed;
    // }

    // if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)) {
    //     BallPosition.X -= BallMovementSpeed;
    // }

    // if (Raylib.IsKeyDown(KeyboardKey.KEY_UP)) {
    //     BallPosition.Y -= BallMovementSpeed;
    // }

    // if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN)) {
    //     BallPosition.Y  += BallMovementSpeed;
    // }

}