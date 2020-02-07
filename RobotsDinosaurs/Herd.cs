using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsDinosaurs
{
    class Herd
    {

        public string name;
        public int height;
        public int memory;
        public bool battery;
        public string weapon;
        public int attackForce;
        public int speed;
        //constuctor (spawner)
        public Robot()
        {
            name = "Destroyer";
            height = 1000;
            memory = 1000;
            battery = false;
            weapon = "blade";
            attackForce = 1000;
            speed = 100;
        }
        //member methods (Can Do)
        //robot attacks
        public void Attack()
        {

        }


        //choose a weapon
        public void SelectWeapon()
        {

        }
        //outsmart the enemy
        public void OutSmart()
        {

        }
        //reboot health
        public void Rest()
        {

        }
        //escape
        public void Escape()
        {

        }
        //defend
        public void Defend()
        {

        }
        //call for help
        public void Help()
        {

        }

        public string PowerUp()
        {
            Console.WriteLine("Ready to battle?)
               battery = Console.ReadLine();
        }
    }
}
