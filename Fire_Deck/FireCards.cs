namespace CardGame01
{
    public class ImpCard : Card
    {
        //string CardName = "Imp";
        //string CardDescription = "Totally not a Warlock pet.";
        //string AbilityDescription = "N/A";
        //string CardType = "Creature";
        //int Attack = 3;
        //int Health = 1;
        //int Cost = 1;
        public ImpCard()
        {
            CardName = "Imp";
            CardDescription = "Totally not a Warlock pet.";
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
    public class LittleDraco : Card
    {
        //string CardName = "Little Draco";
        //string CardDescription = "Small Dragon.";
        //string AbilityDescription = "N/A";
        //string CardType = "Creature";
        //int Attack = 1;
        //int Health = 3;
        //int Cost = 1;
        public LittleDraco()
        {
            CardName = "Little Draco";
            CardDescription = "Small Dragon.";
            AbilityDescription = "N/A";
            CardType = "Creature";
            Attack = 1;
            Health = 3;
            Cost = 1;
            isCreature = true;
            isDead = false;
            summonSickness = false;
            //nothing will use card name for fire drake

        }
    }
    public class SpiritOFire : Card
    {
        //string CardName = "Spirit Of Fire";
        //string CardDescription = "Its the spirit of da fire, mon.";
        //string AbilityDescription = "N/A";
        //string CardType = "Creature";
        //int Attack = 3;
        //int Health = 4;
        //int Cost = 2;
        public SpiritOFire()
        {
            CardName = "Spirit Of Fire";
            CardDescription = "Its the spirit of da fire, mon.";
            AbilityDescription = "N/A";
            CardType = "Creature";
            Attack = 3;
            Health = 4;
            Cost = 2;
            isCreature = true;
            isDead = false;
            summonSickness = false;
            //if spirit fire dies(last will) {1 damage}
        }
    }
    public class FireDrake : Card
    {
        //string CardName = "Fire Drake";
        //string CardDescription = "Big Big Dragon.";
        //string AbilityDescription = "+1/+1 for each Little Draco in play.";
        //string CardType = "Creature";
        //int Attack = 5;
        //int Health = 3;
        //int Cost = 3;
        public FireDrake()
        {
            CardName = "Fire Drake";
            CardDescription = "Big Big Dragon.";
            AbilityDescription = "+1/+1 for each Little Draco in play.";
            CardType = "Creature";
            Attack = 5;
            Health = 3;
            Cost = 3;
            isCreature = true;
            isDead = false;
            summonSickness = false;
            //for each (cardName fire drake) +1/+1 atk/def
        }
    }
    public class FireBall : Card
    {
        //string CardName = "Fireball";
        //string CardDescription = "Fire in your face.";
        //string AbilityDescription = "Deal 1 damage to target creature/commander.";
        //string CardType = "Spell";
        //int Attack = 0;
        //int Health = 0;
        //int Cost = 1;
        public FireBall()
        {
            CardName = "Fireball";
            CardDescription = "Fire in your face.";
            AbilityDescription = "Deal 2 damage to target creature/commander.";
            CardType = "Spell";
            Attack = 2;
            Health = 0;
            Cost = 1;
            isCreature = false;
            summonSickness = false;
        }
    }
    public class FlameStrike : Card
    {
        //string CardName = "Flamestrike";
        //string CardDescription = "Fire strikes the earth.";
        //string AbilityDescription = "1 damage three times to random enemies.";
        //string CardType = "Spell";
        //int Attack = 0;
        //int Health = 0;
        //int Cost = 3;
        public FlameStrike()
        {
            CardName = "Flamestrike";
            CardDescription = "Fire strikes the earth.";
            AbilityDescription = "1 Damage to three creatures.";
            CardType = "Spell";
            Attack = 1;
            Health = 0;
            Cost = 2;
            isCreature = false;
            //for each card in field area list [i] = random ran for index//
            //add enemy to list
            //no summon sickness for spells
        }
    }
    public class WildFire : Card
    {
        //string CardName = "Wildfire";
        //string CardDescription = "Uncontrollable flames.";
        //string AbilityDescription = "Deal 2 damage to enemy creatures and commanders.";
        //string CardType = "Spell";
        //int Attack = 0;
        //int Health = 0;
        //int Cost = 2;
        public WildFire()
        {
            CardName = "Wildfire";
            CardDescription = "Uncontrollable flames.";
            AbilityDescription = "Deal 2 damage to all creatures and commanders.";
            CardType = "Spell";
            Attack = 2;
            Health = 0;
            Cost = 3;
            isCreature = false;
            //no summon sickness for spells
            //for each field area // etc //etc
        }
    }
    public class FireAvatar : Card
    {
        public FireAvatar()
        {
            CardName = "Atria, the Phoenix of Rebirth";
            CardDescription = "Commander of fire. Edge and all.";
            AbilityDescription = "I AM THE COMMANDER! HAhaAhaA.";
            CardType = "Hero/Avatar";
            Attack = 0;
            Health = 15;
            Cost = 0;
            maxMana = 5;
            currentMana = 1;
            playerTurnCount = 0;
            playerTurn = false;
            isCreature = false;
            //no summon sickness for spells
        }
    }

}