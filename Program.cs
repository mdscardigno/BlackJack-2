using System;
using System.Collections.Generic;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome message and description about the game.
            DisplayGreeting();

            //Make a list of cards
            //Suits is a list of "Club", "Diamond", "Heart", or "Spade"
            //Faces is a list of 2,3,4,5,6,7,8,9,10,Jack. Queen, King or Ace.

            //Go trough all of the suits one at a time and in order.
            //{
            //////Get the current suit
            /////Go through all of the faces one at a time and in order{
            /////////Get the current face
            ////////With the current suit and the current face, make a new card
            ////////Add that card to the list of cards
            ///////}
            //}

        }

    }

    static void DisplayGreeting()
    {
        Console.WriteLine("🂡 Welcome to Blackjack. \nThe first player to come closer to 21 or at 21 wins! Those who go over 21 loose. 🃁");
        Console.WriteLine("Press any key to play.");
        string pressToStartPlaying = Console.ReadLine();
    }
}