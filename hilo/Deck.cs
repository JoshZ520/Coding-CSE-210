// A class representing the deck of cards that will be used during the
// game.
// Using a list of numbers 1-13 to represent the different cards and 
// using a method to draw a random new card during the game.
class Deck {
    List<string> cards = new List<string>();

    public Deck() {
        for (int i = 1; i <= 13; i++)
        {
            cards.Add(i.ToString());
        }
    }
}