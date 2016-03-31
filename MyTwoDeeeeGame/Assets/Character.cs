using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets;

namespace Assets
{
    class Character
    {
        public int corrupted;
        public int invulnerable;
        public int suppressing;
        public int immunity;
        public int unstoppable;


        public Character()
        {
            corrupted = 0;
            invulnerable = 0;
            suppressing = 0;
            immunity = 0;
            unstoppable = 0;
        }

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




    }
}
