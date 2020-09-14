using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE_TASK1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Charater MainCharacter = new Charater();
        }

        public abstract class Tile
        {
            public double X { get; set; }
            public double Y { get; set; }
        }

        public enum TileType
        {
            Gold = 2,
            Weapons = 3,
            Hero = 0,
            Enemy = 1,

        }

        public class TileTypeData
        {
            public TileTypeData(char hero, char enemy, int gold, string Weapons)
            {
                gold = (int)TileType.Gold;
                Weapons = TileType.Weapons.ToString();
                hero = (char)TileType.Hero;
                enemy = (char)TileType.Enemy;

            }
        }

        class EmptyTile : Tile
        {
            public virtual void Tile(double posx, double posy)
            {
                posx = base.X;
                posy = base.Y;
            }

        }


        class Charater : Tile
        {
            public double hp;
            public double maxHP;
            public double damage;
            public double[] vision;
            public int movement;
            public int up, left, right, down;
            public string no_Movement;
        }

    }


}

