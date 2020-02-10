using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsDinosaurs
{
    class Fleet
    {
       public List<Robot> robots;

        public Fleet()
       {
            robots = new List<Robot>();
            Robot robot1 = new Robot("Destroyer Bot");
            Robot robot2 = new Robot("Destructor Bot");
            Robot robot3 = new Robot("Deadly Bot");
            robots.Add(robot1);
            robots.Add(robot2);
            robots.Add(robot3);
        }
        
        

        //list of robots
    }
}
