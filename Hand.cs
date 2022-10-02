using System;
using System.Collections.Generic;
using Blackjack;

namespace BlackJack
{
    public class Hand
    {

        // Hand Class: has a collection of two cards.

        // Properties/States
        // a list of individual cards
        public List<Card> CurrentCards { get; set; } = new List<Card>(); //CurrentCards has the list of cards we are going to total.
        //if we do not have a list, we will get an error(Object reference not set to an instance of an object.)
        //another way to do it with a constructor to initialize the list of cards
        // public Hand()
        // {
        //     CurrentCards = new List<Card>();
        // }
        // Behaviors/Methods
        //--The hand has to total itself.TotalValue of the hand of cards.

        //--TotalValue representing the sum of the individual Cards in the list.
        public int TotalValue()
        {
            //--Start with a total = 0;
            var total = 0;
            //--Received cards.
            //--For each card in the hand, do this: 
            foreach (var card in CurrentCards)
            {
                //--Add the amount of that card's value to total.
                total = total + card.Value();
                //--return "total" as a result
            }
            return total;
            //classes are shared behavior
        }


        //--Add a card to the hand.
        public void AddCard(Card cardToAdd)
        {
            //--Add the supplied card to the list of cards
            CurrentCards.Add(cardToAdd);
        }

        public void PrintCardsAndTotal(string handName)
        {
            Console.WriteLine();

            // Console.WriteLine($"You have {player.CurrentCards.Count} cards");
            Console.WriteLine($"{handName}, your cards are: ");

            // Console.WriteLine(String.Join(", ", player.CurrentCards)); 
            //I no longer need an instance of the variable because I am a Hand. So I have my own CurrentCards and I have my own TotalValue
            //When I was outside of the class, I needed to ask, which hand did I want?
            //Look at the breadcrumb bars in Visual Studio Code
            Console.WriteLine(String.Join(", ", CurrentCards));
            //the Hand does not know which player I am so it seems that this is going to need to come
            //from the outside world

            //and the TotalValue if their Hand
            Console.WriteLine($"The total value of your hand is: {TotalValue()}");
            Console.WriteLine();
        }

    }
}