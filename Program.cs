
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

            // Console.BufferHeight = 200;
            // Console.SetWindowPosition( );
            Console.BufferHeight = 49;
            Console.WindowHeight = 49;
            Console.WindowWidth = 150;
            // Console.
            Console.SetWindowSize(Console.WindowWidth, Console.BufferHeight);
            for (int i = 0; i < 150; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("*");
            }
            // for (int h = 0; h < 100; h++)
            // {
            //     Console.SetCursorPosition(0, h);
            //     Console.WriteLine("*");
            // }


            Console.WriteLine("\t Hello World!");
            // Console.WriteLine(Console.WindowWidth);
            // Console.WriteLine(Console.WindowHeight);
            Console.ReadKey();
            FireDeck fireDeck = new FireDeck();
            WaterDeck waterDeck = new WaterDeck();
            Console.WriteLine("\t. . .Decks Created. . .");
            // Console.Clear();
            // Shuffler shuffle = new Shuffler();
            TurnCounter turner = new TurnCounter();
            // turner.PrintHand(fireDeck);
            // shuffle.printDeckList();
            // shuffle.printDeckList(fireDeck);
            // fireDeck.printDeckLen();
            // Console.WriteLine("");
            waterDeck.shuffleFunction();
            waterDeck.printDeckList();
            waterDeck.handCreator();
            waterDeck.printHand();
            Console.ReadKey();
            fireDeck.shuffleFunction();
            fireDeck.printDeckList();
            fireDeck.handCreator();
            fireDeck.printHand();
            //which steps need to loop until end
            // Console.ReadKey();
            Console.Write(" ");
            Console.Write(" ");
            fireDeck.playHand();
            // deck.shuffleFunction();
            fireDeck.printHand();
            turner.gameStart();
            Console.WriteLine("got here");
            Console.ReadKey();


        }



    }
}
