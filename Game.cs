using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingGame
{
    public class Game
    {
        public static int oppentDamage { get; private set; }

        public static void GameIntro()
        {
            var start = "YES";



            if (start == "YES")
            {

                Console.WriteLine("Are YOU ready to test your Boxing Skills and Challenge the Champion?");
                Console.WriteLine();
                Console.WriteLine("Enter \"YES\" to begin or \"NO\" to exit");
                string userAnswer = Console.ReadLine();

                if (userAnswer == "YES")
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("ANNOUCER SPEAKING: For the thousands in attendance and the millions watching on-line,"
                        + " LET'S GET READY TO RUMBLE!!!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (userAnswer == "NO")
                {
                    Console.WriteLine();
                    Console.WriteLine("WHAT? YOU SCARED!, I UNDERSTAND CHUMP! \n" +
                        "Unfortunately \"NO\" is not an option for You!");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("ANNOUCER SPEAKING: For the thousands in attendance and the millions watching on-line,"
                        + " LET'S GET READY TO RUMBLE!!!");

                }
            }




            do
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine();
                Console.WriteLine("ANNOUCER SPEAKING: We have the challenger fighting out of the white corner, \n" +
                    "hailing from nowhere special with a record of Zero Wins and Zero Loses, \n" +
                    "He is here tonight to challenge the Champion!");
                Console.WriteLine();
                Console.WriteLine("ANNOUCER SPEAKING: AND WE HAVE THE CHAMPION! fighting out of the black corner, \n" +
                    "hailing from the Orion Constellation with an UNDEFEATED record and showing no signs of mercy! \n" +
                    "He has accepted the challenge!");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("LETS GET IT ON!!!!!");
                Console.WriteLine();
            }
            while (false);


            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("ANNOUCER SPEAKING: Both men are in their corner waiting for the bell, \n" +
                "you can feel the intensity and the atmosphere is electric!");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Bell Sounds: DING! DING!");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("ANNOUCER SPEAKING: Both men move to the center of the Ring!  \n" +
                "and the fight has started!");
            Console.WriteLine();
            Thread.Sleep(18000);
            Console.Clear();


        }

        public static void PressEnter()
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("(Press \"ENTER\" to continue.)");
            Console.ReadKey();


        }



        public static void RunGame_Round1()
        {
            Random rng = new Random();
            int energyLose = 0;
            int attackDamage = 0;
            int opponentDamage = 0;


            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("CHAMPION throws a quick jab");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Choose option: \n" +
                "1. Defense: Block Jab \n" +
                "2. Counter Punch: Jab \n" +
                "3. Counter Punch: Uppercut \n");
            int parsedUserInput = int.Parse(Console.ReadLine());
            Thread.Sleep(1000);
            Console.WriteLine();

            if (parsedUserInput == 1)
            {
                energyLose -= rng.Next(0, 15);
                Console.WriteLine($"Playing defense lowered your energy by {energyLose} points");

            }
            if (parsedUserInput == 2)
            {
                energyLose -= rng.Next(0, 20);
                Console.WriteLine($"You counter attacked with a jab, the jab missed and decresed your energy by {energyLose} points");
            }
            if (parsedUserInput == 3)
            {
                attackDamage += rng.Next(10, 20);
                Console.WriteLine($"You counter attacked with an Uppercut and it landed inflicting {attackDamage} damage points");
            }



            Thread.Sleep(1000);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("ANNOUCER SPEAKING: The action has started who will inflict the most damage \n" +
                "and have the energy to last will WIN!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("CHAMPION throws another quick jab followed by a uppercut");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Choose option: \n" +
                "1. Defense: Block Jab and Slide \n" +
                "2. Counter Punch: Jab \n" +
                "3. Counter Punch: Uppercut \n");
            int parsedUserInput2 = int.Parse(Console.ReadLine());
            Thread.Sleep(1000);
            Console.WriteLine();

            if (parsedUserInput2 == 1)
            {
                energyLose -= rng.Next(0, 15);
                Console.WriteLine($"Playing defense lowered your energy by {energyLose} points");

            }
            if (parsedUserInput2 == 2)
            {
                opponentDamage += rng.Next(40, 50);
                Console.WriteLine($"You counter attacked with a jab, missed and oppponent scored {opponentDamage} damage points");
            }
            if (parsedUserInput2 == 3)
            {
                attackDamage += rng.Next(20, 30);
                Console.WriteLine($"You counter attacked with an Uppercut and it landed inflicting {attackDamage} damage points");

            }



            Thread.Sleep(1000);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("ANNOUCER SPEAKING: The dance is in motion and who wants it more. We will find that out soon enough!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("CHAMPION slides to the left and takes aim at your chest");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Choose option: \n" +
                "1. Defense: Lower your shoulder to deflect punch \n" +
                "2. Counter Punch: Jab to the body then head \n" +
                "3. Counter Punch: Uppercut \n");
            int parsedUserInput3 = int.Parse(Console.ReadLine());
            Thread.Sleep(1000);
            Console.WriteLine();

            if (parsedUserInput3 == 1)
            {
                energyLose -= rng.Next(5, 20);
                Console.WriteLine($"Playing defense lowered your energy by {energyLose} points");

            }
            if (parsedUserInput3 == 2)
            {
                attackDamage += rng.Next(40, 50);
                Console.WriteLine($"You counter attacked with a jab to the body and head\n" +
                    $"both puches landed and you inflicted {attackDamage} damage points");
            }
            if (parsedUserInput3 == 3)
            {
                energyLose -= rng.Next(20, 30);
                Console.WriteLine($"You counter attacked with an Uppercut and it missed badly lowering your energy by {energyLose} points");

            }



            Thread.Sleep(1000);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("ANNOUCER SPEAKING: Can you believe this action! Get a Doctor ready! " +
                "It is getting Medievel inside the square circle!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("CHAMPION moves slightly to the right and swings with his Left and then a right handed jab");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Choose option: \n" +
                "1. Defense: Move back and reposition \n" +
                "2. Counter Punch: Jab \n" +
                "3. Counter Punch: Uppercut \n");
            int parsedUserInput4 = int.Parse(Console.ReadLine());
            Thread.Sleep(1000);
            Console.WriteLine();

            if (parsedUserInput4 == 1)
            {
                energyLose -= rng.Next(0, 5);
                Console.WriteLine($"Playing defense lowered your energy by {energyLose} points");

            }
            if (parsedUserInput4 == 2)
            {
                attackDamage += rng.Next(20, 35);
                Console.WriteLine($"You counter attacked with a right jab, it landed and inflicted {attackDamage} damage points");
            }
            if (parsedUserInput4 == 3)
            {
                opponentDamage += rng.Next(30, 50);
                Console.WriteLine($"You counter attacked with an Uppercut and it was ineffective,\n" +
                    $"opponent landed both punches resulting in {opponentDamage} damage points");

            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("ANNOUCER SPEAKING: Thats the end of Round 1.\n" +
                "Someone call the Fire Department its heatin up in here!\n" +
                "What does Round 2 have planned, I am not sure but Here is the Bell!");
            Thread.Sleep(4000);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(4000);


        }

        public static void PressEnter2()
        { 

            Thread.Sleep(1000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("(Press \"ENTER\" to continue.)");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;


        }

        public static void RunGame_Round2()
        {
            Console.Clear();
            Console.WriteLine("Bell Sounds: DING! DING!");
            Console.WriteLine();
            Thread.Sleep(1000);
        }


    }



}
