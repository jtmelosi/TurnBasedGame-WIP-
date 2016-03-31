using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets;

namespace Assets
{
    public class Tile : MonoBehaviour
    {
        // 0 = teleporting, 1 = any, 2 = swimming/flying/teleporting, 3 = flying/teleporting
        // 0 = not passable, 1 = normal, 2 = water, 3 = air
        public int constraint;
        // character/terrain/destructable that occupies the tile, NULL is an empty tile
        public Character occupant;
        // the buff you get for being on the tile
        public StatusModifier powerup;
        // buffs and debuffs to apply to the character on this tile
        public List<StatusEffect> statusEffects = new List<StatusEffect>();
        // how to find the tile in the map
        public int[] coords = new int[2];

        public bool highlighted;
        public bool traversed;
    }
}
