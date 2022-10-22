class Game {

    static void Main(string[] args) {
        bool again = true;
        while (again) {
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
                
                if (isright == false) {
                    bool iswrong = true;
                    parachute.RemoveLine(iswrong);
                }

                if (puzzle.CheckWinner()) {
                    Console.WriteLine("Well Done!");
                    notDone = false;
                }

                if (parachute.CheckGameOver()) {
                    parachute.DisplayBoard();
                    Console.WriteLine("Game Over! better luck next time.");
                    notDone = false;
                }
            }

            again = player.PlayAgain();
        }
    }
 }