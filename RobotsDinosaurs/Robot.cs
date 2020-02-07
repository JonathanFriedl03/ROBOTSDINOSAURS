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
        public string height;
        public int memory;
        public bool battery;
        public string weapon;
        public int attackForce;
        public int speed;
        //constuctor (spawner)
        public Robot()
        {
            name = "Destroyer";
            height = "5 feet";
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
        //outsmart the enemy..find weakness
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


    class Clock
        {
            //memeber variables (Has A)
            public string time;
            public bool alarmStatus;
            public string alarmTime;
            public string date;


            //constuctor (spawner)
            public Clock()
        {
            time = "12:00am";
            alarmStatus = false;
            alarmTime = null;
            date = "01/01/0001";
        }
        //member methods (Can Do)
        public void Initialize()
        {
            ChangeTime();
            ChangeDate();
            AlarmSetup();
        }
        public void ChangeTime()
        {
            Console.WriteLine("Please enter the new time: ");
            time = Console.ReadLine();
        }
        public void ChangeDate()
        {
            Console.WriteLine("Please enter the new Date: ");
            date = Console.ReadLine();
        }
        public void AlarmSetup()
        {
            bool isValid = false;
            int numberOfWrong = 0;
            do
            {
                Console.WriteLine("Would you like to set up an alarm?");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "Yeah":
                    case "Yup":
                    case "yup":
                    case "Yes":
                    case "yes":
                        ToggleAlarm();
                        SetAlarm();
                        isValid = true;
                        break;
                    case "no":
                        Console.WriteLine("You can set an alarm later");
                        isValid = true;
                        break;
                    default:
                        Console.WriteLine("Please enter a confirmation");
                        numberOfWrong++;
                        break;
                }
            } while (isValid == false && numberOfWrong < 5);
        }
        public void ToggleAlarm()
        {
            alarmStatus = !alarmStatus;
        }
        public void SetAlarm()
        {
            Console.WriteLine("Please enter the new alarm time: ");
            alarmTime = Console.ReadLine();
        }
        public void DisplayTime()
        {
            Console.WriteLine("The current time is: " + time);
        }
        public void DisplayDate()
        {
            Console.WriteLine("The current date is: " + date);
        }



    }
}
