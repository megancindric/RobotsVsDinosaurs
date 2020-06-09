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
       
    }
}
