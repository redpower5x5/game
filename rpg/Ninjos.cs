using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg
{
    class Ninjos : Character
    {
        public Ninjos(int hp, int mana, int armor, int force, double evasion)
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
            if (this.Mana >= 120)
            {
                targets[0].Armor -= 1;
                targets[0].Hp -= (this.Force - targets[0].Armor);
                Mana = Mana - 120;
                return "Я забираю твой армор, и 100 хп, sasai!";
            }
            else { return "Not enoght mana"; }
        }
    }
}
