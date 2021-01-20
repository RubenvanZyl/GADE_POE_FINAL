using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE_TASK1
{
    public abstract class Character : Tile
    {
        protected double hp { get; set; }
        protected double maxHP { get; set; }
        protected double damage { get; set; }

        public enum Movement
        {
            No_Movement,
            Up,
            Down,
            Left,
            Right
        }

        public Tile visionArray[int X,int Y]

        public virtual void Attack(Character target)
        {
            target.hp -= damage;
        }

        public bool IsDead()
        {
            if (hp < 1)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public virtual bool CheckRange(Character target)
        {
            if( DistanceTo(target) <= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private int DistanceTo(Character target)
        {
            return 0;
        }
        public void Move
        {

        }
        public Character(int x, int y, TileTypeEnum tileType) : base(x, y, tileType)
        {

        }

    }
}