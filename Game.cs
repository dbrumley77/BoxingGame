using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingGame
{
    public class Game
    {
        public static void RunGame()
        {
            var start = "YES";



            if (start == "YES")
            {

                Console.WriteLine("Are YOU ready to test your Boxing Skills and Challenge the Champion?");
                Console.WriteLine();
                Console.WriteLine("Press \"YES\" to begin or \"NO\" to exit");
                string userAnswer = Console.ReadLine();

                if (userAnswer == "YES")
                {
                    Console.WriteLine();
                    Console.WriteLine("For the thousands in attendance and the millions watching on-line,"
                        + " LET'S GET READY TO RUMBLE!!!");
                }
                if (userAnswer == "NO")
                {
                    Console.WriteLine();
                    Console.WriteLine("WHAT? your scared, I understand chump. \n" +
                        "Unfortunately \"NO\" is not an option for You!");

                }
            }
        
            
            

            do 
            {
                Console.WriteLine();
                Console.WriteLine("We have the challenger fighting out of the white corner, \n" +
                    "hailing from the nowhere special with a record of Zero Wins and Zero Loses, \n" +
                    "is here tonight to challenge the Champion!");
                Console.WriteLine();
                Console.WriteLine("AND WE HAVE THE CHAMPION! fighting out of the black corner, \n" +
                    "hailing from the Orion Constellation with an UNDEFEATED record and showing no signs of mercy, \n" +
                    "has accepted the challenge!");
                Console.WriteLine();
                Console.WriteLine("LETS GET IT ON!!!!!");
                Console.WriteLine();
            }
            while(false);


            
            Console.WriteLine("ANNOUCER SPEAKING: Both men are in their corner waiting for the bell, \n" +
                "you can feel the intensity and the atmosphere ie electric!");
            Console.WriteLine();
            Console.WriteLine("Bell Sounds: DING! DING!");
            Console.WriteLine();
            Console.WriteLine("ANNOUCER SPEAKING: Both men move to the center of the Ring!  \n" +
                "and the fight has started!");






        }


    }



}
