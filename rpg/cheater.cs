using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg
{
   public class cheater : Character
    {
        public cheater(int hp, int mana, int armor, int force, double evasion)
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
            Mana = Mana - 0;
            return "СМЕРТЬ С 1 ТЫЧКИ??? АХАХАХАХА";
        }
    }
}
