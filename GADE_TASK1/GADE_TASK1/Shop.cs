using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_TASK1
{
    class Shop
    {
        string[] weapons = { "Rifle, Dagger, Longsword, Longbow" };

    }

    class RandomShop
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var list = new List<string> { "Rifle", "Dagger", "Longsword", "Longbow" };
            int index = random.Next(list.Count);
            Console.WriteLine(list[index]);
        }
    }
}
