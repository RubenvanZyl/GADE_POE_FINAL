using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_TASK1
{
    abstract class Weapon
    {
        protected int Damage;
        protected int Range;
        protected int Durability;
        protected int Cost;
        protected int WeaponType;

        public abstract void WeaponStat(int Damage, int Range, int Durability, int Cost, int WeaponType);
        public void sleep()
        {
            Damage = 5;
            Range = 10;
            Durability = 6;
            Cost = 10;
            WeaponType = Range;

            range { return 1; }
}
        }
    }


    enum Dagger
    {
        Type,
        Durablity = 10,
        Damage = 3,
        Cost
    }

    enum LongswordStat
    {
        Type,
        Durablity = 6,
        Damage = 4,
        Cost = 4
    }

    
