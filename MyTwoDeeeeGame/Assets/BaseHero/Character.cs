using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets;

namespace Assets
{
    // this represents the information of a character in matches
    public class Character : MonoBehaviour
    {
        // here are the status effect counters
        public int corrupted;
        public int invulnerable;
        public int suppressing;
        public int immunity;
        public int unstoppable;
        public int stunned;
        public int asleep;

        public Active[] actives;
        public Passive[] passives;
        public OnHit[] onHits;
        public CombatStats stats;
        public Info info;
        public StatusEffectSystem statusEffects;

        public Character(Hero hero)
        {
            corrupted = 0;
            invulnerable = 0;
            suppressing = 0;
            immunity = 0;
            unstoppable = 0;
            stunned = 0;
            asleep = 0;
            actives = hero.actives;
            passives = hero.passives;
            onHits = hero.onHits;
            stats = hero.combatStats;
            info = hero.info;
            statusEffects = hero.statusEffects;
        }




    }
}
