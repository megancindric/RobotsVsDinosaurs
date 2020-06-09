using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosProject
{
    class AttackArray
    {
        public Attack[] attackArray;
        //constructor
        public AttackArray()
        {
            attackArray = new Attack[5];
            AddAttackValues(attackArray);
        }
        public Attack[] AddAttackValues(Attack[] attackArray)
        {
            List<string> attackType = new List<string>() { "Trash Talk", "Dino Stomp", "Face Punch", "Tail Slap", "VoidScream" };
            for (int i = 0; i < 5; i++)
            {
                Attack attackToAdd = new Attack(attackType[i]);
                attackArray[i] = attackToAdd;
            }
            return attackArray;
        }

    }
}
