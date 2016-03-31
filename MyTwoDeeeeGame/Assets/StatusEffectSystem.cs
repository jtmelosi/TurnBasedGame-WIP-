using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using Assets;

public class StatusEffectSystem : MonoBehaviour {


    private List<StatusEffect.Buff> buffs = new List<StatusEffect.Buff>();
    private List<StatusEffect.Debuff> debuffs = new List<StatusEffect.Debuff>();
    private List<StatusEffect.StatusModifier> statusModifiers = new List<StatusEffect.StatusModifier>();

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



        }








	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


    }
}
