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


        public virtual void createHand(List<Card> shuffled, List<Card> startHand)
        {
            int drawSize = 3;
            int deckIndex = shuffled.Count();

            for (int i = 0; i < drawSize; i++)
            {
                startHand.Add(shuffled[0]);
                shuffled.RemoveAt(0);
            }
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

        internal virtual void RemoveAt(int selection)
        {
            throw new NotImplementedException();
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

    }
}