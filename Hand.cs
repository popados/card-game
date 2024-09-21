
using System;
using System.Collections.Generic;
using static CardGame01.TurnCounter;
// using static CardGame01.Shuffler;
using static CardGame01.FireDeck;
using CardGame01;

namespace CardGame01
{
    class Hand
    {

        public List<Card> shuffled = new List<Card>() { };
        public List<Card> startHand = new List<Card>();
        public List<Card> fieldArea = new List<Card>();
        public List<Card> graveyardArea = new List<Card>();

        public void createHand(List<Card> shuffled, List<Card> startHand)
        {
            int drawSize = 3;
            int deckIndex = shuffled.Count;

            for (int i = 0; i < drawSize; i++)
            {
                startHand.Add(shuffled[0]);
                shuffled.RemoveAt(0);
            }
        }
        public static void drawFunction(List<Card> startHand, List<Card> shuffled)
        {
            Console.WriteLine("Adding one card to your hand.");
            startHand.Add(shuffled[0]);
            shuffled.RemoveAt(0);

        }
        public List<Card> PrintHand(Deck deck)
        {
            Console.WriteLine("~~~~~~Your Hand~~~~~~");
            Console.Write("This is length: " + deck.startHand.Count);

            // foreach (var card in deck.startHand)
            // {

            //     Console.WriteLine("Card: {0} " + card.ToString(), (deck.startHand.IndexOf(card) + 1));
            // }
            return deck.startHand;
        }


    }


}