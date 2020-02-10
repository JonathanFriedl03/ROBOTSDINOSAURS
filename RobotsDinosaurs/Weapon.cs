using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsDinosaurs
{
    class Weapon
    {
        string[] weaponNames;
        public string weapontype;

        //constuctor (spawner)
        public Weapon(string type)
        {
            weaponNames = new string [6] { "Smash", "Bite", "Claw", "Chain Saw","Laser Beam","Electrocute", };  
            int [] damageDone = new int[6] { 30, 20, 10, 30, 20, 10, } ;
            int [] remainingUses = new int[1] { 10 };

            weapontype = type;
            
        }
        //member methods (Can Do)
        //robot attacks
        public void DisplayWeapon()
        {
           // Console.WriteLine("Select a weapon );
           //yourWeapon = 

        }


        
    }
}
