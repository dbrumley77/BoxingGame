using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingGame
{
    public class Challenger
    {
        Challenger challenger = new Challenger();

        public static int Health { get; set; } 

        public static int Energy { get; set; } 

        public static int Damage { get; set; } 

        public int AttackDamage { get; set; }

        public static bool IsAlive { get; set; }


        public static bool LifeCheck()
        {
            if (Health <= 0)
            {
                return IsAlive = false;
            }
            else
                return IsAlive = true;

        }

        public static void TakeDamage(int damage)
        {

            if (damage > Health)
            {
                Health = 0;
            }
            else
            {
                Health -= damage;
            }


        }

        public static void Heal(int heals)
        {
            if (heals + Health > 100)
            {
                Health = 100;
            }
            else
            {
                Health += heals;
            }
        }




    }




}
