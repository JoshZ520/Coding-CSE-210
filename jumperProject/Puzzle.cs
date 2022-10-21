class Puzzle {

    private string newWord;
    public Puzzle() {
        WordBank listOfWords = new WordBank();

        newWord = listOfWords.GetWord();
    }

    public string GetNewPuzzle() {
        WordBank listOfwords1 = new WordBank();
        string word = listOfwords1.GetWord();
        return word;
    }

    public bool CheckGuess(string guess, string correctAnswer) {
        if (guess == correctAnswer) {
            return true;
        }
        else {
            return false;
        }
    }

    public bool CheckLetter(string guess) {
        foreach (char l in this.newWord) {
            if (l.ToString() == guess) {
                return true;
            }
        }

        return false;
    }

    public List<string> Hide() {
        List<string> blanks = new List<string> {};
        foreach (char l in this.newWord) { 
            blanks.Add("_");
        }

        return blanks;
    }
    public List<string> ShowLetter(bool isRight, string guess, int place, List<string> blanks) {
        if (isRight) {
            int index = place - 1;
            blanks[index] = guess;
            return blanks;
        }
        else {
            return blanks;
        }
    }

}