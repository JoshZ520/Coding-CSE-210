class WordBank {
    List<string> words = new List<string> {"and", "alphabet", "tiger", "bacon", "twelve", "eaten", "zebra", "lawyer", "jumping", "isaiah", "fourteen", "school", "helpful", "virtuously"};

    public string GetWord() {
        Random rnd = new Random();
        int index = rnd.Next(words.Count);
        string word = words[index];

        return word;
    }

}