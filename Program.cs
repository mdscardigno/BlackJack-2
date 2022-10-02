using System;
using System.Collections.Generic;
using BlackJack;

namespace Blackjack
{
    class Program
    {
        //static methods are any methods that does not require an instance of the class; for example: new Program. 
        static void PlayTheGame()
        {

            //premature optimization is the root of all evil
            //Welcome message and description about the game.
            DisplayGreeting();

            //Make a list of cards - give it a name of 'deck'
            var deck = new List<Card>();

            //test debug line of code
            // Console.WriteLine(deck.Count);//starts with the count of zero

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

            Console.WriteLine();

            //Create a player hand
            var player = new Hand();//new instance of the class Hand

            //Create a dealer hand
            var dealer = new Hand(); //another instance of the class Hand
            //Ask the deck for a card and place it in the player hand (and may mean two steps)
            //-the card is equal the 0th index of the deck

            //refactor
            Console.WriteLine("***********Let's deal some cards!***********");
            for (var numberOfCardsToDeal = 0; numberOfCardsToDeal < 2; numberOfCardsToDeal++)
            {
                var card = deck[0];
                // Console.WriteLine("Player has been deal: " + card);
                //-remove that card from the deck list so we don't keep dealing it
                deck.Remove(card);//we are always going to be taking the top card
                // Console.WriteLine(deck.Count);
                //-call the 'add card' behavior of the hand and pass it this card
                player.AddCard(card);
                // Console.WriteLine("And that was card number: " + player.CurrentCards.Count);
            }
            // Console.WriteLine();

            //******Start of old way of adding cards to the player
            // var firstPlayerCards = deck[0];
            // Console.WriteLine("First player card: " + firstPlayerCards);
            // //-remove that card from the deck list so we don't keep dealing it
            // deck.Remove(firstPlayerCards);
            // Console.WriteLine(deck.Count);
            // //-call the 'add card' behavior of the hand and pass it this card
            // player.AddCard(firstPlayerCards);
            // // Console.WriteLine(player.CurrentCards.Count);

            //Ask the deck for a card and place it in the player hand
            // var secondPlayerCards = deck[0];
            // Console.WriteLine("Second player card: " + secondPlayerCards);
            // deck.Remove(secondPlayerCards);
            // player.AddCard(secondPlayerCards);
            // Console.WriteLine(player.CurrentCards.Count);
            //*****End of old way of adding cards to the player

            //Ask the deck for a card and place it in the dealer hand
            //Ask the deck for a card and place it in the dealer hand
            for (var numberOfCardsToDeal = 0; numberOfCardsToDeal < 2; numberOfCardsToDeal++)
            {
                var card = deck[0];
                //-remove that card from the deck list so we don't keep dealing it
                deck.Remove(card);
                // Console.WriteLine(deck.Count);
                //-call the 'add card' behavior of the hand and pass it this card
                dealer.AddCard(card);
                // Console.WriteLine("And that was card number: " + dealer.CurrentCards.Count);
            }
            Console.WriteLine();

            //9-Show the player the cards in their hand and the TotalValue of their Hand
            //Loop through the list of cards in the player's hand
            // Console.WriteLine("Player, your cards are: ");
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
            // Console.WriteLine(String.Join(", ", player.CurrentCards));
            // Console.WriteLine($"The total value of your hand is: {player.TotalValue()}");

            Console.WriteLine();

            // Console.WriteLine("Dealer, your cards are: ");
            // Console.WriteLine(String.Join(", ", dealer.CurrentCards));
            //And the TotalValue of their hand
            // Console.WriteLine($"The total value of your hand is: {dealer.TotalValue()}");
            //     for every card, printout the to the user the description of the card
            //10-If they have 'Busted' (hand TotalValue is > 27), then go to step 15.
            var answer = "";
            while (player.TotalValue() <= 21 && answer != "STAND")
            {
                //9-Show the player the cards in their hand and the TotalValue of their Hand
                //Loop through the list of cards in the player's hand
                //OLD CODE
                // Console.WriteLine();
                // Console.WriteLine();
                // Console.WriteLine($"You have {player.CurrentCards.Count} cards");
                // Console.WriteLine("Player, your cards are: ");
                // Console.WriteLine(String.Join(", ", player.CurrentCards));

                // //and the TotalValue if their Hand
                // Console.WriteLine($"The total value of your hand is: {player.TotalValue()}");
                // Console.WriteLine();
                // Console.WriteLine();

                //REPLACED WITH
                player.PrintCardsAndTotal("Player");

                //11-Ask the player if they want to HIT or STAND
                Console.WriteLine("Do you want to 'HIT' or 'STAND'?");
                answer = Console.ReadLine().ToUpper();
                //12-If HIT 
                if (answer == "HIT")
                {
                    //  -Ask the deck for a card and place it in the player hand, repeat step 10
                    var card = deck[0];
                    deck.Remove(card);
                    player.AddCard(card);

                }//This is repeated behavior

                //13-If STAND then continue on

            }
            //OLD CODE
            // Console.WriteLine($"Player, the total value of your hand is: {player.TotalValue()}");
            // Console.WriteLine("Player, your cards were: ");
            // Console.WriteLine(String.Join(", ", player.CurrentCards));
            // Console.WriteLine();
            //REPLACED WITH
            player.PrintCardsAndTotal("Player");

            //14-If the dealer's hand TotalValue is more than 21 then go to step 17
            //15-If the dealer's hand TotalValue is less than 17
            while (player.TotalValue() <= 21 && dealer.TotalValue() <= 17)
            {
                //--Add card to the dealer hand and go back to step 14
                var card = deck[0];
                deck.Remove(card);
                dealer.AddCard(card);
                //and go back to step 14
            }
            //16-Show the dealer's hand TotalValue
            //OLD CODE
            // Console.WriteLine($"Dealer, the total value of your hand is: {dealer.TotalValue()}");
            // Console.WriteLine("Dealer, your cards were: ");
            // Console.WriteLine(String.Join(", ", dealer.CurrentCards));
            //REPLACED WITH
            dealer.PrintCardsAndTotal("Dealer");
            //17-If the player's hand TotalValue > 21 display message: "Dealer Wins!"
            if (player.TotalValue() > 21)
            {
                Console.WriteLine("Player, you busted 😕.");
                Console.WriteLine("Dealer wins!");
            }
            else
            //18-If the dealer's hand TotalValue is > 21 display message: "Player Wins!"
            if (dealer.TotalValue() > 21)
            {
                Console.WriteLine("Dealer busted 😕.");
                Console.WriteLine("Player Wins!");
            }
            else
            //19-If the dealer's hand TotalValue is more than the player's hand TotalValue, then display a message: "Dealer wins!", Else, display message: "Player Wins"
            if (dealer.TotalValue() > player.TotalValue())
            {
                Console.WriteLine("Dealer Wins!");
            }
            else
            if (player.TotalValue() > dealer.TotalValue())
            {
                Console.WriteLine("Player Wins!");
            }
            //20-If the value of the hands are even, display message: "Dealer wins!"
            if (player.TotalValue() == dealer.TotalValue())
            {
                Console.WriteLine("Dealer Wins Tides!");
            }
            Console.WriteLine();


        }
        static void DisplayGreeting()
        {
            Console.WriteLine("🂡 Welcome to Blackjack. \nThe first player to come closer to 21 or at 21 wins! Those who go over 21 loose. 🃁");
            Console.WriteLine("Press any key to play.");
            string pressToStartPlaying = Console.ReadLine();
        }
        static void Main(string[] args)
        {
            while (true)
            {
                //I do not have to do Program.PlayTheGame(); I can just call it directly
                PlayTheGame();

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Would you like to play the game again?");
                var answer = Console.ReadLine().ToUpper();
                if (answer == "NO" || answer == "n")
                {
                    break;// will end the most inner loop
                }
            }

        }
    }
}

