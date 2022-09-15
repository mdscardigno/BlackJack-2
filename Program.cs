using System;
using System.Collections.Generic;

namespace Blackjack
{
    class Card
    {
        //initialize
        //a card has a face, a suit and a value
        public string Face { get; set; }
        public string Suit { get; set; }
        //to assign value to each of the cards
        public int Value()
        {
            switch (Face)
            {
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                    return int.Parse(Face);
                case "Jack":
                case "Queen":
                case "King":
                    return 10;
                case "Ace":
                    return 11;
                default:
                    return 0;
            }
        }
        //returns a string with the card
        public override string ToString()
        {
            return $"The {Face} of {Suit}";
        }
    }
    class Deck
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
    class Hand
    {
        //what does a hand has? A collection of two cards with a list.
        //Behavior
        //The hand has to total itself. TotalValue of the hand of cards.
        //Receive cards.
    }
    //not everything that has a behavior is a class
    class Game
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            DisplayGreeting();







            static void DisplayGreeting()
            {
                System.Console.WriteLine("🂡 Welcome to Blackjack. \nThe first player to come closer to 21 or at 21 wins! Those who go over 21 loose. 🃁");
            }
        }

    }
}