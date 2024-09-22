using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardGame01
{
    class FireDeck : Deck
    {


        public new string deckList { get; set; }

        Card player = new FireAvatar();
        // WaterCard enemy = new WaterAvatar();

        public List<Card> Deck = new List<Card>
        {
            //deck created with card objects
            new ImpCard(),new ImpCard(),new ImpCard(),
            new LittleDraco(), new LittleDraco(), new LittleDraco(),
            new SpiritOFire(), new SpiritOFire(), new SpiritOFire(),
            new FireDrake(), new FireDrake(), new FireDrake(),
            new FireBall(), new FireBall(), new FireBall(),
            new FlameStrike(), new FlameStrike(), new FlameStrike(),
            new WildFire(), new WildFire(), new WildFire()

        };

        public new List<Card> shuffled = new List<Card> { };
        public new List<Card> startHand = new List<Card>();
        public new List<Card> fieldArea = new List<Card>();
        public new List<Card> graveyardArea = new List<Card>();
        public new int deckLen { get; set; }
        public new string cardList { get; set; }

        public override int printDeckLen()
        {

            deckLen = Deck.Count;
            Console.WriteLine("\t length: " + deckLen);
            return deckLen;
        }
        public new List<Card> shuffleFunction()
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
            Console.Write("\n \t  . . . Shuffling. . . \n \n");
            return shuffled;
        }
        public List<Card> printDeckList()
        {
            // Console.WriteLine("\t here " + shuffled.Count);

            foreach (var card in shuffled)
            {

                Console.WriteLine("Card: " + card.ToString());
            }
            return shuffled;
        }

        //shuffled deck

        //dont need to print deck
        //foreach (var card in shuffled)
        //{
        //    Console.WriteLine("Deck number: " + (shuffled.IndexOf(card) + 1) + card.ToString());
        //}


        public new static void createHand(List<Card> shuffled, List<Card> startHand)
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
        public new static void drawFunction(List<Card> startHand, List<Card> shuffled)
        {
            Console.WriteLine("Adding one card to your hand.");
            startHand.Add(shuffled[0]);
            shuffled.RemoveAt(0);

        }
        public void handCreator()
        {
            // Hand hand = new Hand();
            Console.WriteLine("\n\t Hand Created \n");

            int drawSize = 3;
            int deckIndex = shuffled.Count;

            for (int i = 0; i < drawSize; i++)
            {
                startHand.Add(shuffled[0]);
                shuffled.RemoveAt(0);
            }
        }

        public void printHand()
        {
            Console.Write("\n\t ~~~~~~Your Hand~~~~~~\n");

            foreach (var card in startHand)
            {

                Console.WriteLine("Card: {0} " + card.ToString());
            }
        }

        public List<Card> fireDeckHand()
        {
            Console.Write("\n\t Enter 1 to see hand. \n\t 2 to play card \n\t 3 to quit \n\t");
            int numCard = 0;
            var input = Console.ReadLine();
            Int32.TryParse(input, out numCard);
            //will default to 0 if nothing selected
            switch (numCard)
            {
                case 1:
                    return startHand;
                // break;
                case 2:
                    return startHand;
                case 3:
                    return startHand;
                default:
                    return startHand;
            }
            throw new NotImplementedException();
        }


        internal new int Count()
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