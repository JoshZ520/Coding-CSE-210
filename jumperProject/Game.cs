class Game {

    static void Main(string[] args) {

        Player player = new Player();

        Parachute parachute = new Parachute();

        Puzzle puzzle = new Puzzle();
        puzzle.Hide();
    
        Console.WriteLine("Welcome to Jumper! You will be given a random word from our WordBank.");
        Console.WriteLine("The word will be hidden from you, and you will have to guess it letter by letter, hangman style");
        Console.WriteLine();
        bool notDone = true;
        while (notDone) {
            puzzle.ShowCurrentWord();

            parachute.DisplayBoard();
            Console.WriteLine();

            string guess = player.GetGuess();
            bool isright = puzzle.CheckLetter(guess);

            puzzle.ShowLetter(isright, guess);
        }
    }

    public bool CheckWinner(Puzzle puzzle, string guess) {
        bool isWinner = puzzle.CheckGuess(guess, puzzle.GetCurrentWord());
        return isWinner;
    }
 }