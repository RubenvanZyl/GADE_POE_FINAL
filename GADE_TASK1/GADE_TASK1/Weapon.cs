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
        public virtual int Range { get; set; }
        protected int Durability;
        protected int Cost;
        protected string WeaponType;

        //public abstract void WeaponStat(int Damage, int Range, int Durability, int Cost, int WeaponType);
        //public void sleep()
        //{
        //    Damage = 5;
        //    Range = 10;
        //    Durability = 6;
        //    Cost = 10;
        //    WeaponType = Range;
        //}
    }

    

    abstract class MeleeWeapon : Weapon
    {
        enum Types
        {
            Dagger,
            Longsword
        }

        public override int Range
        {
            set { }
            get { return 1; }
        }
        public void getWeaponType(Types types)
        {
            switch (types)
            {
                case Types.Dagger:
                    WeaponType = Types.Dagger;
                    Durablity = 10;
                    Damage = 3;
                    Cost = 3;
                    break;

                case Types.Longsword:
                    WeaponType = Types.Longsword;
                    Durablity = 6;
                    Damage = 4;
                    Cost = 4;
                    break;
                default:

                    break;
            }
        }

    }
}
