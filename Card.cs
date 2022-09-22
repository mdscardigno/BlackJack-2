using System;
using BlackJack;
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

        //One way of assigning value to each card
        //to assign value to each of the cards
        //Cards know what the value of each card is.
        public int Value()
        {
            // //using the Dictionary
            // var values = new Dictionary<string, int>();
            // for (var number = 2; number <= 10; number++)
            // {
            //     values.Add($"{number}", number);
            // }
            // values.Add("Ace", 11);
            // values.Add("Jack", 10);
            // values.Add("Queen", 10);
            // values.Add("King", 10);

            // return values[Face];

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
                    return int.Parse(Face);//it returns an integer
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
        //Another way of assigning value to each card
        // public int Value()
        // {
        //     if (Face == "2")
        //     {
        //         return 2;
        //     }
        //     if (Face == "3")
        //     {
        //         return 3;
        //     }
        //     if (Face == "4")
        //     {
        //         return 4;
        //     }
        //     if (Face == "5")
        //     {
        //         return 5;
        //     }
        //     if (Face == "6")
        //     {
        //         return 6;
        //     }
        //     if (Face == "7")
        //     {
        //         return 7;
        //     }
        //     if (Face == "8")
        //     {
        //         return 8;
        //     }
        //     if (Face == "9")
        //     {
        //         return 9;
        //     }
        //     if (Face == "10")
        //     {
        //         return 10;
        //     }
        //     if (Face == "Jack")
        //     {
        //         return 10;
        //     }
        //     if (Face == "Queen")
        //     {
        //         return 10;
        //     }
        //     if (Face == "King")
        //     {
        //         return 10;
        //     }
        //     if (Face == "Ace")
        //     {
        //         return 11;
        //     }
        //     //we need a default check
        //     return 0;
        // }

        //returns a string with the card
        //teaching the card how to turn itself into a string so I can console.write it to the console
        public override string ToString()
        {
            return $"The {Face} of {Suit}";
        }
    }
}