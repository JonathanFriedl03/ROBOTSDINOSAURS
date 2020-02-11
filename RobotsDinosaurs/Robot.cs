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
        public Weapon botWeapon;
        public int attackForce;
        
        //constuctor (spawner)
        public Robot(string roboName)
        {
            name = roboName;
            memory = 1000; //same as health
            batteryPercentageFull = 100; //same as power level
            attackForce = 100;
            botWeapon = new Weapon(); 
        }
        public void AttackDino()
        {
            attack = 
        }
        //public void LossOfBatteryPercentFull()
        //{
        //    batteryPercentageFull -= 10;

        //}


        //choose a weapon from weapon list
        //public void SelectWeapon() 
        //{
        //    botWeapon = new Weapon();
        //}
        

        //Console.WriteLine("Please select your weapon of attack. Choose 1 for Chain Saw 2 for Laser Beam or 3 for Electrocute");
        //   int input = Convert.ToInt32(Console.ReadLine());
        //    switch(input)
        //    {
        //        case 1:
        //weapon = new Weapon("chain saw");
        //            break;
        //        case 2:
        //            weapon = new Weapon("");
        //                break;


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

        //public string PowerUp() 
        //{
        //    Console.WriteLine("Ready to battle?)
        //       battery = Console.ReadLine();
        //}



    //}


