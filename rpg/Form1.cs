using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rpg
{
    public partial class Form1 : Form
    {
        void LableUpdate()
        {
            label1hp.Text = "hp" + titan.Hp.ToString();
            label1mana.Text = "mana" + titan.Mana.ToString();
            label1arm.Text = "arm" + titan.Armor.ToString();
            label2hp.Text = "hp" + invoker.Hp.ToString();
            label2mana.Text = "mana" + invoker.Mana.ToString();
            label2arm.Text = "arm" + invoker.Armor.ToString();
            label3hp.Text = "hp" + sisadmin.Hp.ToString();
            label3mana.Text = "mana" + sisadmin.Mana.ToString();
            label3arm.Text = "arm" + sisadmin.Armor.ToString();
            label4hp.Text = "hp" + Ninjos.Hp.ToString();
            label4arm.Text = "arm" + Ninjos.Armor.ToString();
            label4mana.Text = "mana" + Ninjos.Mana.ToString();
            label5hp.Text = "hp" + cheater.Hp.ToString();
            label5mana.Text = "mana" + cheater.Mana.ToString();
            label5arm.Text = "arm" + cheater.Armor.ToString();
            Anlabel1hp.Text = "hp" + titan1.Hp.ToString();
            Anlabel1mana.Text = "mana" + titan1.Mana.ToString();
            Anlabel1arm.Text = "arm" + titan1.Armor.ToString();
            Anlabel2hp.Text = "hp" + invoker1.Hp.ToString();
            Anlabel2mana.Text = "mana" + invoker1.Mana.ToString();
            Anlabel2arm.Text = "arm" + invoker1.Armor.ToString();
            Anlabel3hp.Text = "hp" + sisadmin1.Hp.ToString();
            Anlabel3mana.Text = "mana" + sisadmin1.Mana.ToString();
            Anlabel3arm.Text = "arm" + sisadmin1.Armor.ToString();
            Anlabel4hp.Text = "hp" + Ninjos1.Hp.ToString();
            Anlabel4arm.Text = "arm" + Ninjos1.Armor.ToString();
            Anlabel4mana.Text = "mana" + Ninjos1.Mana.ToString();
            Anlabel5hp.Text = "hp" + cheater1.Hp.ToString();
            Anlabel5mana.Text = "mana" + cheater1.Mana.ToString();
            Anlabel5arm.Text = "arm" + cheater1.Armor.ToString();

        }
        Character titan = new Titan(500, 300, 15, 30, 0);
        Character sisadmin = new siskadmin(250, 500, 5, 20, 0);
        Character invoker = new invoker(350, 200, 500, 20, 0);
        Character Ninjos = new Ninjos(300, 400, 3, 100, 0.1);
        Character cheater = new cheater(99999, 99999, 99999, 9999999, 9999999999);
        Character titan1 = new Titan(500, 300, 15, 30, 0);
        Character sisadmin1 = new siskadmin(250, 500, 5, 20, 0);
        Character invoker1 = new invoker(350, 200, 500, 20, 0);
        Character Ninjos1 = new Ninjos(300, 400, 3, 100, 0.1);
        Character cheater1 = new cheater(99999, 99999, 99999, 9999999, 9999999999);
        public Form1()
        {
            InitializeComponent();
            LableUpdate();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            List<Character> targets = new List<Character>();
            targets.Add(titan1);
            listBox1.Items.Add(titan.Skill1(targets));
            LableUpdate();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            List<Character> targets = new List<Character>();
            targets.Add(titan1);
            listBox1.Items.Add(invoker.Skill1(targets));
            LableUpdate();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            List<Character> targets = new List<Character>();
            targets.Add(titan1);
            listBox1.Items.Add(sisadmin.Skill1(targets));
            LableUpdate();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Character> targets = new List<Character>();
            targets.Add(titan1);
            listBox1.Items.Add(Ninjos.Skill1(targets));
            LableUpdate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Character> targets = new List<Character>();
            targets.Add(titan1);
            listBox1.Items.Add(cheater.Skill1(targets));
            LableUpdate();
        }

    }
}
