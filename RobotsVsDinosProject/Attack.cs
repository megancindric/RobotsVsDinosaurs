using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosProject
{
    class Attack
    {
        //member variables(has a...)
        public string attackType;
        public int attackPower;
        public Random random = new Random();
        //constructor (spawner)
        public Attack(string attackType)
        {
            this.attackType = attackType;
            this.attackPower = random.Next(10, 30);
        }
       
        //member methods(can do...)
    }
}
