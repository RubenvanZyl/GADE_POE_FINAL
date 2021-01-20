using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_TASK1
{
    public abstract class Enemy : Character
    {
        int maxHp;
        int damage;
        int HP;
        public Enemy(int Xinput, int Yinput, int HP)
        {
            this.HP - HP;
            maxHP - HP;
            damage = 1;
        }
        public override string ToString()
        {
            return Enemy + " at [" + X + ", " + Y + "] (" + damage + ")";
         
        }

    }
}
