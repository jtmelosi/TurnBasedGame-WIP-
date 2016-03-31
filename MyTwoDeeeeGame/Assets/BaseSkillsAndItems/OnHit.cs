using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets
{
    // this is for attack on-hit effects. when implementing one, make sure to put it in the same folder the item/skill is in
    public class OnHit : MonoBehaviour
    {
        // this will proc each time an attack hits
        public void apply(Character target)
        {

        }

        // allows a limit to be set on the number of times an on-hit procs (I'd assume mostly 1 when this is used)
        public void apply(Character target, int maxHits)
        {

        }

        // if basic attacks are only attacks that trigger these
        public void apply(Character target, bool basicOnly)
        {

        }

    }
}
