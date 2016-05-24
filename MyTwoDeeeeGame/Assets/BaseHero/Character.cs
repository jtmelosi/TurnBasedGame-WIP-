using UnityEngine;

namespace Assets
{
    // this represents the information of a character in matches. Use this for in-match stuff, and hero for out-of-match stuff
    public class Character : MonoBehaviour
    {
        

        // here are the stats and abilities objects
        public Active[] actives;
        public Passive[] passives;
        public OnHit[] onHits;
        public OnGetHit[] onGetHits;
        public CombatStats stats;
        public Info info;
        public StatusEffectSystem statusEffects;
        public BattleStats battleStats;

        public Character[] team;

        // here are various other objects needed
        public Tile currentTile;

        public Character(Hero hero)
        {
            actives = hero.actives;
            passives = hero.passives;
            onHits = hero.onHits;
            onGetHits = hero.onGetHits;
            stats = hero.combatStats;
            info = hero.info;
            statusEffects = hero.statusEffects;
            battleStats = new BattleStats();
        }




    }
}
