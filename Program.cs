using System;
using System.Collections.Generic;
using BlackJack;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            //premature optimization is the root of all evil
            //Welcome message and description about the game.
            DisplayGreeting();

            //Make a list of cards - give it a name of 'deck'
            var deck = new List<Card>();

            //test debug line of code
            Console.WriteLine(deck.Count);//starts with the count of zero

            //Suits is a list of "Club", "Diamond", "Heart", or "Spade"
            var suits = new List<string>() { "Club", "Diamond", "Hearts", "Spades" };
            //Faces is a list of 2,3,4,5,6,7,8,9,10,Jack. Queen, King or Ace.
            var faces = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "Kind" };

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
                    deck.Add(newCard);
                }
            }
            //Ask the deck to make a new shuffled 52 cards

            // numberOfCards = length of our deck
            var numberOfCards = deck.Count;

            // for rightIndex from numberOfCards - 1 down to 1 do:
            for (var rightIndex = numberOfCards - 1; rightIndex > 1; rightIndex--)
            {
                //   leftIndex = random integer that is greater than or equal to 0 and LESS than rightIndex. See the section "How do we get a random integer")
                var randomNumberGenerator = new Random();
                var leftIndex = randomNumberGenerator.Next(rightIndex);
                //   Now swap the values at rightIndex and leftIndex by doing this:
                //     leftCard = the value from deck[leftIndex]
                var leftCard = deck[leftIndex];
                //     rightCard = the value from deck[rightIndex]
                var rightCard = deck[rightIndex];
                //     deck[rightIndex] = leftCard
                deck[rightIndex] = leftCard;
                //     deck[leftIndex] = rightCard
                deck[leftIndex] = leftCard;
            }
            //Create a player hand
            //Create a dealer hand
            //Ask the deck for a card and place it in the player hand
            //Ask the deck for a card and place it in the player hand
            //Ask the deck for a card and place it in the dealer hand
            //Ask the deck for a card and place it in the dealer hand
            //Show the plater the cards in their hand and the TotalValue of their Hand
            //If they have 'Busted' (hand TotalValue is > 27), then go to step 15.
            //Ask the player if they want to HIT or STAND
            //If HIT 

            //FISHER YATES ALGORITHM 



        }
        static void DisplayGreeting()
        {
            Console.WriteLine("🂡 Welcome to Blackjack. \nThe first player to come closer to 21 or at 21 wins! Those who go over 21 loose. 🃁");
            Console.WriteLine("Press any key to play.");
            string pressToStartPlaying = Console.ReadLine();
        }
    }

}

