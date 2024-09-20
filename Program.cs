


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
Console.SetWindowSize(150, 40);

for (int i = 0; i < 150; i++)
{
    Console.SetCursorPosition(i, 0);
    Console.WriteLine("*");


}
for (int h = 0; h < 35; h++)
{
    Console.SetCursorPosition(75, h);
    Console.WriteLine("*");
}

Console.SetCursorPosition(64, 5);
Console.WriteLine("Hello World!");
Console.WriteLine();
Console.ReadKey();
FireDeck deck = new FireDeck();
Shuffler shuffle = new Shuffler();
deck.printDeckLen();
Console.ReadKey();
shuffle.shuffleFunction();
Console.ReadKey();
// shuffle.printDeckList();
shuffle.printDeckList(shuffle.shuffled);
Console.ReadKey();
// deck.shuffleFunction();
Card mycard = new ImpCard();
mycard.printCard();
TurnCounter.gameStart(isGame, isTurn, turnCounter);
Console.ReadKey();