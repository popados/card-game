
using System;
using System.Collections.Generic;
using static CardGame01.TurnCounter;
// using static CardGame01.Shuffler;
using static CardGame01.FireDeck;
using CardGame01;
//global variables
// What do I need?
// turnStart = false;
// gameStart = false;


namespace CardGame01
{
    class Program
    {
        public static void Main()
        {

            Console.SetWindowSize(150, 40);
            for (int i = 0; i < 150; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.WriteLine("*");


            }


            // for (int h = 0; h < 35; h++)
            // {
            //     Console.SetCursorPosition(0, h);
            //     Console.WriteLine("*");

            // }


            Console.SetCursorPosition(50, 5);
            Console.WriteLine("\t Hello World!");
            Console.WriteLine();
            Console.ReadKey();
            FireDeck fireDeck = new FireDeck();
            WaterDeck waterDeck = new WaterDeck();
            Console.Write("\n \t Decks Created. . .");
            // Shuffler shuffle = new Shuffler();
            TurnCounter turner = new TurnCounter();
            // turner.PrintHand(fireDeck);
            // shuffle.printDeckList();
            // shuffle.printDeckList(fireDeck);
            // fireDeck.printDeckLen();
            Console.WriteLine("");
            waterDeck.shuffleFunction();
            waterDeck.printDeckList();
            waterDeck.handCreator();
            waterDeck.printHand();
            fireDeck.shuffleFunction();
            fireDeck.printDeckList();
            fireDeck.handCreator();
            fireDeck.printHand();
            Console.ReadKey();
            // deck.shuffleFunction();
            // Card mycard = new ImpCard();
            // mycard.printCard();
            turner.gameStart();
            Console.WriteLine("got here");
            Console.ReadKey();


        }



    }
}
