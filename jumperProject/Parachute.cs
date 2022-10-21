class Parachute {
    List<string> Chute = new List<string> {"  ___", "/ ___ \\", "\\     /", " \\   /","   O", "  /|\\", "  / \\ ", "       ", "^^^^^^^"   };
    public void DisplayBoard() {
        foreach (string line in Chute) {
            Console.WriteLine(line);
        }
    }

    public void RemoveLine( bool isWrong) {
        if (this.Chute.Count == 5) {
            this.Chute[0] = "   x";
        }
        else if (isWrong) {
            this.Chute.Remove(this.Chute[0]);
        }
    }
}