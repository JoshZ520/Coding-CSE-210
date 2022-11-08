using Raylib_cs;

class Points {
    private int score;

    public void SetScore() {
        this.score = 0;
    }

    public int AddPoint() {
        this.score += 10;
        return this.score;
    }
    public int RemovePoint() {
        this.score -= 10;
        return this.score;
    }

    public void DisplayPoints() {
        Raylib.DrawText($"Score: {this.score}", 12, 12, 20, Color.BLACK);
;
    }
}

class Scoreboard {
    public void DisplayScore(Points score) {
        score.DisplayPoints();
    }
}