using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets
{
    // this is the class that items are extended from, place all item implementations into the items folder
    public class Item : MonoBehaviour
    {
        public enum itemType {weapon, armor, shield, accessory};

        public itemType type;
        public int quality;
        public string itemName;
        public string description;

        public void onEquip()
        {

        }

        public void onRemove()
        {

        }

    }
}
