using UnityEngine;

namespace Assets
{
    // each specific map will have to be created through functions in this class
    public class Map : MonoBehaviour
    {
        
        Tile[,] tiles;// = new Tile[#,#];
        
        

        // we will have to implement a create random map function
        public Map generateRandomMap()
        {
            return null;
        }

        // dfs search for other side to make sure everything is accessible
        public bool findOtherSide()
        {
            
            return true;
        }
        
    }
}
