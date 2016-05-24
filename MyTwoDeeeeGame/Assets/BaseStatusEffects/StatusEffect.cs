using UnityEngine;
using System.Collections.Generic;

namespace Assets
{
    public class StatusEffect : MonoBehaviour
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
        public enum SEIdentifier { StatChange, Damaging, Healing, Corrupted, Invulnerable, Suppressing, Immunity, Unstoppable, Stunned, Asleep };

        public List<SEIdentifier> identifiers;
        public Character owner;
        public Character source;
        
        public int endTurn;
        public int duration;

        // be sure to call in the super class constructor when making effects, and then adding to the identifiers list instead of making a new list
        public StatusEffect()
        {
            endTurn = Match.turn + duration;
            identifiers = new List<SEIdentifier>();
        }

        // needs to be implemented individually in each effect for what to do at the start of a turn
        public void startTurnEffects()
        {

        }

        // needs to be implemented individually in each effect for what to do at the end of a turn
        public void endTurnEffects()
        {

        }

        // individually implement anything that happens when this effect starts
        public void apply()
        {
            updateStatuses(true);
        }

        // individually implement anything that needs to be done when this effect ends
        // this is not for bomb explosions or anything like that, use an if in start/end turn effects for current turn compared to end turn for that kind of thing
        public void end()
        {
            updateStatuses(false);
        }

        // keeps track on the character applied how many effects each character has on them
        // this is so if there are 2+ effects, if 1 falls off they still apply
        public void updateStatuses(bool justApplied)
        {
            // figures out if the effect is falling off/being suppressed or being applied
            int amountToChange = 0;
            if (justApplied)
            {
                amountToChange++;
            }
            else
            {
                amountToChange--;
            }
            // updates amounts if the effect is of a certain type
            if (identifiers.Contains(SEIdentifier.Corrupted))
            {
                owner.statusEffects.corrupted += amountToChange;
            }
            if (identifiers.Contains(SEIdentifier.Immunity))
            {
                owner.statusEffects.immunity += amountToChange;
            }
            if (identifiers.Contains(SEIdentifier.Invulnerable))
            {
                owner.statusEffects.invulnerable += amountToChange;
            }
            if (identifiers.Contains(SEIdentifier.Suppressing))
            {
                owner.statusEffects.suppressing += amountToChange;
            }
            if (identifiers.Contains(SEIdentifier.Unstoppable))
            {
                owner.statusEffects.unstoppable += amountToChange;
            }
            if (identifiers.Contains(SEIdentifier.Stunned))
            {
                owner.statusEffects.stunned += amountToChange;
            }
            if (identifiers.Contains(SEIdentifier.Asleep))
            {
                owner.statusEffects.asleep += amountToChange;
            }
        }


        
        
        

    }

}

