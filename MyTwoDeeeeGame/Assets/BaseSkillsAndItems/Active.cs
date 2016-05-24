using UnityEngine;
using System.Collections.Generic;

namespace Assets
{
    // base class for active skills, implement specifics for them in their own active class inside of a Hero's folder
    public class Active : MonoBehaviour
    {
        public enum Affects {allies, enemies, character, tile, terrain, empty};
        public enum Placement {empty, character, any, terrain, allies, enemies };

        public string skillName;
        public string description;
        public int level;
        public Character owner;

        public int minRange;
        public int maxRange;
        public List<Placement> placement;
        public List<Affects> affects;
        public Tile[] affectedTiles;
        //public int radius; // probably just implement this in highlight in case you wanna add in a weird shape or something

        // single target
        public void use(Tile tile)
        {

        }

        // aoe
        public void use(Tile[] tiles)
        {

        }

        // character targeted through whatever means
        public void use(Character target)
        {

        }

        // highlights tiles that will be affected by the ability
        public void highlight()
        {

        }
    }
}
