using System;
using System.Collections.Generic;

namespace Blackjack
{
    class Card
    {
        //initialize
        //a card has a face and a suit
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
        public override string ToString()
        {
            return $"The {Face} of {Suit}";
        }

    }
    class Deck
    {
        //Properties: 52 cards in a deck with 4 suits and 13 ranks.
        public List<Card> Cards { get; set; }
        //what can a deck do?
        //shuffle
        //deal
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}