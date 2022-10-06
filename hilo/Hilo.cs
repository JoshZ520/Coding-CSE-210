class Hilo {
// Program will run from here.
 static void Main(string[] args) {

    Deck deck = new Deck();
    

    int score = 300;

    Card card = deck.DrawCard();
    Card nextCard = deck.DrawCard();
    Console.WriteLine($"the card is: {card}");

    Console.Write("Higher or Lower? (h/l): ");
    string? playerGuess = Console.ReadLine();
    bool isRight = CheckGuess(playerGuess, card, nextCard);

    score = GetPoints(score, isRight);
    Console.WriteLine($"Your score is: {score}");

    Console.Write("Play Again? (y/n): ");
    string? playAgain = Console.ReadLine();
    
 } 

static bool CheckGuess(string? playerGuess, Card card, Card nextCard) {
    
    return true;
}
static int GetPoints(int currentPoints, bool isRight) {
    currentPoints += 100;
    return 2;
}



}