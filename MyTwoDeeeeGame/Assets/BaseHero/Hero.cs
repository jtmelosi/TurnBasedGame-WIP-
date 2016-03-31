using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets
{
    // this is the class that each permanent character's information is held
    public class Hero : MonoBehaviour
    {
        public Active[] actives;
        public Passive[] passives;
        public OnHit[] onHits;
        public CombatStats combatStats;
        public Info info;
        public bool owned;
        public Item[] inventory;
        public StatusEffectSystem statusEffects; // this holds buffs/debuffs/statusmodifiers that occur at the start of each match

    }
}
