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

            //FISHER YATES ALGORITHM 
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
                deck[leftIndex] = rightCard;
            }
            // Console.WriteLine(deck.Count);
            foreach (var card in deck)
            {
                Console.WriteLine(card);//because I have the ToString()
                                        //But if we didn't have the ToString()
                                        // Console.WriteLine($"The {card.Face} of {card.Suit}");
            };

            //Create a player hand
            var player = new Hand();

            //Create a dealer hand
            var dealer = new Hand();
            //Ask the deck for a card and place it in the player hand (and may mean two steps)
            //-the card is equal the 0th index of the deck

            //refactor
            for (var numberOfCardsToDeal = 0; numberOfCardsToDeal < 2; numberOfCardsToDeal++)
            {
                var card = deck[0];
                Console.WriteLine("Firs player card: " + card);
                //-remove that card from the deck list so we don't keep dealing it
                deck.Remove(card);
                Console.WriteLine(deck.Count);
                //-call the 'add card' behavior of the hand and pass it this card
                player.AddCard(card);
                Console.WriteLine(player.CurrentCards.Count);
            }

            //******Start of old way of adding cards to the player
            // var firstPlayerCard = deck[0];
            // Console.WriteLine("Firs player card: " + firstPlayerCard);
            // //-remove that card from the deck list so we don't keep dealing it
            // deck.Remove(firstPlayerCard);
            // Console.WriteLine(deck.Count);
            // //-call the 'add card' behavior of the hand and pass it this card
            // player.AddCard(firstPlayerCard);
            // // Console.WriteLine(player.CurrentCards.Count);

            //Ask the deck for a card and place it in the player hand
            // var secondPlayerCard = deck[0];
            // Console.WriteLine("Second player card: " + secondPlayerCard);
            // deck.Remove(secondPlayerCard);
            // player.AddCard(secondPlayerCard);
            // Console.WriteLine(player.CurrentCards.Count);
            //*****End of old way of adding cards to the player

            //Ask the deck for a card and place it in the dealer hand
            //Ask the deck for a card and place it in the dealer hand
            for (var numberOfCardsToDeal = 0; numberOfCardsToDeal < 2; numberOfCardsToDeal++)
            {
                var card = deck[0];
                Console.WriteLine("Firs player card: " + card);
                //-remove that card from the deck list so we don't keep dealing it
                deck.Remove(card);
                Console.WriteLine(deck.Count);
                //-call the 'add card' behavior of the hand and pass it this card
                dealer.AddCard(card);
                // Console.WriteLine(dealer.CurrentCards.Count);
            }
            // Console.WriteLine();

            //Show the player the cards in their hand and the TotalValue of their Hand
            //Loop through the list of cards in the player's hand
            Console.WriteLine("Player, your cards are: ");
            // //using foreach
            // foreach (var card in player.CurrentCards)
            // {
            //     Console.Write(card);
            //     //when we get dot this dot this dot this, it is an indication we may need a method
            //     if (card != player.CurrentCards[player.CurrentCards.Count - 1])
            //     {
            //         Console.Write(", ");
            //     }
            //     Console.WriteLine();
            // }//end of foreach
            //using for loop
            // for (var index = 0; index < player.CurrentCards.Count; index++)
            // {
            //     var card = player.CurrentCards[index];
            //     Console.Write(card);
            //     //printing all the cards except the last card of the list
            //     if (index != player.CurrentCards.Count - 1)
            //     {
            //         Console.Write(", ");
            //     }
            // }//end of for loop
            // Console.WriteLine();
            // Console.WriteLine();

            //another way to do this
            Console.WriteLine(String.Join(", ", player.CurrentCards));

            //     for every card, printout the to the user the description of the card
            //If they have 'Busted' (hand TotalValue is > 27), then go to step 15.

            //Ask the player if they want to HIT or STAND

            //If HIT 
            //If STAND

        }
        static void DisplayGreeting()
        {
            Console.WriteLine("🂡 Welcome to Blackjack. \nThe first player to come closer to 21 or at 21 wins! Those who go over 21 loose. 🃁");
            Console.WriteLine("Press any key to play.");
            string pressToStartPlaying = Console.ReadLine();
        }
    }

}

