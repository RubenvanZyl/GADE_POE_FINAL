using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE_TASK1
{
    class Character
    {
        public double hp;
        public double maxHP;
        public double damage;
        public double[] vision;
        public int movement;
        public int up, left, right, down;
        public string no_Movement;

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
            if( DistanceTo(target) < 1)
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
        
    }
}