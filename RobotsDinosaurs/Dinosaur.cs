using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsDinosaurs
{
    class Dinosaur
    {

        public string name;
        public int health;
        public int powerLevelPercent;
        public string weapon;
        public int attackForce;
        
        //constuctor (spawner)
        public Dinosaur()
        {
            name = "T Rex";
            health = 10000;
            powerLevelPercent = 100;
            weapon = "";
            attackForce = 1000;
           
        }
        //member methods (Can Do)
        //robot attacks
        public void Attack()
        {
          powerLevelPercent -= 10;
        }


        //choose a weapon
        //public void SelectWeapon()
        //{
        //    Console.WriteLine("Please select your weapon of attack. Choose 1 for Chain Saw 2 for Laser Beam or 3 for Electrocute");
        //    string input = Convert.ToInt32(Console.ReadLine());
        //    switch (input)
        //    {
        //        case 1:
        //        case 1.:
        //            Weapon =

        //    }
        //}
        //reboot health
        //public void Rest()
        //{

        //}
        //escape
        //public void Escape()
        //{

        //}
        //defend
        //public void Defend()
        //{

        //}
        //call for help
        //public void Help()
        //{

        //}

        public string PowerUp()
        {
            Console.WriteLine("Ready to battle?)
               battery = Console.ReadLine();
        }
    }
}
