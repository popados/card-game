
using System;
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


        public static void pOneManaCounter()
        {
            playerOneMana++;
            Console.WriteLine();
            Console.WriteLine("\t this player one");
            Console.WriteLine("\t p1 mana: " + playerOneMana);
        }

        public static void pTwoManaCounter()
        {
            playerTwoMana++;
            Console.WriteLine();
            Console.WriteLine("\t this is player two");
            Console.WriteLine("\t p2 Mana Count: " + playerTwoMana);
        }

        public static int turnTurner(int turn)
        {
            turnCounter++;
            Console.WriteLine();
            Console.WriteLine("\t turn number: " + turnCounter);
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
                Console.ReadKey();
                isTurn = true;
            }

            else if (isTurn == false && turnCounter == 0)
            {
                pOneManaCounter();
                Console.ReadKey();
                isTurn = true;
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("this is random else");
                Console.ReadKey();

            }
            return turnCounter;

        }

        public static int playerTwoTurn()
        {
            if (isTurn == true && turnCounter == 0)
            {
                pTwoManaCounter();
                Console.ReadKey();
                isTurn = false;
                // turnCounter++;
            }

            else if (isTurn == true && turnCounter > 0)
            {

                pTwoManaCounter();
                Console.ReadKey();
                isTurn = false;
                // turnCounter++;

            }
            return turnCounter;

        }
        public static void gameStart()
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