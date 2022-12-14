using System;
using System.Collections.Generic;

namespace BlackJack
{
    public class Deck
    {
        //What information does a deck of cards has?
        //can deck be a list or does it have to be a class?
        //Properties: 52 cards in a deck with 4 suits and 13 ranks.
        //We are promoting a the old list of cards to a class. var deck = new List<Card>();
        //AKA encapsulation.
        //
        public List<Card> Cards { get; set; } = new List<Card>();
        //Behaviors: 
        //1-Initialize the deck

        //Every time we 'new Deck()' please initialize the deck and shuffle it.
        public Deck()
        {
            Initialize();
            Shuffle();
        }
        //initialize a deck of 52 cards
        public void Initialize()
        {
            //Suits is a list of "Club", "Diamond", "Heart", or "Spade"
            var suits = new List<string>() { "Club", "Diamond", "Hearts", "Spades" };
            //Faces is a list of 2,3,4,5,6,7,8,9,10,Jack. Queen, King or Ace.
            var faces = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            //Go trough all of the suits one at a time and in order.
            //Get the current suit
            foreach (var suit in suits)//foreach is chosen because I may not need the index of the element of the if. If I need it, I will change it to a for loop.
            {

                //Go through all of the faces one at a time and in order
                //Get the current face
                foreach (var face in faces)
                {
                    //With the current suit and the current face, make a new card
                    var newCard = new Card()
                    {
                        //do I want to use the constructor style or the initialize style?
                        //Initializer style bellow
                        Suit = suit,
                        Face = face,

                    };
                    //Add that card to the list of cards
                    Cards.Add(newCard);
                }
            }
        }
        //Shuffle
        public void Shuffle()
        {
            //Ask the deck to make a new shuffled 52 cards

            //FISHER YATES ALGORITHM 
            // numberOfCards = length of our deck
            var numberOfCards = Cards.Count;

            // for rightIndex from numberOfCards - 1 down to 1 do:
            for (var rightIndex = numberOfCards - 1; rightIndex > 1; rightIndex--)
            {
                //   leftIndex = random integer that is greater than or equal to 0 and LESS than rightIndex. See the section "How do we get a random integer")
                var randomNumberGenerator = new Random();
                var leftIndex = randomNumberGenerator.Next(rightIndex);
                //   Now swap the values at rightIndex and leftIndex by doing this:
                //     leftCard = the value from Cards[leftIndex]
                var leftCard = Cards[leftIndex];
                //     rightCard = the value from Cards[rightIndex]
                var rightCard = Cards[rightIndex];
                //     Cards[rightIndex] = leftCard
                Cards[rightIndex] = leftCard;
                //     Cards[leftIndex] = rightCard
                Cards[leftIndex] = rightCard;
            }
        }

        //Deal a single card.
        public Card Deal()
        {
            //Remove the first card from the deck and return it.
            var topCard = Cards[0];
            Cards.RemoveAt(0);
            return topCard;
        }

        //Deal multiple cards
        public List<Card> DealMultipleCards(int numberOfCardsToDeal)
        {
            var multipleCards = new List<Card>();
            for (int count = 0; count < numberOfCardsToDeal; count++)
            {
                //Reusing Deal() Method
                Card dealtCard = Deal();
                multipleCards.Add(dealtCard);
            }
            return multipleCards;
        }
        //player is just an instance of the Hand class
        //dealer is just an instance of the Hand class
    }
}