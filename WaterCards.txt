
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CardGame01.Card;

namespace CardGame01
{


    public abstract class WaterCard : Card
    {
        //variables for cards


        //constructor for cards with default values
        //all cards are created as Card card = new CardName();
        //all commented out code between class and constructor in inheirented classes is for saving
        public WaterCard()
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
        // public void printCard()
        // {
        //     Console.WriteLine("Card: " + CardName +
        //          "\n Description: " + CardDescription +
        //         "\n Ability: " + AbilityDescription +
        //         "\n Type: " + CardType +
        //         "\n Attack: " + Attack +
        //         "\n Health: " + Health +
        //         "\n Cost: " + Cost +
        //         "\n Just summoned: " + summonSickness);
        //     Console.WriteLine();
        //     //Console.ReadKey();
        // }
        public virtual void dealDamage(Card target)
        {
            target.Health -= Attack;
            Console.WriteLine(CardName + " attacked for {0} damage", Attack);

        }


    }
    public class Mino : WaterCard
    {
        public Mino()
        {
            CardName = "Mino";
            CardDescription = "Smallest Fish.";
            AbilityDescription = "N/A";
            CardType = "Creature";
            Attack = 3;
            Health = 1;
            Cost = 1;
            isCreature = true;
            isDead = false;
            summonSickness = false;
            //nothing but an attack
        }
        public override void dealDamage(Card target)
        {
            target.Health -= Attack;
        }
    }

    public class LittleSerpent : WaterCard
    {
        public LittleSerpent()
        {
            CardName = "Little Serpent";
            CardDescription = "Smallest Fish.";
            AbilityDescription = "N/A";
            CardType = "Creature";
            Attack = 3;
            Health = 1;
            Cost = 1;
            isCreature = true;
            isDead = false;
            summonSickness = false;
            //nothing but an attack
        }
        public override void dealDamage(Card target)
        {
            target.Health -= Attack;
        }
    }
    public class SpiritOfWater : WaterCard
    {
        public SpiritOfWater()
        {
            CardName = "Spirit Of Water";
            CardDescription = "Smallest Fish.";
            AbilityDescription = "N/A";
            CardType = "Creature";
            Attack = 3;
            Health = 1;
            Cost = 1;
            isCreature = true;
            isDead = false;
            summonSickness = false;
            //nothing but an attack
        }
        public override void dealDamage(Card target)
        {
            target.Health -= Attack;
        }
    }
    public class WaterDragon : WaterCard
    {
        public WaterDragon()
        {
            CardName = "Water Dragon";
            CardDescription = "Smallest Fish.";
            AbilityDescription = "N/A";
            CardType = "Creature";
            Attack = 3;
            Health = 1;
            Cost = 1;
            isCreature = true;
            isDead = false;
            summonSickness = false;
            //nothing but an attack
        }
        public override void dealDamage(Card target)
        {
            target.Health -= Attack;
        }
    }
    public class Crash : WaterCard
    {
        public Crash()
        {
            CardName = "Crash";
            CardDescription = "Smallest Fish.";
            AbilityDescription = "N/A";
            CardType = "Creature";
            Attack = 3;
            Health = 1;
            Cost = 1;
            isCreature = true;
            isDead = false;
            summonSickness = false;
            //nothing but an attack
        }
        public override void dealDamage(Card target)
        {
            target.Health -= Attack;
        }
    }
    public class EyeOftheStorm : WaterCard
    {
        public EyeOftheStorm()
        {
            CardName = "Eye of the Storm";
            CardDescription = "Smallest Fish.";
            AbilityDescription = "N/A";
            CardType = "Creature";
            Attack = 3;
            Health = 1;
            Cost = 1;
            isCreature = true;
            isDead = false;
            summonSickness = false;
            //nothing but an attack
        }
        public override void dealDamage(Card target)
        {
            target.Health -= Attack;
        }
    }
    public class Maelstrom : WaterCard
    {
        public Maelstrom()
        {
            CardName = "Maelstrom";
            CardDescription = "Smallest Fish.";
            AbilityDescription = "N/A";
            CardType = "Creature";
            Attack = 3;
            Health = 1;
            Cost = 1;
            isCreature = true;
            isDead = false;
            summonSickness = false;
            //nothing but an attack
        }
        public override void dealDamage(Card target)
        {
            target.Health -= Attack;
        }
    }

    public class WaterAvatar : WaterCard
    {
        public WaterAvatar()
        {
            CardName = "Celiana, Siren of the Sea";
            CardDescription = "Commander of Water. She gotchu swimming.";
            AbilityDescription = "I AM THE COMMANDER! HAhaAhaA.";
            CardType = "Hero/Avatar";
            Attack = 0;
            Health = 15;
            Cost = 0;
            maxMana = 0;
            isCreature = false;
            //no summon sickness for spells
        }
    }
}

