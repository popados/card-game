
using System;



namespace CardGame01
{

    class TurnCounter
    {
        public static bool isTurn;
        public static bool isGame;
        public static int turnCounter;

        public static int playerOneMana;

        public static int playerTwoMana;


        public static int playerOneTurn()
        {
            if (isTurn == true && turnCounter == 0)
            {
                playerOneMana++;
                Console.WriteLine();
                Console.WriteLine("this is player one");
                Console.WriteLine("p1 Mana Count: " + playerOneMana);
                Console.ReadKey();
                isTurn = false;
                turnCounter++;
            }

            else if (isTurn == true && turnCounter > 0)
            {

                playerOneMana++;
                Console.WriteLine();
                Console.WriteLine("player one now has mana: " + playerOneMana);
                Console.WriteLine(" p1 turn number: " + turnCounter);
                Console.ReadKey();
                isTurn = false;
                turnCounter++;

            }
            return turnCounter;

        }
        public static int playerTwoTurn()
        {

            if (isTurn == false && turnCounter > 0)
            {
                playerTwoMana++;
                Console.WriteLine();
                Console.WriteLine("player two now has mana: " + playerTwoMana);
                Console.WriteLine(" p2 turn number: " + turnCounter);
                Console.ReadKey();
                isTurn = true;
                // turnCounter++;
            }

            else if (isTurn == false && turnCounter == 0)
            {
                playerTwoMana++;
                Console.WriteLine();
                Console.WriteLine("this player two");
                Console.WriteLine("p2 mana: " + playerTwoMana);
                Console.ReadKey();
                isTurn = true;
                // turnCounter++;
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("this is random else");
                Console.ReadKey();

            }
            return turnCounter;

        }


        public static void gameStart(bool isGame, bool isTurn, int turnCounter)
        {
            turnCounter = 0;
            isGame = true;
            isTurn = true;
            do
            {
                playerOneTurn();
                playerTwoTurn();
                turnCounter++;
                Console.WriteLine("turn number: " + turnCounter);
                if (turnCounter > 21)
                {
                    isGame = false;
                }
            } while (isGame == true);
        }

    }

}