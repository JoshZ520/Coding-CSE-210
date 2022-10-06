class Hilo {
// Program will run from here.
 static void Main(string[] args) {

    Deck deck = new Deck();
    

    int score = 300;
    bool cont = true;

    while (cont) {
        int card = deck.DrawCard();
        int nextCard = deck.DrawCard();
        Console.WriteLine($"the card is: {card}");

        Console.Write("Higher or Lower? (h/l): ");
        string? playerGuess = Console.ReadLine();

        if (card == nextCard) {
            score += 0;
        }
        
        else {
            bool isRight = CheckGuess(playerGuess, card, nextCard);
            score = GetPoints(score, isRight);
        }

        Console.WriteLine($"The next card was: {nextCard}");

        Console.WriteLine($"Your score is: {score}");

        if (score < 1) {
            Console.WriteLine("Game Over. Better Luck Next time");
            cont = false;
        }
        
        Console.Write("Play Again? (y/n): ");
        string? playAgain = Console.ReadLine();
        cont = PlayAgain(playAgain);
        
    }
    
 } 

static bool CheckGuess(string? playerGuess, int card, int nextCard) {
    if (playerGuess == "h" && card < nextCard) {
        return true;
    }
    else if (playerGuess == "l" && card > nextCard) {
        return true;
    }
    return false;
}
static int GetPoints(int currentPoints, bool isRight) {
    if (isRight) {
        currentPoints += 100;
    }

    else {
        currentPoints -= 75;
    }
    
    return currentPoints;
}

static bool PlayAgain(string? cont) {
    if (cont == "y") {
        return true;
    }
    else {
        return false;
    }
}

}