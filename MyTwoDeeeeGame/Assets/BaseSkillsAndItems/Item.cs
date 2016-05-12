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
        public int cost;

        // what is added when the weapon is equipped
        public void onEquip(Hero owner)
        {

        }

        // what is removed when the weapon is unequipped
        public void onUnequip(Hero owner)
        {

        }

    }
}
