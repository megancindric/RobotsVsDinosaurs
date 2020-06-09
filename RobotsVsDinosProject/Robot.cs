using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosProject
{
    class Robot
    {
        //member variables(has a...)
        public string robotName;
        public int robotHealth; //start at 5100
        public int robotPowerLevel; //start at 50, lost 10 per attack
        public Weapon robotWeapon; // user input to select
        public int robotAttackPower; //between 10 and 30?
        public Random random = new Random();
        public WeaponInventory weaponInventory = new WeaponInventory();

        //constructor (spawner)
        public Robot(string robotName)
        {
            this.robotName = robotName;
            robotHealth = 100;
            robotPowerLevel = 50;
            robotWeapon = SelectWeapon(weaponInventory);
            robotAttackPower = random.Next(10,20) + robotWeapon.attackPower;
        }

        //member methods(can do...)
        public Weapon SelectWeapon(WeaponInventory weaponInventory)
        {
            int index = random.Next(0, 4);
            Weapon currentWeapon = weaponInventory.weaponList[index];
            return currentWeapon;
            //check later to make sure we need to return this here
        }
        public void RobotAttack(Robot robot, Dinosaur dinosaur)
            //dinosaur parameter will come from calling selectdinotoattack method
        {
            dinosaur.dinoHealth -= robotAttackPower;
            robot.robotPowerLevel -= 10;
            Console.WriteLine($"{robot.robotName} attacks {dinosaur.dinoType} with {robot.robotWeapon.weaponType} and did {robotAttackPower} damage.  {dinosaur.dinoType} has {dinosaur.dinoHealth} health remaining!");
            //this will take into account robot's attack power, will detract from dinosaur target's health
            //if dinosaur.dinoHealth <= 0 run DinosaurDeath method
        }
    }
}
