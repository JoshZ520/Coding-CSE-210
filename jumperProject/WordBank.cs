class WordBank {
    List<string> words = new List<string> {"and", "alphabet", "alex", "josh", "tiger", "bacon", "twelve", "eaten", "zebra", "lawyer", "whosoever", "jumping", "jupiter", "isaiah", "fourteen", "school", "helpful", "notebook", "virtuously", "establishment", "sweater", "moving"};

    public string GetWord() {
        Random rnd = new Random();
        int index = rnd.Next(words.Count);
        string word = words[index];

        return word;
    }

}