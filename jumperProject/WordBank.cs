class WordBank {
    List<string> words = new List<string> {"and", "alphabet", "tiger", "bacon", "twelve", "eaten", "zebra", "lawyer", "jumping", "jupiter", "isaiah", "fourteen", "school", "helpful", "virtuously", "establishment"};

    public string GetWord() {
        Random rnd = new Random();
        int index = rnd.Next(words.Count);
        string word = words[index];

        return word;
    }

}