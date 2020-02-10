using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsDinosaurs
{
    class Robot
    {
        public string name;
        public int memory;
        public int batteryPercentageFull;
        public Weapon weapon;
        public int attackForce;
        public int speed;
        //constuctor (spawner)
        public Robot()
        {
            name = "Destroyer Bot";
            memory = 10000;
            batteryPercentageFull = 100;
            attackForce = 1000;
            speed = 100;
        }
        //member methods (Can Do)
        //robot attacks
         public void  Attack() 
        {
            

             batteryPercentageFull -= 10;
        }


        //choose a weapon from weapon list
        public void SelectWeapon() 
        {
            Console.WriteLine("Please select your weapon of attack. Choose 1 for Chain Saw 2 for Laser Beam or 3 for Electrocute");
           int input = Convert.ToInt32(Console.ReadLine());
            switch(input)
            {
                case 1:
                    weapon = new Weapon("chain saw");
                    break;
                case 2:

               

            }
        }

        //outsmart the enemy..find weakness
       
       //reboot health
      //  public void Rest() 
       // {
        
        //}
        //escape
      //  public void Escape() 
      //  {
        
        }
        //defend
        //public void Defend() 
        //{
            
        //}
        //call for help
       // public void Help() 
       //

        public string PowerUp() 
        {
            Console.WriteLine("Ready to battle?)
               battery = Console.ReadLine();
        }



    }


