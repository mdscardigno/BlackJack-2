# BLACKJACK

## [P]RESTATE THE PROBLEM

1-Display a message: "Welcome to Blackjack." The first player to come closer to 21 or at 21 wins! Those who go over 21 loose.

2-This Blackjack game is played with a shuffled deck of 52 cards and with a player(human) playing against the house/dealer(computer).
3-The house is dealt two cards hidden from the player and the player is deal two cards visible to the player.

4-Each card has a Face and a Suit.
Suits: Spades, Diamonds, Hearts and Clubs.
Faces: "1", "2", "3", "4", "5", "6", "7". "8", "9", "10", "Jack", "Queen" and "Kind".
5- Values for each card are as follows: Suits: Aces are never 1. They are worth 11. Jack, Queen and King are worth 10 each. All the other cards are worth the number they display.

6-The player reviews his/her hand (playerHand) and it is given two options: a) hit b)stand.
7-If player chooses to hit, the player is dealt another card.
8-If player chooses to stand, the playerHandCardsValue is unchanged.

9-Next, the dealer reveals its hand and is given the choice to choose between the two options: a)hit b)stand.
10-If dealer hits, the playerHandCardsValue is updated.

11-If dealer stands, playerHandCardsValue is unchanged.
12-The two handCardsValues (playerHandCardsValue > dealerHandCardsValue or playerHandCardsValue < dealerHandCardsValue) are compared to see who is closer to 21 and therefore ends up being the winner.
13-If there is a tide or both the dealer and the player have the same handCardsValue (playerHandCardsValue == dealerHandCardsValue), dealer wins.
14-Once we have a winner, we show a message and restart the game by giving the options if the player wants to play again?
15-If yes, we restart the game, if not, we exit game.

## [E]xamples:

-Using lists to create the deck of cards.
var deck = new List<string>() {
"Ace of Clubs",
"1 of Clubs", "2 of Clubs", "3 of Clubs", "4 of Clubs", "5 of Clubs", "6 of Clubs", "7 of Clubs", "8 of Clubs", "9 of Clubs", "10 of Clubs", "Jack of Clubs", "Queen of Clubs", "King of Clubs", "Ace of Hearts", "1 of Hearts", "2 of Hearts", "3 of Hearts", "4 of Hearts", "5 of Hearts", "6 of Hearts", "7 of Hearts", "8 of Hearts", "9 of Hearts", "10 of Hearts", "Jack of Hearts", "Queen of Hearts", "King of Hearts", "Ace of Spades", "1 of Spades", "2 of Spades", "3 of Spades", "4 of Spades", "5 of Spades", "6 of Spades", "7 of Spades", "8 of Spades", "9 of Spades", "10 of Spades", "Jack of Spades", "Queen of Spades", "King of Spades", "Ace of Diamonds", "1 of Diamonds", "2 of Diamonds", "3 of Diamonds", "4 of Diamonds", "5 of Diamonds", "6 of Diamonds", "7 of Diamonds", "8 of Diamonds", "9 of Diamonds", "10 of Diamonds", "Jack of Diamonds", "Queen of Diamonds", "King of Diamonds" };

-Example Dog Bellow-
Base Class: Dog
Properties:
Color, EyeColor, Height, Length, Weight.
Methods: Sit, LayDown, Shake, Come.

Object Instance: Rayne (A type Dog)
PropertyValues:
Color: Gray, White, and Black
EyeColor: Blue and Brown
Height: 18 in
Length: 36 in
Weight: 30 pounds

Methods: Sit, LayDown, Shake, Come
End of class dog and object instance of type Dog.

## [D]ata Structures:

Looking at nouns and verbs:

-deck
properties/states
a list of 52 cards
behaviors/methods
make a new deck of 52 shuffled cards. deal one card out of the deck.

-card
properties/states
the face of the card
the suit of the card
behaviors/methods
the value of the card according to the table.

-hand
properties/states
a list of individual cards
behaviors/methods
-TotalValue representing the sum of the individual Cards in the list.
--Start with a total = 0;
--For each card in the hand, do this: add the amount of that card's value to total.
--return "total" as a result
-Add a card to the hand.
--Add the supplied card to the list of cards

-player
dealer and plater are instances of the Hand class
properties/states
behaviors/methods

-dealer
properties/states
behaviors/methods

deal total value receive

data attributes
cards rank and suit

is this a class or a list?
the card will give me its value
i will show the rank and suit of the card

## Objects:

Players: humanPlayer, computerDealer

Players attributes:
CardsHandValue
CardsHandValueChanged - event handler

Deck: 52 cards
Card: Face and Suit
What other objects do i need?

OPTIONAL DELETE BEFORE COMMIT OR ADD IT TO STUDENT FILE
Some things to Remember:

https://www.justsajid.com/skills/csharp/objects-everything-is-an-object-in-c/

But in C#, everything belongs to something. Objects in C# are instances of things called classes and structures. Classes and structures are very similar to each other in that they both define member objects. For example, if you want to work with some data in C#, you would define it as a member of a class or a structure. Persistent data is stored in something called a field, which is defined as a member of the class or structure.

Fields are typically private to the class or structure, that is, their values can only be read by code within the class or structure. But you can then expose those values as properties that can be read and set by the rest of the application. And behaviors are also defined as members of classes or structures, encapsulated in methods. A method is just like a function in a non-object-oriented language, but like fields and properties, it’s a member of a class or structure.

Everything is a part of a class or structure, and much of what you work with are instances of these classes or structures. These instances are the objects we're talking of, and so that's why we say everything is an object in C#.

Classes and structures are members of namespaces. Think of namespaces as a way of organizing your code.

Console applications always start with static Main() method (executable code).
All code is placed inside a class or structure.

Blackjack Classes
Hand
Properties: List of 52 cards or CurrentCards

Methods: totalCardValue() adding the cards.
For each card in CurrentCards total is equal to increasing the total from 0 + cardValue. The total is returned as a 'total'.
AddCard(Card cardToAdd): (Adds a provided card to the list of cards).
AddCards(List<Card> cardsToAdd): (Adds the more than one card to the hand )
PrintCardsAndTheTotal():
Busted
Not Busted
DealerHits() when total is less than or equal to 17.

Deck
Properties: Properties: A list of 52 cards
\*Algorithm for the creation of a deck of 52 cards:\*
Make an empty list of cards and call it 'deck'.
var deck = new Deck()
-We have the player hand.
var playerHand = new Hand();
-We have the dealer hand.
var dealerHand = new Hand();
-dealer deals a card from the deck to the player and add it to the playerHand.
The card is equal to the 0th index of the deck list
-dealer deals a card to him/herself and adds it to his hand dealerHand twice.
-if their hand value is over 21, they busted.
-if their hand is less or equal to 17, provide options to hit or stand.

-
-

- Methods:
  buildDeck (instead of initialize) = build the list of cards with faces and suits.
  shuffleDeckOfCards (instead of shuffle):

Card
Properties:
Methods:

END OF OPTIONAL DELETE BEFORE COMMIT OR ADD IT TO STUDENT FILE

## States/Properties:

-Cards: Face and Suits

## Methods/Behaviors:

Value()computing how many points the card is worth.

dealerHand
handCardsValueTotal
playerHand
handCardsValueTotal
playingCards

Classes (blueprints) allow us to build our own data structures.
Creating an object.
Describing what it is like.
When we create an object based on the class, we are creating an instance of the object.

//not everything that has a behavior is a class
