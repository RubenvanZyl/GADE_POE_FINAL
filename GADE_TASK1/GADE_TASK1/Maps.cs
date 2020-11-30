using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_TASK1
{
    class Maps
    {
        protected Tile[,] maparray;
        protected Hero mainHero = new Hero();
        protected Enemy mainEnemy = new Enemy();
        protected int mapWidth;
        protected int mapHeight;
        protected Random rng = new Random();

        public Maps(int miniWidth, int maxiWidth, int miniHeight, int maxiHeight, int numberofenemies)
        {
            int randomwidth = rng.Next(miniWidth, maxiWidth);
            MainEnemy = new Enemy[(randomwidth + randomHeight) / 3];

            Create();
            UpdateVision();
        }

        public void UpdateVision()
        {

        }

        private Tile Create(Tile type)
        {
            int randomX = rng.Next(mapWidth);
            int randomY = rng.Next(mapHeight);

            switch (type)
            {
                case Hero:
                    maparray[randomX, randomY] - "H";
                    break;
                case Enemy:
                    mapArray[randomX, randomY] - "G";
                    breal;
                case GOLD:
                    maparray(randomX, randomY) - "H";
            }
        }
    }
}
