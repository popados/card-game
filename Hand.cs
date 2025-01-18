
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
        public List<Card> startHand = new List<Card>() { };
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
        public List<Card> PrintHand()
        {
            Console.WriteLine("~~~~~~Your Hand~~~~~~");
            Console.Write("This is length: " + startHand.Count);

            // foreach (var card in deck.startHand)
            // {

            //     Console.WriteLine("Card: {0} " + card.ToString(), (deck.startHand.IndexOf(card) + 1));
            // }
            return startHand;
        }

        public void printHand()
        {
            Console.Write("\n\t ~~~~~~Your Hand~~~~~~\n");

            foreach (var card in startHand)
            {

                Console.WriteLine("Card: {0} " + card.ToString());
            }
        }

        public List<Card> playHand()
        {
            Console.Write("\n\t Enter 1 to see hand. \n\t 2 to play card \n\t 3 to quit \n\t");
            int numCard = 0;
            var input = Console.ReadLine();
            Int32.TryParse(input, out numCard);
            //will default to 0 if nothing selected
            //while loop
            //iterative process
            // while(cardsInDeck = true) {stuff}
            //checks conditions if (continue) {++continue; turn counter; }
            //

            switch (numCard)
            {
                case 1:
                    Console.Write("\n\tPicked 1");

                    playHand();


                    return startHand;
                // break;
                case 2:
                    Console.Write("\n\tPicked 2");
                    printHand();
                    playHand();
                    return startHand;
                case 3:
                    Console.Write("\n\tPicked 3");
                    playHand();
                    return startHand;
                default:
                    Console.Write("\n\tPicked default");
                    playHand();
                    return startHand;
            }
            throw new NotImplementedException();
        }

    }


}