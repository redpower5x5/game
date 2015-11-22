using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg
{
    public abstract class Character
    {
        public abstract string Skill1(List<Character> targets);

        private int hp;
        public int Hp
        {
            get { return hp; }
            set { hp = value; }
        }
        private int armor;
        public int Armor
        {
            get { return armor; }
            set { armor = value; }
        }
        private int mana;
        public int Mana
        {
            get { return mana; }
            set { mana = value; }
        }
        private int force;
        public int Force
        {
            get { return force; }
            set { force = value; }
        }

        private double evasion;
        public virtual double Evasion
        {
            get { return evasion; }
            set { evasion = value; }
        }
    }
}
