
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame01
{
    public abstract class Card
    {
        //variables for cards
        public string CardName { get; set; }
        public string CardDescription { get; set; }
        public string AbilityDescription { get; set; }
        public string CardType { get; set; }
        public int Attack { get; set; }
        public int Health { get; set; }
        public int Cost { get; set; }
        public int maxMana { get; set; }
        public int currentMana { get; set; }
        public int playerTurnCount { get; set; }
        public bool playerTurn { get; set; }
        public bool isDead { get; set; }
        public bool summonSickness { get; set; }
        public bool isCreature { get; set; }

        //constructor for cards with default values
        //all cards are created as Card card = new CardName();
        //all commented out code between class and constructor in inheirented classes is for saving
        public Card()
        {
            CardName = "Card Name";
            CardDescription = "Card Description";
            AbilityDescription = "N/A";
            CardType = "Creature or Spell";
            Attack = 0;
            Health = 0;
            Cost = 0;
            isCreature = false;
            summonSickness = false;
        }

        public override string ToString()
        {
            return ":--" + CardName + "--:";
            //+ "\t Mana Cost: " + Cost
        }
        public void printCard()
        {
            Console.WriteLine("\n \t Card: " + CardName +
                 "\n \t Description: " + CardDescription +
                "\n \t Ability: " + AbilityDescription +
                "\n \t Type: " + CardType +
                "\n \t Attack: " + Attack +
                "\n \t Health: " + Health +
                "\n \t Cost: " + Cost +
                "\n \t Just summoned: " + summonSickness);
            Console.WriteLine();
            //Console.ReadKey();
        }
        public virtual void dealDamage(Card target)
        {
            target.Health -= Attack;
            Console.WriteLine(CardName + " attacked for {0} damage", Attack);

        }
    }

}

