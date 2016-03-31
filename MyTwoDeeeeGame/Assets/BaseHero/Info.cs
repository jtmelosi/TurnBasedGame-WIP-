using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets
{
    // this is where non-combat stats go
    public class Info : MonoBehaviour
    {
        public string heroName;
        public string title;
        public string description;
        public int level;
        public int currentExp;
        public int neededExp;
        public int skillPoints;

        public enum MoveType {walking, swimming, flying, telelporting};
        public MoveType movement;
    }
}
