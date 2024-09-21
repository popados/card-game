﻿
using System;
using System.Collections.Generic;
using static CardGame01.TurnCounter;
using static CardGame01.Shuffler;
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
            for (int h = 0; h < 35; h++)
            {
                Console.SetCursorPosition(0, h);
                Console.WriteLine("*");

            }


            Console.SetCursorPosition(50, 5);
            Console.WriteLine("\t Hello World!");
            Console.WriteLine();
            Console.ReadKey();
            FireDeck deck = new FireDeck();
            Shuffler shuffle = new Shuffler();
            TurnCounter turner = new TurnCounter();
            shuffle.printDeckLen();
            Console.ReadKey();
            shuffle.shuffleFunction();
            Console.ReadKey();
            // shuffle.printDeckList();
            shuffle.printDeckList(shuffle.shuffled);
            Console.ReadKey();
            // deck.shuffleFunction();
            Card mycard = new ImpCard();
            mycard.printCard();
            TurnCounter.gameStart();
            Console.WriteLine("got here");
            Console.ReadKey();


        }

    }
}
