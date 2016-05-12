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
        // what the tile type is
        public enum tileType {solidObject, normal, water, air};

        // movement types that can move through this tile
        public List<Info.MoveType> moveThroughConstraint;

        // movement types that can on this tile
        public List<Info.MoveType> endMoveConstraint;

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
