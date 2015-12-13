using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg
{
    class invoker : Character
    {
        public invoker(int hp, int mana, int armor, int force, double evasion)
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
                base.Evasion = (int)value;
            }
        }
        public override string Skill1(List<Character> targets)
        {
            if (this.Mana >= 200)
            {
                foreach (Character c in targets)
                {
                    if (this.Force > c.Armor)
                    {


                        c.Hp -= (this.Force - c.Armor);
                    }





                }
                Mana = Mana - 200;
                
                
                return "Ничего... сисадмин мне поможет.";
            }
            else { return "Not enought Mana"; }
        }
    }
}
