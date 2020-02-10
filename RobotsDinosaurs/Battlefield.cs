using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsDinosaurs
{
    class Battlefield
    {
        
        int playerOneScore;
        int playerTwoScore;
        Random rnd = new Random();

        
        public Battlefield()
        {
            playerOneScore = 0;
            playerTwoScore = 0;
        }
       
        public int Fight()
        {
            int result;


            result = rnd.Next(1, 7);

            return result;


        }

        


        }
    }
}
