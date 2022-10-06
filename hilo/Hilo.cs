class Hilo {
// Program will run from here.
 static void Main(string[] args) {

    Deck deck = new Deck();
    
    Card card = deck.DrawCard();

    int score = 300;

    Console.WriteLine($"the card is: {card}");

    Console.Write("Higher or Lower? (h/l): ");
    string? playerGuess = Console.ReadLine();
    
    score = GetPoints(score, isRight);
    Console.WriteLine($"Your score is: {score}");
    
    Console.Write("Play Again? (y/n): ");
    string? playAgain = Console.ReadLine();
    
 } 

static bool GuessRight(string playerGuess, int card) {
    if (playerGuess) {
    }
    return true;
}
static int GetPoints(int currentPoints, bool isRight) {
    currentPoints += 100;
    return 2;
}



}
