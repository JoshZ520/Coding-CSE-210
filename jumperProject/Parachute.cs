class Parachute {
    List<string> Chute = new List<string> {"  ___", "/ ___ \\", "\\     /", " \\   /","   O", "  /|\\", "  / \\ ", "       ", "^^^^^^^"   };
    public void DisplayBoard() {
        foreach (string line in Chute) {
            Console.WriteLine(line);
        }
    }

    public void RemoveLine(bool isWrong) {
        if (isWrong == true) {
            this.Chute.Remove(this.Chute[0]);
        }
        if (this.Chute.Count == 5) {
            this.Chute[0] = "   x";
        }
    }
    public bool CheckGameOver() {
        bool isOver = false;
        if (this.Chute[0] == "   x") {
            isOver = true;
        }

        return isOver;
    }
}