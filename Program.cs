using System;
using System.Collections.Generic;
using BlackJack;

namespace Blackjack
{
    class Program
    {
        static void DisplayGreeting()
        {
            Console.WriteLine("♥️♦️♣️♠️ Welcome to Blackjack ♥️♦️♣️♠️ \nThe first player to come closer to 21 or at 21 wins! Those who go over 21 loose. ");
            Console.WriteLine("Press any key to play.");
            string pressToStartPlaying = Console.ReadLine();
        }
        //example of a method to build a deck
        static List<Card> BuildDeck()
        {
            //I call BuildDeck. It builds a variable called theDeckWeAreCurrentlyBuilding, we build it and then it gets returned and it is received by theDeckWeJustBuilt variable in Main() 
            var theDeckWeAreCurrentlyBuilding = new List<Card>(); //producing information
            //code for the deck
            return theDeckWeAreCurrentlyBuilding;//returning output

        }
        //static methods are any methods that does not require an instance of the class; for example: new Program. 
        static void PlayTheGame()
        {

            //premature optimization is the root of all evil
            //Welcome message and description about the game.
            DisplayGreeting();

            //after moving old code for creating the deck to the deck class we change the code of creating a new deck to:
            var deck = new Deck();
            //Initialize the deck
            deck.Initialize();
            deck.Shuffle();

            //Create a new player

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
                Card card = deck.Deal();
                // Console.WriteLine("Player has been deal: " + card);
                //calls the "add card" method of the Hand class and pass it this card
                player.AddCard(card);
                // Console.WriteLine("And that was card number: " + player.CurrentCards.Count);
                // player.AddCard(new Card() {Face = "Ace", Suit = "Blah"});
            }
            //Ask the deck for a card and place it in the dealer hand
            for (var numberOfCardsToDeal = 0; numberOfCardsToDeal < 2; numberOfCardsToDeal++)
            {
                Card card = deck.Deal();
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
                Console.WriteLine();
                answer = Console.ReadLine().ToUpper();
                //12-If HIT 
                if (answer == "HIT")
                {
                    //  -Ask the deck for a card and place it in the player hand, repeat step 10
                    Card card = deck.Deal();
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
                Card card = deck.Deal();
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
                Console.WriteLine("Player Wins!🥳");
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
                Console.WriteLine("Player Wins!🥳");
            }
            //20-If the value of the hands are even, display message: "Dealer wins!"
            if (player.TotalValue() == dealer.TotalValue())
            {
                Console.WriteLine("Dealer Wins Tides!");
            }
            Console.WriteLine();


        }

        static void Main(string[] args)
        {
            //Deck building in a method
            var theDeckWeJustBuilt = BuildDeck();//we are accepting the output as a list
            Console.WriteLine(theDeckWeJustBuilt.Count);
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
                    Console.WriteLine("Goodbye...👋");
                    break;// will end the most inner loop
                }
            }

        }
    }
}

