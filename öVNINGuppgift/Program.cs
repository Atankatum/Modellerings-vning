using System;

namespace öVNINGuppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Player Sebbe = new Player();
            Sebbe.hp = 10;
            Sebbe.def = 5;
            Sebbe.att = 5;
            Sebbe.currentWeapon = new NoWeapon();
            Player Snow = new Player();
            while (Sebbe.alive == true || Snow.alive == true)
            {
                
            }

        }
    }
}
