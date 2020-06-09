using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosProject
{
    class Weapon
    {
        //member variables(has a...)
        public string weaponType;
        public int attackPower;
        public Random random = new Random();
        //constructor (spawner)
        public Weapon(string weaponType)
        {
           this.weaponType = weaponType;
           this.attackPower = random.Next(10, 30);
        }
        //member methods(can do...)

    }
}
