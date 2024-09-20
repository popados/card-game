using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardGame01
{
    class FireDeck
    {


        public string deckList { get; set; }


        public List<Card> Deck = new List<Card>
            {
            //deck created with card objects
                new ImpCard(), new ImpCard(), new ImpCard(),
                new LittleDraco(), new LittleDraco(), new LittleDraco(),
                new SpiritOFire(), new SpiritOFire(), new SpiritOFire(),
                new FireDrake(), new FireDrake(), new FireDrake(),
                new FireBall(), new FireBall(), new FireBall(),
                new FlameStrike(), new FlameStrike(), new FlameStrike(),
                new WildFire(), new WildFire(), new WildFire()
            };



        Card player = new FireAvatar();
        Card enemy = new WaterAvatar();


        public List<Card> shuffled = new List<Card>() { };
        public List<Card> startHand = new List<Card>();
        public List<Card> fieldArea = new List<Card>();
        public List<Card> graveyardArea = new List<Card>();
        public int deckLen { get; set; }
        public string cardList { get; set; }

        public int printDeckLen()
        {

            deckLen = Deck.Count;
            Console.WriteLine("length: " + deckLen);
            return deckLen;
        }
        public List<Card> shuffleFunction()
        {

            Random ran = new Random();

            int count = Deck.Count;
            int selection = 0;

            for (int i = 0; i < count; i++)
            {
                selection = ran.Next(Deck.Count - 1);
                shuffled.Add(Deck[selection]);
                Deck.RemoveAt(selection);
            }
            return shuffled;
        }
        public List<Card> printDeckList(List<Card> deck)
        {

            for (int i = 0; i < deck.Count; i++)
            {
                Console.WriteLine("list: " + shuffled[i]);
                Console.ReadKey();

            }
            return shuffled;
        }
        //shuffled deck

        //dont need to print deck
        //foreach (var card in shuffled)
        //{
        //    Console.WriteLine("Deck number: " + (shuffled.IndexOf(card) + 1) + card.ToString());
        //}


        public static void createHand(List<Card> shuffled, List<Card> startHand)
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
        public static void drawFunction(List<Card> startHand, List<Card> shuffled)
        {
            Console.WriteLine("Adding one card to your hand.");
            startHand.Add(shuffled[0]);
            shuffled.RemoveAt(0);

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
}