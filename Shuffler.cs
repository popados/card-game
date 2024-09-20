using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static CardGame01.FireDeck;

namespace CardGame01
{
    class Shuffler
    {


        public string deckList { get; set; }

        Card player = new FireAvatar();
        Card enemy = new WaterAvatar();


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

        public List<Card> shuffled = new List<Card>();
        public List<Card> startHand = new List<Card>();
        public List<Card> fieldArea = new List<Card>();
        public List<Card> graveyardArea = new List<Card>();
        public int deckLen { get; set; }

        public List<Card> printDeckList(List<Card> deck)
        {
            Console.WriteLine("Got here print deck list");
            for (int i = 0; i < deck.Count; i++)
            {
                Console.Write("number: " + i + " ");
                Console.WriteLine("list: " + shuffled[i]);
                Console.ReadKey();

            }
            return shuffled;
        }

        public List<Card> shuffleFunction()
        {

            Random ran = new Random();

            int count = Deck.Count;
            int selection = 0;
            Console.WriteLine("shuffling");

            for (int i = 0; i < count; i++)
            {
                selection = ran.Next(Deck.Count - 1);
                shuffled.Add(Deck[selection]);
                Deck.RemoveAt(selection);
            }
            return shuffled;
        }
        //shuffled deck

        //dont need to print deck
        //foreach (var card in shuffled)
        //{
        //    Console.WriteLine("Deck number: " + (shuffled.IndexOf(card) + 1) + card.ToString());
        //}




        //could probably change this to if(firstTurn = true) { //draw one } else { //draw two }


    }
}