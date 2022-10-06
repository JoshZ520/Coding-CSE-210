// A class representing the deck of cards that will be used during the
// game.
// Using a list of numbers 1-13 to represent the different cards and 
// using a method to draw a random new card during the game.
class Deck {
    List<Card> cards = new List<Card>();

    public Deck() {
        for (int i = 1; i <= 13; i++)
        {
            cards.Add(new Card(i));
            
        }
    }

// Method to pick a rand card from the deck that is different than
// the previous
    public Card DrawCard() {
        Random rnd = new Random();
        Card card = cards[rnd.Next(13) - 1];
        return card;
    }

}