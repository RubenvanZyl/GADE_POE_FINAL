using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_TASK1
{
    public abstract class Tile
    {
        protected int X { get; set; }
        protected int Y { get; set; }
        protected TileTypeEnum TileType { get; set; }
        public enum TileTypeEnum
        {
            Hero,
            Enemy,
            Gold,
            Weapon
        }

        public Tile(int x, int y, TileTypeEnum tileType)
        {
            X = x;
            Y = y;
            TileType = tileType;
        }
    }
    public class Obsticle : Tile
    {
        public Obsticle(int x, int y, TileTypeEnum tileType) : base(x, y, tileType)
        {
            
        }
    }

    public class EmptyTile : Tile
    {
        public EmptyTile(int x, int y, TileTypeEnum tileType) : base(x, y, tileType)
        {

        }
    }
}   
