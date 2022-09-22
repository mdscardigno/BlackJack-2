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

    }
}