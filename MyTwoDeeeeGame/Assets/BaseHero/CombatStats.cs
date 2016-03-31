using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets
{
    // this is where each character's combat stats are held. be sure to put the implementation of this into the respective hero's folder
    public class CombatStats : MonoBehaviour
    {
        public int maxHealth;
        public int currHealth;
        public int resource;
        public int resourceRegen;
        public int healthRegen;
        public int lifeSteal; // phys lifesteal
        public int soulSteal; // mag lifesteal
        public int essenceLeach; // steal enemy's resource = % of their max health damage dealt to them

        public int critChance;
        public int critDamage;
        public int physPen;
        public int magicPen;
        public int doubleStrike; // % chance to hit 2 times with an attack

        public int physDef;
        public int magicDef;
        public int blockChance;
        public int blockPercent; // percent of damage blocked
        public int spellDeflectChance;
        public int dodgeChance;
        public int parryChance;

        public int feedback; // removes % of enemy's resource = % of their max health damage dealt to them 
        public int retaliationChance; // chance to retaliate when hit with basic ability IF at acceptable range
        public int damageReturn; // % of damage returned
        public int meleeReturn;
        public int rangedReturn;

        public int damageReduction; // % less damage taken
        public int damageIncrease; // % more damage dealt
    }
}
