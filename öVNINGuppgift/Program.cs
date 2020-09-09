using System;

namespace öVNINGuppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Player nisse = new Player();
            Player elin = new Player();
            while (nisse.alive == true)
            {
                System.Console.WriteLine("nisse attacks with his " + nisse.currentWeapon.name);
            }

        }
    }
}
