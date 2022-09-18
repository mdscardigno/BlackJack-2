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
        public List<Card> CurrentCards { get; set; } = new List<Card>();
        //if we do not have a list, we will get an error(Object reference not set to an instance of an object.)
        //another way to do it with a constructor to initialize the list of cards
        // public Hand()
        // {
        //     CurrentCards = new List<Card>();
        // }
        // Behaviors/Methods
        //--The hand has to total itself.TotalValue of the hand of cards.
        //--TotalValue representing the sum of the individual Cards in the list.
        //--Start with a total = 0;
        //--Received cards.
        //--For each card in the hand, do this: add the amount of that card's value to total.
        //--return "total" as a result

        //--Add a card to the hand.
        public void AddCard(Card cardToAdd)
        {
            //--Add the supplied card to the list of cards
            CurrentCards.Add(cardToAdd);
        }

    }
}