using UnityEngine;

namespace Assets
{
    // this is the class that each permanent character's information is held. Use this for out-of-match stuff, and character for in-match stuff
    public class Hero : MonoBehaviour
    {
        public Active[] actives = new Active[4];
        public Passive[] passives;
        public OnHit[] onHits;
        public OnGetHit[] onGetHits;
        public CombatStats combatStats;
        public Info info;
        public bool owned;
        public Item[] inventory;
        public StatusEffectSystem statusEffects; // this holds buffs/debuffs/statusmodifiers that occur at the start of each match

    }
}
