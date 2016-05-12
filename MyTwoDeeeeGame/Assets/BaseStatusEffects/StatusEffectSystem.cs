using UnityEngine;
using System.Collections.Generic;
using Assets;

public class StatusEffectSystem : MonoBehaviour {


    public List<StatusEffect.Buff> buffs = new List<StatusEffect.Buff>();
    public List<StatusEffect.Debuff> debuffs = new List<StatusEffect.Debuff>();
    public List<StatusEffect.StatusModifier> statusModifiers = new List<StatusEffect.StatusModifier>();

    // here are the status effect counters
    public int corrupted;
    public int invulnerable;
    public int suppressing;
    public int immunity;
    public int unstoppable;
    public int stunned;
    public int asleep;


    public class StatusEffect
    {
        /*
        StatChange: modifies stats
        Damaging: deals damage
        Healing: increases health
        Corrupted: reverses healing
        Invulnerable: prevents damage
        Suppressing: stops all not unstoppable buffs
        Immunity: prevents application of debuffs
        Unstoppable: CC immunity
        */
        public enum SEIdentifier { StatChange, Damaging, Healing, Corrupted, Invulnerable, Suppressing, Immunity, Unstoppable};


        /*
        // This is for if we were calculating by seconds
        private DateTime startTime;
        private DateTime endTime;
        private DateTime duration;
        */

        // This is for calculating by turns
        public int endTurn;
        public int duration;

        private List<SEIdentifier> identifiers;
        Character owner;
        Character source;

        public StatusEffect()
        {
            endTurn = Match.turn + duration;
            identifiers = new List<SEIdentifier>();


        }

        // needs to be implemented individually in each effect
        public void doStuff()
        {

        }

        // individually implement anything that happens when this effect starts
        public void apply()
        {
            updateStatuses(true);
        }

        // individually implement anything that needs to be done when this ends (not bomb explosions or anything like that, use an if in doActions for that)
        public void end()
        {
            updateStatuses(false);
        }

        // 
        public void updateStatuses(bool justApplied)
        {
            int amountToChange = 0;
            
            if (justApplied)
            {
                amountToChange++;
            } else
            {
                amountToChange--;
            }
            if (identifiers.Contains(SEIdentifier.Corrupted))
            {
                owner.corrupted += amountToChange;
            }
            if (identifiers.Contains(SEIdentifier.Immunity))
            {
                owner.immunity += amountToChange;
            }
            if (identifiers.Contains(SEIdentifier.Invulnerable))
            {
                owner.invulnerable += amountToChange;
            }
            if (identifiers.Contains(SEIdentifier.Suppressing))
            {
                owner.suppressing += amountToChange;
            }
            if (identifiers.Contains(SEIdentifier.Unstoppable))
            {
                owner.unstoppable += amountToChange;
            }
        }

        // these can be placed in separate files later, this is just for example
        public class Buff : StatusEffect
        {

        }
        public class Debuff : StatusEffect
        {

        }
        public class StatusModifier : StatusEffect
        {

        }
        
    }

    public StatusEffectSystem() {
        
        corrupted = 0;
        invulnerable = 0;
        suppressing = 0;
        immunity = 0;
        unstoppable = 0;
        stunned = 0;
        asleep = 0;

    }






    
}
