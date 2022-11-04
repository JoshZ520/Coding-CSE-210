class MovingObj {


    virtual public void Draw() {
        // Base game objects do not have anything to draw
    }
    public int Size { get; set; }
    public MovingObj(int size) {

        Size = size;
    }
}