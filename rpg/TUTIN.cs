using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg
{
    class Titan : Character
    {
        public Titan(int hp, int mana, int armor, int force, double evasion)
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
                if(this.Mana>=20)
                {
                   this. Armor += 2;
                Mana = Mana - 20; 
                return "Ммм, я тебе нравлюсь? Дааа... побей меня...";
                }
                else { return "Not enought Mana"; }
            }
    }
}
