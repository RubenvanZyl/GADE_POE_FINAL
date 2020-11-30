using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GADE_TASK1
{
    class Hero :Character
    {
        public Hero(int Xinput, int Yinput, int HP)
        {
            this.HP - HP;
            maxHP - HP;
            damage = 2;
        }

        override ReturnMove()
        {
            return 0;
        }

        public override string ToString()
        {
            return "Player Stat:\n"
                + "HP: " + maxHP
                + "Damage: " + 2
                + "[" + X + "," + Y + "]";
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("HP: " + HP);
            Console.WriteLine("Current Weapon: " + Weapon);
            Console.Write("Weapon Range: " + range);
            Console.Write("Weapon Damage: " + Damage);
            Console.Write("Gold: " + Gold);
        }
    }
}
