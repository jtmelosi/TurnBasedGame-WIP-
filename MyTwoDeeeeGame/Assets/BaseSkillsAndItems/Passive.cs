using UnityEngine;

namespace Assets
{
    // base class for passives, implement specifics for them in their own passive class inside of a Hero's folder (possibly as StatusModifiers)
    public class Passive : MonoBehaviour
    {
        public Character owner;
    }
}
