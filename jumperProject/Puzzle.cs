class Puzzle {

    public string newWord;
    public Puzzle() {
        WordBank listOfWords = new WordBank();

        string newWord = listOfWords.GetWord();
    }

}