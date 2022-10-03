using System;
using System.Collections.Generic;
using BlackJack;

namespace Blackjack
{
    class Program
    {

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


            //Create a new player

            //Create a player hand
            var player = new Hand();//new instance of the class Hand

            //Create a dealer hand
            var dealer = new Hand(); //another instance of the class Hand
                                     //Ask the deck for a card and place it un the player hand
                                     //the card is equal to the 0th index of the deck list
                                     //Deal 2 cards to the player
            Console.WriteLine("***********Let's deal some cards!***********");
            List<Card> newPlayerCards = deck.DealMultipleCards(2);//adding multiple cards to the player hand
            player.AddCards(newPlayerCards);
            //refactor

            //Ask the deck for a card and place it in the dealer hand
            List<Card> newDealerCards = deck.DealMultipleCards(2);//adding multiple cards to the player hand
            dealer.AddCards(newDealerCards);

            //9-Show the player the cards in their hand and the TotalValue of their Hand
            //Loop through the list of cards in the player's hand

            //10-If they have 'Busted' (hand TotalValue is > 27), then go to step 15.
            var answer = "";
            while (player.TotalValue() < 21 && answer != "STAND")//if a player has 21, no prompt is
            {
                //9-Show the player the cards in their hand and the TotalValue of their Hand

                player.PrintCardsAndTotal("Player");

                //11-Ask the player if they want to HIT or STAND
                Console.WriteLine("Do you want to 'HIT' or 'STAND'?");
                Console.WriteLine();
                answer = Console.ReadLine().ToUpper();
                //12-If HIT 
                if (answer == "HIT".ToUpper() || answer == "H".ToUpper())
                {
                    //  -Ask the deck for a card and place it in the player hand, repeat step 10
                    Card card = deck.Deal();
                    player.AddCard(card);

                }//This is repeated behavior

                //13-If STAND then continue on

            }
            //Prints total value of the player's hand
            player.PrintCardsAndTotal("Player");

            //14-If the dealer's hand TotalValue is more than 21 then go to step 17
            //15-If the dealer's hand TotalValue is less than 17
            while (player.NotBusted() && dealer.DealerShouldHit())
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
            if (player.Busted())
            {
                Console.WriteLine("Player, you busted 😕.");
                Console.WriteLine("Dealer wins!");
            }
            else
            //18-If the dealer's hand TotalValue is > 21 display message: "Player Wins!"
            if (dealer.Busted())
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
    }
}

