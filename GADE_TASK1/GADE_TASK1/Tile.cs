using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_TASK1
{
    class Tile
    {
        abstract class Tileset
        {
            public double X { get; set; }
            public double Y { get; set; }

            public enum TileType
            {
                Hero = 0,
                Enemy = 1,
                Gold = 2,
                Weapon = 3
            }

            public Tileset()
            {
                char hero;
                char enemy;
                int gold;
                string weapon;
                hero = (char)TileType.Hero;
                enemy = (char)TileType.Enemy;
                gold = (int)TileType.Gold;
                weapon = TileType.Weapon.ToString();
            }

            class Obstacle : Tileset
            {
                public virtual void Tile(double posx, double posy)
                {
                    posx = base.X;
                    posy = base.Y;
                }
            }

            class EmptyTile : Tileset
            {
                public virtual void Tile(double posx, double posy)
                {
                    posx = base.X;
                    posy = base.Y;
                }
            }

        }
    }
}
