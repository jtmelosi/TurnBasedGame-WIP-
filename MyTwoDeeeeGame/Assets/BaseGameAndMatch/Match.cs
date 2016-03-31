using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets
{
    public class Match : MonoBehaviour
    {
        public static int teamSize;
        public static Map map;// = new Map();
        public static int turn;// = 0;
        // team 1 v 2
        public static List<Character> teamOne = new List<Character>();
        public static List<Character> teamTwo = new List<Character>();
        // team 3 is various other characters
        public static List<Character> teamThree = new List<Character>();
        // team 4 is destructables
        public static List<Character> teamFour = new List<Character>();

        // win conditions at some point


    }
}
