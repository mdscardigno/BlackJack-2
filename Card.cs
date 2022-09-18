using System;
using System.Collections.Generic;

namespace BlackJack
{
    public class Card
    {
        //Class Card
        // Properties: The face of the card. The suit of the card.
        // Methods: Value of the card based on a table bellow:

        // | Face  | Value |
        // | ----- | ----- |
        // | 2     | 2     |
        // | 3     | 3     |
        // | 4     | 4     |
        // | 5     | 5     |
        // | 6     | 6     |
        // | 7     | 7     |
        // | 8     | 8     |
        // | 9     | 9     |
        // | 10    | 10    |
        // | Jack  | 10    |
        // | Queen | 10    |
        // | King  | 10    |
        // | Ace   | 11    |

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
}