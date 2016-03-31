using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets
{
    // this holds the "account" information of the player
    public class Playthrough
    {
        // holds one of each hero
        public Hero[] roster;
        // regular and special currency counters
        public int regularCurrency;
        public int specialCurrency;
        // progress in the story, each chapter[here,] has missions[,here], and the number representation is how well the player did
        // a 4 is for no losses, 3 is for 1 loss, 2 is for 2+ survivors, and 1 is for 1 survivor
        // these can be added up and used to reward prizes
        public int[,] storyProgress;
        // this holds all of the items the character has
        public Item[] inventory;

    }
}
