using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardGame01
{
    public class Deck
    {


        public List<Deck> deckList { get; set; }

        Card player = new FireAvatar();
        WaterCard enemy = new WaterAvatar();
        public List<Card> currentDeck = new List<Card>() { };
        public List<Card> shuffled = new List<Card>() { };
        public List<Card> startHand = new List<Card> { };
        public List<Card> fieldArea = new List<Card> { };
        public List<Card> graveyardArea = new List<Card> { };
        public virtual int deckLen { get; set; }
        public virtual string cardList { get; set; }

        public virtual int printDeckLen()
        {

            deckLen = currentDeck.Count;
            Console.WriteLine("\t length: " + deckLen);
            return deckLen;
        }
        public virtual List<Card> shuffleFunction()
        {

            Random ran = new Random();

            int count = currentDeck.Count;
            int selection = 0;

            for (int i = 0; i < count; i++)
            {
                selection = ran.Next(currentDeck.Count - 1);
                shuffled.Add(currentDeck[selection]);
                currentDeck.RemoveAt(selection);
            }
            return shuffled;
        }
        public virtual List<Card> printDeckList(Deck deck)
        {

            for (int i = 0; i < currentDeck.Count; i++)
            {
                Console.WriteLine("\t list: " + shuffled[i]);

            }
            return shuffled;
        }
        //shuffled deck

        //dont need to print deck
        //foreach (var card in shuffled)
        //{
        //    Console.WriteLine("Deck number: " + (shuffled.IndexOf(card) + 1) + card.ToString());
        //}


        public List<Card> createHand(Deck deck)
        {
            int drawSize = 3;
            int deckIndex = shuffled.Count();

            for (int i = 0; i < drawSize; i++)
            {
                deck.startHand.Add(deck.shuffled[0]);
                deck.shuffled.RemoveAt(0);
            }
            return deck.startHand;
        }


        //could probably change this to if(firstTurn = true) { //draw one } else { //draw two }
        public virtual void drawFunction(List<Card> startHand, List<Card> shuffled)
        {
            Console.WriteLine("Adding one card to your hand.");
            startHand.Add(shuffled[0]);
            shuffled.RemoveAt(0);

        }

        internal virtual int Count()
        {
            deckLen = currentDeck.Count;
            Console.WriteLine("\t length: " + deckLen);
            return deckLen;
            throw new NotImplementedException();
        }
        // public List<Card> PrintHand(Deck deck)
        // {
        //     Console.WriteLine("~~~~~~Your Hand~~~~~~");
        //     Console.Write("This is length: " + deck.startHand.Count);

        //     // foreach (var card in deck.startHand)
        //     // {

        //     //     Console.WriteLine("Card: {0} " + card.ToString(), (deck.startHand.IndexOf(card) + 1));
        //     // }
        //     return deck.startHand;
        // }
        public List<Card> printHand()
        {

            Console.Write("\n\t ~~~~~~Your Hand~~~~~~\n");
            printDeckLen();
            foreach (var card in startHand)
            {

                Console.WriteLine("Card: {0} " + card.ToString());
            }
            return startHand;
        }

        internal virtual void RemoveAt(int selection)
        {
            throw new NotImplementedException();
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
//Console.WriteLine();
//Console.WriteLine("Are you going first or second? Press 1 for first and 2 for second.");
////create a drawCard function
////if firstTurn
////add one
////else add two
//var input = Console.ReadLine();
//Int32.TryParse(input, out int result);
//switch (result)
//{
//    case 1:
//        Console.WriteLine("Adding one card to your hand.");
//        startHand.Add(shuffled[0]);
//        shuffled.RemoveAt(0);
//        break;
//    case 2:
//        Console.WriteLine("Adding two cards to your hand.");
//        startHand.Add(shuffled[0]);
//        shuffled.RemoveAt(0);
//        startHand.Add(shuffled[0]);
//        shuffled.RemoveAt(0);
//        break;
//    default:
//        isFirstTurn(startHand, shuffled);
//        loop
//        break;
//}
