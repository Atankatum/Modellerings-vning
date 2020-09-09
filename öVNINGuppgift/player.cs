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
        public float positionx;
        public float positiony;
        public float positionz;
        public bool alive = true;
    }
}
