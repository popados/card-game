using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static CardGame01.FireDeck;

namespace CardGame01
{
    class Shuffler<Deck>
    {



        Card player = new FireAvatar();
        Card enemy = new WaterAvatar();

        public List<Deck> shuffled = new List<Deck>();

        public List<Card> fieldArea = new List<Card>();
        public List<Card> graveyardArea = new List<Card>();
        public int deckLen { get; set; }
        public string deckList { get; set; }

        public List<Deck> printDeckList(List<Card> deck)
        {
            Console.WriteLine("\t Got here print deck list");
            for (int i = 0; i < deck.Count; i++)
            {
                Console.Write("\t number: " + i + " ");
                Console.WriteLine("\t list: " + shuffled[i]);
            }
            return shuffled;
        }

        // internal List<Deck> printDeckList(Deck deck)
        // {
        //     Console.WriteLine("\t Got here print deck list");
        //     for (int i = 0; i < deck.Count(); i++)
        //     {
        //         Console.Write("\t number: " + i + " ");
        //         Console.WriteLine("\t list: " + shuffled[i]);
        //     }
        //     return shuffled;
        // }



        // public List<Deck> shuffleFunction(Deck deck)
        // {

        //     Random ran = new Random();

        //     int count = deck.Count;
        //     int selection = 0;
        //     Console.WriteLine("\t shuffling");

        //     for (int i = 0; i < count; i++)
        //     {
        //         selection = ran.Next(deck.Count() - 1);
        //         shuffled.Add(deck[selection]);
        //         deck.RemoveAt(selection);
        //     }
        //     return shuffled;
        // }

    }

}
//shuffled deck

//dont need to print deck
//foreach (var card in shuffled)
//{
//    Console.WriteLine("Deck number: " + (shuffled.IndexOf(card) + 1) + card.ToString());
//}




//could probably change this to if(firstTurn = true) { //draw one } else { //draw two }

