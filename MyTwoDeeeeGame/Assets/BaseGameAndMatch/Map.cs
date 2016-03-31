using UnityEngine;

namespace Assets
{
    // each specific map will have to be created through functions in this class
    public class Map : MonoBehaviour
    {
        
        Tile[,] tiles;// = new Tile[#,#];
        
        public Map(bool random)
        {
            if (random)
            {
                generateRandomMap();
            }
            else
            {

            }
        }

        public Map(bool random, int width, int height)
        {
            if (random)
            {
                tiles = new Tile[width, height];
                generateRandomMap();
            }
            else
            {
                tiles = new Tile[width, height];
            }
        }

        // we will have to implement a create random map function
        public void generateRandomMap()
        {

        }

        // dfs search for other side to make sure everything is accessible
        public bool findOtherSide()
        {
            
            return true;
        }
        
    }
}
