using System.Collections.Generic;

namespace BlackJack
{
    public class Deck
    {
        //What information does a deck of cards has?
        //can deck be a list or does it have to be a class?
        //Properties: 52 cards in a deck with 4 suits and 13 ranks.
        public List<Card> Cards { get; set; }
        //what can a deck do?
        //build() fills the list with 52 cards
        //shuffle() the deck
        //deal() that takes the first card out of the list, removes it and gives it back to the player/dealer.
    }
}