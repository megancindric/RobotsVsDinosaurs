using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace RobotsVsDinosProject
{

    class WeaponInventory
    {
        public List<Weapon> weaponList;
        //constructor
        public WeaponInventory()
        {
            weaponList = new List<Weapon>();
            List<string> weaponNames = new List<string>() { "Chainsaw Gun", "Shark Cannon", "Can of Spaghetti", "Normal gun", "Bear Hands" };
            for (int i = 0; i < 3; i++)
            {
                Weapon weapon = new Weapon(weaponNames[i]);
            }
    }
}
}
