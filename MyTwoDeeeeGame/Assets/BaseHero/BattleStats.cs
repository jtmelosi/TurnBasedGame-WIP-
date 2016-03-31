using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets
{
    // tracks stats of each character during a match
    public class BattleStats : MonoBehaviour
    {
        public int damageDone;
        public int damageTaken;
        public int damageAvoided;
        public int healingDone;
        public int kills;

        public BattleStats()
        {
            damageDone = 0;
            damageTaken = 0;
            damageAvoided = 0;
            healingDone = 0;
            kills = 0;
        }
    }
}
