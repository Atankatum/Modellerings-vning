using System;

namespace öVNINGuppgift
{
    public class Player
    {
        public int hp;
        public int att;
        public int def;
        public int spd;
        public Weapon currentWeapon = new Axe();
        public bool alive = true;

        public int Attack()
        {
            return att + currentWeapon.dmg;
        }

    }
}
