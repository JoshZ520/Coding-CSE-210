class Puzzle {

    // attribute representing the word that is currently being used as the puzzle
    private string currentWord;

    // attribute represting the current word, but as a list of "blanks" (underscores) 
    // to be replaced as letters are guessed. See the Hide() method.
    private List<string> blanks = new List<string> {};
    public Puzzle() {
        WordBank listOfWords = new WordBank();

        currentWord = listOfWords.GetWord();
    }

    public string GetCurrentWord() {
        return this.currentWord;
    }

    // public List<string> GetWordList() {
    //     List<string> wordList = this.currentWord.Split();
    //     return wordList;
    // }

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
        foreach (char l in this.currentWord) {
            if (l.ToString() == guess) {
                return true;
            }
        }

        return false;
    }

    public void Hide() {
        foreach (char l in this.currentWord) { 
            blanks.Add("_");
        }
    }
    public List<string> ShowLetter(bool isRight, string guess) {
        if (isRight) {
            int index = 0;
            foreach (char l in this.currentWord) {
                if (l.ToString() == guess) {
                    int letterIndex = index;
                    this.blanks[letterIndex] = guess;
                }
                index += 1;
            }
            return this.blanks;
        }
        else {
            return this.blanks;
        }
    }

    public void ShowCurrentWord() {
        foreach (string letter in this.blanks) {
            Console.Write(letter);
        }
        Console.WriteLine();
    }


    public bool CheckWinner() {
        string wordList = string.Join("", this.blanks);
        if (wordList == this.currentWord) {
            return true;
        }
        else {
            return false;
        }
    }
}