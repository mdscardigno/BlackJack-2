using System;
using System.Collections.Generic;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) Create a new deck.
            //Propertiers: 52 cards.
            DisplayGreeting();


            static void DisplayGreeting()
            {
                Console.WriteLine("🂡 Welcome to Blackjack. \nThe first player to come closer to 21 or at 21 wins! Those who go over 21 loose. 🃁");
                Console.WriteLine("Press any key to play.");
                string pressToStartPlaying = Console.ReadLine();
            }
        }

    }
}