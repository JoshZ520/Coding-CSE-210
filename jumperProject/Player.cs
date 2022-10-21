class Player {
    public string GetGuess() {
        Console.Write("Guess a letter: ");
        string guess = Console.ReadLine() ?? "";
        return guess;
    }

    public bool PlayAgain() {
        Console.WriteLine("Would you like to play again? (enter y or n) ");
        string? choice = Console.ReadLine() ?? "";
        if (choice.ToLower() == "y") {
            return true;
        }
        else {
            return false;
        }
    }
}