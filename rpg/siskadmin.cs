using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg
{
    class siskadmin : Character
    {
        public siskadmin(int hp, int mana, int armor, int force, double evasion)
        {
            this.Hp = hp;
            this.Mana = mana;
            this.Armor = armor;
            this.Force = force;
            this.Evasion = evasion;
        }
        public override double Evasion
        {
            get
            {
                return base.Evasion;
            }
            set
            {
                base.Evasion = value;
            }
        }
        public override string Skill1(List<Character> targets)
        {
            if (this.Mana >= 100)
            {
                targets[0].Hp += this.Force * 3;
                Mana = Mana - 100;
                return "К вашим услугам.";
            }
            else { return "Not enought mana"; }
        }
    }
}
