﻿using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets
{
    // base class for active skills, implement specifics for them in their own active class inside of a Hero's folder
    public class Active : MonoBehaviour
    {
        public string skillName;
        public string description;
        public int level;

        public int minRange;
        public int maxRange;
        public int placement;
        public int affects;
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