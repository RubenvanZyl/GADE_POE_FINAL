using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_TASK1
{
    abstract class RangedWeapons : Weapon
    {
        enum Types
        {
            Rifle,
            Longbow
        }

        public override int Range 
        {
            set { }
            get { return base.Range; }
        }
        //todo:fix get weapon type
        public void getWeaponType(Types types)
        {
            switch (types)
            {
                case Types.Rifle:
                    WeaponType = Types.Rifle;
                    Durablity = 3;
                    Range = 3;
                    Damage = 5;
                    Cost = 7;
                    break;

                case Types.Longbow:
                    WeaponType = Types.Longbow;
                    Durablity = 4;
                    Range = 2;
                    Damage = 4;
                    Cost = 6;
                    break;
                default:

                    break;
            }
        }

    }
}
