class WordBank {
    List<string> words = new List<string> {"and", "alphabet", "alex", "josh", "tiger", "tree", "bacon", "twelve", "eaten", "zebra", "lawyer", "whosoever", "jumping", "jupiter", "isaiah", "fourteen", "school", "helpful", "notebook", "virtuously", "establishment", "sweater", "moving", "giant"};

    public string GetWord() {
        Random rnd = new Random();
        int index = rnd.Next(words.Count);
        string word = words[index];

        return word;
    }

}