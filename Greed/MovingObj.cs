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
    virtual public void Draw() {
        
    }
}