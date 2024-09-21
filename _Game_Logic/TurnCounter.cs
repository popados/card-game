
using System;
using System.Collections.Generic;
using static CardGame01.Card;



namespace CardGame01
{

    class TurnCounter
    {
        public static bool isTurn { get; set; }
        public static bool isGame { get; set; }
        public static int turnCounter { get; set; }
        public static int playerOneMana { get; set; }
        public static int playerTwoMana { get; set; }

        public void createHand(List<Card> shuffled, List<Card> startHand)
        {

        }
        public List<Card> PrintHand(Deck deck)
        {
            Console.WriteLine("~~~~~~Your Hand~~~~~~");
            Console.Write("This is length: " + deck.startHand.Count);

            // foreach (var card in deck.startHand)
            // {

            //     Console.WriteLine("Card: {0} " + card.ToString(), (deck.startHand.IndexOf(card) + 1));
            // }
            return deck.startHand;
        }

        public static void pOneManaCounter()
        {
            playerOneMana++;
            Console.WriteLine("\n \t * this player one");
            Console.WriteLine("\t p1 mana: " + playerOneMana);
        }

        public static void pTwoManaCounter()
        {
            playerTwoMana++;
            Console.WriteLine("\n \t * this is player two");
            Console.WriteLine("\t p2 Mana Count: " + playerTwoMana);
        }

        public static int turnTurner(int turn)
        {
            turnCounter++;
            Console.WriteLine("\n \t turn number: " + turnCounter);
            Console.Write("\t *~~~~---------~~~~*");
            Console.ReadKey();
            playerOneTurn();
            playerTwoTurn();
            return turnCounter;
        }
        public static int playerOneTurn()
        {

            if (isTurn == false && turnCounter > 0)
            {
                pOneManaCounter();
                isTurn = true;
                Console.ReadKey();
            }

            else if (isTurn == false && turnCounter == 0)
            {
                pOneManaCounter();
                isTurn = true;
                Console.ReadKey();

            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("this is random else");

            }
            return turnCounter;

        }



        public static int playerTwoTurn()
        {
            if (isTurn == true && turnCounter == 0)
            {
                pTwoManaCounter();
                isTurn = false;
                Console.ReadKey();

                // turnCounter++;
            }

            else if (isTurn == true && turnCounter > 0)
            {

                pTwoManaCounter();
                isTurn = false;
                Console.ReadKey();

                // turnCounter++;

            }
            return turnCounter;

        }
        public void gameStart()
        {
            turnCounter = 0;
            isGame = true;
            isTurn = false;
            do
            {
                turnTurner(turnCounter);
                if (turnCounter >= 21)
                {
                    isGame = false;
                }
            } while (isGame == true);
        }

    }

}