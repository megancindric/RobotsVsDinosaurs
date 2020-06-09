using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosProject
{
    class Herd
    {
        //member variables(has a...)
        public List<Dinosaur> dinosaurHerd;

        //constructor (spawner)
        public Herd()
        {
            List<string>dinosaurNames = new List<string>() { "T-Rex", "Triceratops", "Velociraptor" };
            dinosaurHerd = new List<Dinosaur>();
            for (int i = 0; i < 3; i++)
            {
                Dinosaur dinosaur = new Dinosaur(dinosaurNames[i]);
                dinosaurHerd.Add(dinosaur);
            }
        }

        //member methods(can do...)
        public void DinosaurHerdAttack()
        {
            //this will create our loop for every robot attacking
            for (int i = 0; i < dinosaurHerd.Count; i++)
            {
                //select robot to attack
                //Attack that robot
            }
        }
        public void DinosaurDeath(Dinosaur dinosaur)
        {
            dinosaurHerd.Remove(dinosaur);
            Console.WriteLine($"Uh oh!  Looks like {dinosaur.dinoType} has died!  That sucks");
        }
    }
}
